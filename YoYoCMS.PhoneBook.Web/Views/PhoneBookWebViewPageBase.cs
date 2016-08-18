﻿using Abp.Web.Mvc.Views;

namespace YoYoCMS.PhoneBook.Web.Views
{
    public abstract class PhoneBookWebViewPageBase : PhoneBookWebViewPageBase<dynamic>
    {

    }

    public abstract class PhoneBookWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected PhoneBookWebViewPageBase()
        {
            LocalizationSourceName = PhoneBookConsts.LocalizationSourceName;
        }
    }
}