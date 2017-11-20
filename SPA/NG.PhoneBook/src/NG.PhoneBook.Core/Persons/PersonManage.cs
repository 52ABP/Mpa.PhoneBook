using Abp.Domain.Repositories;
using Abp.Domain.Services;

namespace NG.PhoneBook.Persons
{
    /// <summary>
    /// 联系人业务管理
    /// </summary>
    public class PersonManage : IDomainService
    {
        private readonly IRepository<Person,int> _personRepository;

        public PersonManage(IRepository<Person,int> personRepository  )
        {
            _personRepository = personRepository;
        }

		//TODO:编写领域业务代码


		/// <summary>
        ///     初始化
        /// </summary>
        private void Init()
        {







        }


		}

    
	
}
