using System;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Web.Http;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;
using Swashbuckle.Application;

namespace YoYoCMS.PhoneBook.Api
{
    [DependsOn(typeof(AbpWebApiModule), typeof(PhoneBookApplicationModule))]
    public class PhoneBookWebApiModule : AbpModule
    {
         

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(PhoneBookApplicationModule).Assembly, "app")
                .Build();

    

            Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new HostAuthenticationFilter("Bearer"));

            Configuration.Modules.AbpWebApi().HttpConfiguration.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;





            //调用SwaggerUi
            ConfigureSwaggerUi();
          
        }

        /// <summary>
        /// 配置SwaggerUi
        /// </summary>
        private void ConfigureSwaggerUi()
        {
            Configuration.Modules.AbpWebApi().HttpConfiguration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "YoYoCMS.PhoneBookAPI文档");
                    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                    //将application层中的注释添加到SwaggerUI中
                    var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                     var commentsFileName = "Bin//YoYoCMS.PhoneBook.Application.xml";
                    var commentsFile = Path.Combine(baseDirectory, commentsFileName);
                    //将注释的XML文档添加到SwaggerUI中
                    c.IncludeXmlComments(commentsFile);


                })
                .EnableSwaggerUi("apis/{*assetPath}", b =>
                {
                    //对js进行了拓展
                    b.InjectJavaScript(Assembly.GetExecutingAssembly(), "YoYoCMS.PhoneBook.SwaggerUi.scripts.translator.js");
                 });
        }

    }
}
