using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;

namespace HelloWorld.controller
{
    public class PostController : Controller
    {
        PostContext postContext;
        public PostController(PostContext postContext)
        {
            this.postContext = postContext;
        }
        public IActionResult index()
        {
            ViewModel viewModel = new ViewModel();
            viewModel.Posts = postContext.Posts.ToArray();
            return View(viewModel);
        }
    }
}