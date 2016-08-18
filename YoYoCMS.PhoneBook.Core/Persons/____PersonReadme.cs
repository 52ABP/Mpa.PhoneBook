using System.Collections.Generic;
using Abp.Authorization;
using Abp.Localization;

namespace YoYoCMS.PhoneBook.Persons.Application
{
	
	

		//TODO:多页面后端的导航栏目设计

	/*
	//无次级导航属性
	   var person=new MenuItemDefinition(
                PersonAppPermissions.Person,
                L("Person"),
				url:"Mpa/PersonManage",
				icon:"icon-grid",
				 requiredPermissionName: PersonAppPermissions.Person
				);

*/
				//有下级菜单
            /*

			   var person=new MenuItemDefinition(
                PersonAppPermissions.Person,
                L("Person"),			
				icon:"icon-grid"				
				);

				person.AddItem(
			new MenuItemDefinition(
			PersonAppPermissions.Person,
			L("Person"),
			"icon-star",
			"person",
			requiredPermissionName: PersonAppPermissions.Person));
	

			
			*/

	
			
	
	
	
	//配置权限模块初始化

 
	    
	
 //TODO:★需要到请将以下内容剪切到YoYoCMSApplicationModule
 //   Configuration.Authorization.Providers.Add<PersonAppAuthorizationProvider>();


 

//TODO:★请将以下内容剪切到CORE类库的Localization/Source/zh-cn.xml
/*
    <!-- 联系人管理 -->


	    <text name="	PersonHeaderInfo" value="联系人信息列表" />
		    <text name="PersonDeleteWarningMessage" value="联系人名称: {0} 将被删除,是否确定删除它。" />

			    <text name="PersonName" value="联系人" />

<!--//用于表格展示的数据信息的标题-->
					<text name="Name" value="姓名" />
				 	<text name="EmailAddress" value="邮箱地址" />
				 	<text name="LastModificationTime" value="最后编辑时间" />
				 	<text name="CreationTime" value="创建时间" />
				 

    <text name="Person" value="联系人管理" />
    <text name="CreatePerson" value="新增联系人" />
    <text name="UpdatePerson" value="更新联系人" />
    <text name="DeletePerson" value="删除联系人" />
*/

/*
    <!-- 联系人english管理 -->
		    <text name="	PersonHeaderInfo" value="联系人List" />


    <text name="Person" value="ManagementPerson" />
    <text name="CreatePerson" value="CreatePerson" />
    <text name="UpdatePerson" value="UpdatePerson" />
    <text name="DeletePerson" value="DeletePerson" />
*/




}