using System.Threading.Tasks;
using Abp.Application.Services;
using NG.PhoneBook.Configuration.Dto;

namespace NG.PhoneBook.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}