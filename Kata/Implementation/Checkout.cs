using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kata.Interface;
using Kata.Models;

namespace Kata.Implementation
{
    public class Checkout : ICheckout
    {
        private List<Item> Items { get; set; }

        public Checkout()
        {
            Items = new List<Item>();
        }
        public void Scan(Item item)
        {
            try
            {
                var existingItem = Items.FirstOrDefault(i => i.SKU == item.SKU);

                if (existingItem != null)
                {
                    existingItem.Quantity++;
                }
                else
                {
                    Items.Add(item);
                }

            }
            catch (Exception e)
            {
                //log the error
                Console.WriteLine(e);
            }
        }

        public decimal Total()
        {
           return Items.Sum(x => x.UnitPrice * x.Quantity);
        }
    }
}
