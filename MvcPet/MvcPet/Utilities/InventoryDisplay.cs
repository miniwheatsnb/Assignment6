using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcPet.Models;

namespace MvcPet.Utilities
{
    public class InventoryDisplay
    {
        List<Pet> petList = new List<Pet>();
        List<Inventory> inventoryList = new List<Inventory>();
        private PetDBContext db = new PetDBContext();

        public List<Inventory> GetPetList()
        {
            petList = db.Pets.ToList();

            foreach (var pet in petList)
            {
                inventoryList.Add(new Inventory
                {
                    ID = pet.ID,
                    Description = DescriptionModifier(pet.Description),
                    Name = pet.Name,
                    Picture = pet.Picture,

                    
                });
            }

            return inventoryList;
        }
        public List<Inventory> GetInventoryForDetails()
        {
            petList = db.Pets.ToList();

            foreach (var pet in petList)
            {
                inventoryList.Add(new Inventory
                {
                    ID = pet.ID,
                    Description = pet.Description,
                    Name = pet.Name,
                    Picture = pet.Picture,
                });
            }

            return inventoryList;
        }
        public Inventory GetInventoryItem(int? id)
        {
            inventoryList = GetInventoryForDetails();
            Inventory inv = new Inventory();

            inv = inventoryList.Find(x=>x.ID == id);
            return inv;
        }

        public string DescriptionModifier(string origDesc)
        {
            string modifiedDesc;

            modifiedDesc = origDesc.Substring(0, 35) + "...";

            return modifiedDesc;
        }
    }
}