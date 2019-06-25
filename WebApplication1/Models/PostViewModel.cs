using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PostViewModel
    {
        public int id { get; set; }
        public string code { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string content { get; set; }
        public string author { get; set; }
        public Nullable<int> category_id { get; set; }
        public string image_link { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> deleted_at { get; set; }

        public string categoryName{ get; set; }
    }
}