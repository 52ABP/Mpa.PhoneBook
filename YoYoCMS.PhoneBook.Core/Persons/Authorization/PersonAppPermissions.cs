 
using System.Collections.Generic;
using Abp.Authorization;
using Abp.Localization;

namespace YoYoCMS.PhoneBook.Persons.Authorization
{
  //TODO:★请将此类剪切到core/Authorization文件夹下
	 /// <summary>
	 /// 定义系统的权限名称的字符串常量。
     /// <see cref="PersonAppAuthorizationProvider"/>中对权限的定义.
     /// </summary>
  public static   class PersonAppPermissions
    {
      

        /// <summary>
        /// 联系人管理权限
        /// </summary>
        public const string Person = "Persons.Person";

	 

		/// <summary>
        /// 联系人创建权限
        /// </summary>
        public const string Person_CreatePerson = "Persons.Person.CreatePerson";
		/// <summary>
        /// 联系人修改权限
        /// </summary>
        public const string Person_UpdatePerson = "Persons.Person.UpdatePerson";
		/// <summary>
        /// 联系人删除权限
        /// </summary>
        public const string Person_DeletePerson = "Persons.Person.DeletePerson";
    }
	
}

