using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcPet.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateRecieved { get; set; }

        public int Quantity { get; set; }

        [Range(1, 1000000)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public string Picture { get; set; }
    }

    public class PetDBContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
    }
}