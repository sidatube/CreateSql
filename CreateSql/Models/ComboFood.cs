using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreateSql.Models
{
    public class FoodInfo
    {
        public int FoodId { get; set; }
        public int qty { get; set; }
    }

    public class ComboInfo
    {
        public ComboFood ComboFood { get; set; }
        public int Qty { get; set; }
    }
    public class ComboFood
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public Image Image { get; set; }
        public decimal Price { get; set; }
        public List<ComboInfo> ComboInfo { get; set; }
        public int Amount { get; set; }
        public int BranchId { get; set; }
        public virtual Bracnh Bracnh { get; set; }
    }
}