using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public String LastName { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
    }
}
