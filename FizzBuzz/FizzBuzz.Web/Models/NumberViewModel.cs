using PagedList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FizzBuzz.Web.Models
{
    public class NumberViewModel
    {
        [Range(1, 1000)]
        [Required]
        [DisplayName("Value")]
        public int UserNumber { get; set; }
        public IPagedList<String> Numbers { get; set; }
    }
}