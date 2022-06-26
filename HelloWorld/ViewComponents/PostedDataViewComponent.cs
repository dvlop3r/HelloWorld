using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;

namespace HelloWorld.ViewComponents
{

    public class PostedDataViewComponent : ViewComponent
    {
        PostContext postContext;
        public PostedDataViewComponent(PostContext postContext)
        {
            this.postContext = postContext;
        }
        public IViewComponentResult Invoke()
        {
            IEnumerable<Post> posts = postContext.Posts.ToArray();
            return View(posts);
        }
    }
}
