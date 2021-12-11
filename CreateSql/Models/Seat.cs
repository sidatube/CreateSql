using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateSql.Models
{
    public class Seat
    {
        public string id { get; set; }
        public string Column { get; set; }
        public string Row { get; set; }
        public string Name { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }

    }
}