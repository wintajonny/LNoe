using HelloMVCSample.CommentStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVCSample.Models
{
    public class CommentViewModel
    {
        public CommentViewModel(CommentItem x)
        {
            Username = x.UserName;
            Message = x.Message;
            Posted = x.Posted;
        }

        public string Username { get; set; }
        public string Message { get; set; }
        public DateTime Posted { get; set; }
    }
}
