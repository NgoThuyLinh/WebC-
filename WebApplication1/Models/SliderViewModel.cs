using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class SliderViewModel
    {
        public int id { get; set; }
        public Nullable<int> post_id { get; set; }

        public string postTitle { get; set; }
        public string postImages{ get; set; }
    }
}