using System;
using System.Collections.Generic;
using System.Text;
using Kata.Interface;
using Kata.Models;

namespace Kata.Implementation
{
    public class DiscountCalculator : IDiscountCalculator
    {
        public decimal CalculateDiscountedPrice(Item item)
        {
            try
            {
                if (item.Offer == null)
                {
                    return (item.UnitPrice * item.Quantity);
                }
                else
                {
                    var multipler = 0;
                    var remainder = item.Quantity % item.Offer.Quantity;
                    if (remainder != 0)
                        multipler = (item.Quantity - remainder) / item.Offer.Quantity;

                    return remainder == 0
                        ? item.Offer.OfferPrice
                        : (item.UnitPrice * remainder) + (multipler * item.Offer.OfferPrice);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0m;
            }
        }
    }
}
