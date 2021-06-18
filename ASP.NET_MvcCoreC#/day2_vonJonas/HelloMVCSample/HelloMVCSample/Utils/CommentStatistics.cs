using HelloMVCSample.CommentStorage;
using HelloMVCSample.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVCSample.Utils
{
    public class CommentStatistics : ViewComponent
    {
        private readonly ICommentStore _Store;

        public CommentStatistics(CommentStorage.ICommentStore store)
        {
            _Store = store;
        }
        public async Task<IViewComponentResult> InvokeAsync(bool useEmpty)
        {
            int count = _Store.GetNumberOfComments();
            if (count == 0 && useEmpty)
            {
                return View("empty");
            }
            return View(new CommentStatisticViewModel() { TotalCount = count });
        }
    }
}
