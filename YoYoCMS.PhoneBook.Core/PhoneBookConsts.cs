namespace YoYoCMS.PhoneBook
{
    /// <summary>
    /// 电话薄项目的使用常量
    /// </summary>
    public static class PhoneBookConsts
    {
        public const string LocalizationSourceName = "PhoneBook";

        /// <summary>
        /// 名字最大长度
        /// </summary>
        public const int MaxNameLength = 32;
        /// <summary>
        /// Default page size for paged requests.
        /// </summary>
        public const int DefaultPageSize = 10;

        /// <summary>
        /// Maximum allowed page size for paged requests.
        /// </summary>
        public const int MaxPageSize = 1000;
        /// <summary>
        /// 邮件地址最大长度
        /// </summary>
        public const int MaxEmailAddressLength = 255;
    }
}