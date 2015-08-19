using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamWorkerStudioJobs.Models
{
    public  class ApplyForJobResult
    {
        public long ID { get; set; }

        [Display(Name = "密码")]
        public long Password { get; set; }

        [Display(Name = "项目")]
        public string Project { get; set; }

        [Display(Name = "职位")]
        public string Job { get; set; }

        [Display(Name = "性别")]
        public Sex Sex { get; set; }

        [Display(Name = "姓")]
        public string Xing { get; set; }


        [Display(Name = "名")]
        public string Ming { get; set; }

        [Display(Name = "英文名")]
        public string FirstName { get; set; }

        [Display(Name = "英文姓")]
        public string FamilyName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "电话号码")]
        public string PhoneNumber { get; set; }

        [Display(Name = "年级")]
        public int Grade { get; set; }

        [Display(Name = "班级")]
        public int Class { get; set; }

        [Display(Name = "中考分数")]
        public int Mark { get; set; }

        [Display(Name = "你的优势")]
        public string Advantage { get; set; }
    }
}
