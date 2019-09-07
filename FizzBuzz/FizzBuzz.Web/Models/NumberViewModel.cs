namespace FizzBuzz.Web.Models
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using PagedList;

    public class NumberViewModel
    {
        [Range(1, 1000)]
        [Required]
        [DisplayName("Value")]
        public int UserNumber { get; set; }

        public IPagedList<String> RuleBasedOutputLists { get; set; }
    }
}