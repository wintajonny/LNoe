using HelloMVCSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVCSample.CommentStorage
{
    public interface ICommentStore
    {
        IEnumerable<CommentItem> GetNewestComments(int commentCount);
        CommentItem CreateComment(string username, string message);
        int GetNumberOfComments();
    }
}
