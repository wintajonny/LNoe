using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVCSample.CommentStorage
{
    public class CommentStore : ICommentStore
    {


        List<CommentItem> _Storage = new List<CommentItem>();

        public CommentItem CreateComment(string username, string message)
        {
            var newComment = new CommentItem()
            {
                UserName = username,
                Message = message,
                Posted = DateTime.UtcNow
           };
            lock(this)
            {
                _Storage.Add(newComment);
                newComment.Id = _Storage.Count;

            }
            return newComment;
        }

        public IEnumerable<CommentItem> GetNewestComments(int commentCount)
        {
            return _Storage.TakeLast(commentCount);
        }

        public int GetNumberOfComments()
        {
            return _Storage.Count;
        }
    }
}
