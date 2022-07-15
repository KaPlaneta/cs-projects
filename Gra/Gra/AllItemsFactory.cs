using System;
using System.Collections.Generic;


namespace Gra
{
    [Serializable]
    class AllItemsFactory : ItemFactory
    {
       
        public Item CreateItem()
        {
            List<Item> allItems = new List<Item>()
            {
                new BasicAxe(),
                new BasicMachete(),
                new MagicArmor()
            };
            return allItems[Index.RNG(0, allItems.Count)];
        }
        public Item CreateNonMagicItem()
        {
            
            List<Item> allItems = new List<Item>()
            {
                new BasicMachete(),
                new BasicAxe()
                
            };
            return allItems[Index.RNG(0, allItems.Count)];
        }
        public Item CreateNonWeaponItem()
        {
           
            List<Item> allItems = new List<Item>()
            {
                new MagicArmor(),
                
                
            };
            return allItems[Index.RNG(0, allItems.Count)];
        }
    }
}
