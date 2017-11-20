﻿using System.Collections.Generic;
using System.Linq;
using Abp.Localization;
using NG.PhoneBook.EntityFramework;

namespace NG.PhoneBook.Migrations.SeedData
{
    public class DefaultLanguagesCreator
    {
        public static List<ApplicationLanguage> InitialLanguages { get; private set; }

        private readonly PhoneBookDbContext _context;

        static DefaultLanguagesCreator()
        {
            InitialLanguages = new List<ApplicationLanguage>
            {
                new ApplicationLanguage(null, "en", "English", "famfamfam-flag-gb"),
                new ApplicationLanguage(null, "tr", "Türkçe", "famfamfam-flag-tr"),
                new ApplicationLanguage(null, "zh-CN", "简体中文", "famfamfam-flag-cn"),
                new ApplicationLanguage(null, "pt-BR", "Português-BR", "famfamfam-flag-br"),
                new ApplicationLanguage(null, "es", "Español", "famfamfam-flag-es"),
                new ApplicationLanguage(null, "fr", "Français", "famfamfam-flag-fr"),
                new ApplicationLanguage(null, "it", "Italiano", "famfamfam-flag-it"),
                new ApplicationLanguage(null, "ja", "日本語", "famfamfam-flag-jp"),
                new ApplicationLanguage(null, "nl-NL", "Nederlands", "famfamfam-flag-nl"),
                new ApplicationLanguage(null, "lt", "Lietuvos", "famfamfam-flag-lt")
            };
        }

        public DefaultLanguagesCreator(PhoneBookDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateLanguages();
        }

        private void CreateLanguages()
        {
            foreach (var language in InitialLanguages)
            {
                AddLanguageIfNotExists(language);
            }
        }

        private void AddLanguageIfNotExists(ApplicationLanguage language)
        {
            if (_context.Languages.Any(l => l.TenantId == language.TenantId && l.Name == language.Name))
            {
                return;
            }

            _context.Languages.Add(language);

            _context.SaveChanges();
        }
    }
}
