using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateSql.Models
{
    public class Crew
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Image Image { get; set; }
        public string Role { get; set; }

    }
}