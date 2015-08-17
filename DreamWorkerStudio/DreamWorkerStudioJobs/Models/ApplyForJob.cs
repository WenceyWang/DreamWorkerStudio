using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace DreamWorkerStudioJobs.Models
{
    public enum Sex
    {
        [Display(Name = "男")]
        Male,
        [Display(Name = "女")]
        Female
    }

    public class ApplyForJob
    {
        [Display(Name = "项目")]
        [Required(ErrorMessage = "你没有填写一些项目")]
        public string Project { get; set; }

        [Display(Name = "职位")]
        [Required(ErrorMessage = "你没有填写一些项目")]
        
        public string Job { get; set; }

        [Display(Name = "性别")]
        [Required(ErrorMessage = "你没有填写一些项目")]
        public Sex Sex { get; set; }

        [Display(Name = "姓")]
        [StringLength(5,ErrorMessage = "你的姓太长了")]
        [Required(ErrorMessage = "你没有填写一些项目")]
        public string Xing { get; set; }


        [Display(Name = "名")]
        [StringLength(5,ErrorMessage = "你的名太长了")]
        [Required(ErrorMessage = "你没有填写一些项目")]
        public string Ming { get; set; }

        [Display(Name = "英文名")]
        [StringLength(20,ErrorMessage = "你的英文名太长了")]
        [Required(ErrorMessage = "你没有填写一些项目")]
        public string FirstName { get; set; }

        [Display(Name = "英文姓")]
        [StringLength(20,ErrorMessage = "你的英文姓太长了")]
        [Required(ErrorMessage = "你没有填写一些项目")]
        public string FamilyName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "你没有填写一些项目")]
        [DataType(DataType.EmailAddress,ErrorMessage = "你的电子邮件格式不正确")]
        public string Email { get; set; }

        [Display(Name = "电话号码")]
        [StringLength(20,MinimumLength = 7)]
        [Required(ErrorMessage = "你没有填写一些项目")]
        [Phone(ErrorMessage = "你的电话号码格式不正确")]
        public string PhoneNumber { get; set; }

        [Display(Name = "年级")]
        [Required(ErrorMessage = "你没有填写一些项目")]
        [Range(1,3,ErrorMessage = "你的年级错误")]
        public int Grade { get; set; }

        [Display(Name = "班级")]
        [Required(ErrorMessage = "你没有填写一些项目")]
        [Range(1,10,ErrorMessage = "你的班级错误")]
        public int Class { get; set; }

        [Display(Name = "中考分数")]
        [Required(ErrorMessage = "你没有填写一些项目")]
        [Range(400,720,ErrorMessage = "你的中考分数错误")]
        public int Mark { get; set; }

        [Display(Name = "你的优势")]
        [Required(ErrorMessage = "你没有填写一些项目")]
        public string Advantage { get; set; }
    }
}

