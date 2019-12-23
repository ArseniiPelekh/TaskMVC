using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskMVC.ViewModels
{
    public class BookViewModel
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int PageNumber { get; set; }
    }
}