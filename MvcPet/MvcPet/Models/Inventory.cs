using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcPet.Utilities;

namespace MvcPet.Models
{
    public class Inventory
    {
        public int ID { get; set; }
        public String Picture { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}