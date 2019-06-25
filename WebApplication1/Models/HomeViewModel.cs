using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class HomeViewModel
    {
        public List<CategoryViewModel> ListCategory { get; set; }
        public List<PostViewModel> LatestPost{ get; set; }
        public List<PostViewModel> ViewPost { get; set; }
        public List<PostViewModel> NewPost { get; set; }
    }
}