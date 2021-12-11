using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateSql.Models
{
    public class Room
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int BranchId { get; set; }
        public virtual Bracnh Bracnh { set; get; }

    }
}