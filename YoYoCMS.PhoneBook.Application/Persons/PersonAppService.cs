using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using OfficeOpenXml;
using YoYoCMS.PhoneBook.Dto;
using YoYoCMS.PhoneBook.Persons.Authorization;
using YoYoCMS.PhoneBook.Persons.Dtos;

namespace YoYoCMS.PhoneBook.Persons
{
    /// <summary>
    /// 联系人服务实现
    /// </summary>
    [AbpAuthorize(PersonAppPermissions.Person)]
    public class PersonAppService : PhoneBookAppServiceBase, IPersonAppService
    {
        private readonly IRepository<Person,int> _personRepository;
		private readonly PersonManage _personManage;

        public PersonAppService( IRepository<Person,int> personRepository	,PersonManage personManage  )
        {
            _personRepository = personRepository;
			 _personManage = personManage;

        }

    #region 联系人管理

    /// <summary>
    /// 根据查询条件获取联系人分页列表
    /// </summary>
    public async Task<PagedResultOutput<PersonListDto>> GetPagedPersonsAsync(GetPersonInput input)
{
			
    var query = _personRepository.GetAll();
    //TODO:根据传入的参数添加过滤条件

    var personCount = await query.CountAsync();

    var persons = await query
    .OrderBy(input.Sorting)
    .PageBy(input)
    .ToListAsync();

    var personListDtos = persons.MapTo<List<PersonListDto>>();
    return new PagedResultOutput<PersonListDto>(
    personCount,
    personListDtos
    );
    }

        /// <summary>
    /// 通过Id获取联系人信息进行编辑或修改 
    /// </summary>
    public async Task<GetPersonForEditOutput> GetPersonForEditAsync(NullableIdInput<int> input)
{
    var output=new GetPersonForEditOutput();

    PersonEditDto personEditDto;

    if(input.Id.HasValue)
	{
    var entity=await _personRepository.GetAsync(input.Id.Value);
    personEditDto=entity.MapTo<PersonEditDto>();
    }
	else 
	{
	personEditDto=new PersonEditDto();	
	}

	output.Person=personEditDto;
	return output;
    }


    /// <summary>
    /// 通过指定id获取联系人ListDto信息
    /// </summary>
    public async Task<PersonListDto> GetPersonByIdAsync(IdInput<int> input)
{
    var entity = await _personRepository.GetAsync(input.Id);

    return entity.MapTo<PersonListDto>();
    }







    /// <summary>
    /// 新增或更改联系人
    /// </summary>
    public async Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input)
{
    if (input.PersonEditDto.Id.HasValue)
{
    await UpdatePersonAsync(input.PersonEditDto);
    }
    else
{
    await CreatePersonAsync(input.PersonEditDto);
    }
    }

    /// <summary>
    /// 新增联系人
    /// </summary>
    [AbpAuthorize(PersonAppPermissions.Person_CreatePerson)]
    public virtual async Task<PersonEditDto> CreatePersonAsync(PersonEditDto input)
{
    //TODO:新增前的逻辑判断，是否允许新增

    var entity = await _personRepository.InsertAsync(input.MapTo<Person>());
    return entity.MapTo<PersonEditDto>();
    }

    /// <summary>
    /// 更新联系人
    /// </summary>
    [AbpAuthorize(PersonAppPermissions.Person_UpdatePerson)]
    public virtual async Task UpdatePersonAsync(PersonEditDto input)
{
    //TODO:更新前的逻辑判断，是否允许更新

    var entity = await _personRepository.GetAsync(input.Id.Value);
    await _personRepository.UpdateAsync(input.MapTo(entity));
    }

    /// <summary>
    /// 删除联系人
    /// </summary>
    [AbpAuthorize(PersonAppPermissions.Person_DeletePerson)]
    public async Task DeletePersonAsync(IdInput<int> input)
{
    //TODO:删除前的逻辑判断，是否允许删除
    await _personRepository.DeleteAsync(input.Id);
    }

        /// <summary>
    /// 批量删除联系人
    /// </summary>
    [AbpAuthorize(PersonAppPermissions.Person_DeletePerson)]
    public async Task BatchDeletePersonAsync(IEnumerable<int> input)
{
    //TODO:批量删除前的逻辑判断，是否允许删除
    await _personRepository.DeleteAsync(s=>input.Contains(s.Id));
    }

        public FileDto ExportToFile(PersonListDto personListDto)
        {
            var excelPackage=new ExcelPackage();

            var sheet = excelPackage.Workbook.Worksheets.Add("电话簿");
            sheet.OutLineApplyStyle = true;

            

            throw new System.NotImplementedException();
        }

        #endregion

    }
    }
