using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API_2.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
    }
}