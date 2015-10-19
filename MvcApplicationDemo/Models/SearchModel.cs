using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplicationDemo.Models
{
    public class SearchModel
    {
        [RegularExpression(@"^[0-9a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Please enter valid input")]
        public string SearchTerm { get; set; }
    }
}