using HelloMVCSample.CommentStorage;
using HelloMVCSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVCSample.Controllers
{
    public class CommentController : BaseController
    {
        private readonly ILogger _Logger;
        private readonly ICommentStore _Store;
        private readonly CommentOption _Options;

        public CommentController(ILogger<CommentController> logger, ICommentStore store, IOptions<CommentOption> options)
        {
            _Logger = logger;
            _Store = store;
            _Options = options.Value;
        }

        public IActionResult Index()
        {
            int commentCount = _Options.MostRecent;
            // # newest comments
            IEnumerable<CommentViewModel> result = _Store.GetNewestComments(commentCount).Select(
                x => new CommentViewModel(x)).ToList();
            // sort -> View!
            return View(new CommentListViewModel()
                { 
                    Comments = result,
                    MostRecent = commentCount
                });
        }

        [HttpGet()]
        [ActionName("New")] //Zeigt dem MVC Framework, dass die Action "New" umgewandelt wird zu "NewComment"
        public IActionResult NewComment()
        {

            return View(new NewCommentViewModel() { UserName = "Jonas" });
        }

        [HttpPost()]
        [ActionName("New")] //Zeigt dem MVC Framework, dass die Action "New" umgewandelt wird zu "NewComment"
        [ValidateAntiForgeryToken()]
        public IActionResult NewComment([FromForm]NewCommentViewModel input /* oder [FromForm]string username, [FromForm]string message*/)
        {
            //ModelState
            //Parallel.For(0, 99, x =>
            // {
            //     //..
            //     username = x.ToString();
            //});
            // 1. Validate input
            // TODO: Validate with MVC methods...
            //if (!string.IsNullOrWhiteSpace(input.UserName) && !string.IsNullOrWhiteSpace(input.Message))
            if (ModelState.IsValid)
            {
                // 2. Create comment
                CommentItem newItem = _Store.CreateComment(input.UserName, input.Message);
                if (newItem != null)
                {
                    _Logger.LogInformation("New Comment {id} created.", newItem.Id);
                    // 3. Redirect
                    return RedirectToAction("Index"); //Innerhalb einer Aktion in der App umleiten
                }                                  //Redirect("https://") for URLs...
            }
            return View();
        }
    }
}
