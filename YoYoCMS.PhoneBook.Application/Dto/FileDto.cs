using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace YoYoCMS.PhoneBook.Dto
{
    /// <summary>
    /// 文件的Dto
    /// </summary>
    public class FileDto 
    {

        /// <summary>
        /// 文件名字
        /// </summary>
        [Required]
        public string FileName { get; set; }
        /// <summary>
        /// 文件类型
        /// </summary>
        [Required]
        public string FileType { get; set; }

        [Required]
        public string FileToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public FileDto()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="fileType"></param>
        public FileDto(string fileName, string fileType)
        {
            FileName = fileName;
            FileType = fileType;
            FileToken = Guid.NewGuid().ToString("N");
        }
    }
}