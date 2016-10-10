using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularAPI.Models
{
    public class ProductModels
    {
        public int reviews { get; set; }
        public int id { get; set; }
        public ImageModel image { get; set; }
        public bool canPurchase { get; set; }
        public string description { get; set; }
        public string images { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public bool soldOut { get; set; }
    }
}