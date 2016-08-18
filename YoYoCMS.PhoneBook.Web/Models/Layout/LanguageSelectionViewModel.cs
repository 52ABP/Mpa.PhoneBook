using System.Collections.Generic;
using Abp.Localization;

namespace YoYoCMS.PhoneBook.Web.Models.Layout
{
    public class LanguageSelectionViewModel
    {
        public LanguageInfo CurrentLanguage { get; set; }

        public IReadOnlyList<LanguageInfo> Languages { get; set; }
    }
}