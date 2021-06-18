using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVCSample.Controllers
{

    public abstract class BaseController : Controller
    {
        public override ViewResult View(string viewName, object model)
        {
            //if (ViewData != null)
            //{
            //    var store = this.HttpContext.RequestServices.GetService<CommentStorage.ICommentStore>();
            //    ViewData["CommentCount"] = store.GetNumberOfComments(); 
            //}
            return base.View(viewName, model);
        }
    }
}
