using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HelloMVCSample.Models
{
    public class NewCommentViewModel
    {
        public NewCommentViewModel()
        {}

        [Required(ErrorMessage ="The value for {0} is required!")]
        [MaxLength(80)]
        [Display(Prompt = "Nickname", Name = "Nickname", Description = "Your nickname field is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "The value for {0} is required!")]
        [MaxLength(1024)]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}
