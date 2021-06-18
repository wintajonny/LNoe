using System;

namespace HelloMVCSample.CommentStorage
{
    public class CommentItem
    {
        public int Id { get; set; }
        public string UserName { get;  set; }
        public string Message { get;  set; }
        public DateTime Posted { get;  set; }
    }
}