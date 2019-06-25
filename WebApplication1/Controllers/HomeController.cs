using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            tintucEntities db = new tintucEntities();
            List<category> categories = db.categories.ToList();
            List<CategoryViewModel> categoryList = categories.Select(x => new CategoryViewModel { id = x.id, name = x.name, description = x.description }).ToList();

            List<post> post = db.posts.ToList();
            List<PostViewModel> postList = post.Select(x => new PostViewModel
            {
                code = x.code,
                title = x.title,
                content = x.content,
                description = x.description,
                author = x.author,
                category_id = x.category_id,
                categoryName = x.category.name,
                image_link = x.image_link,
                created_at = x.created_at
            }).ToList();
            HomeViewModel resultdata = new HomeViewModel();
            resultdata.LatestPost = postList;
            resultdata.ListCategory = categoryList;
            return View(resultdata);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}