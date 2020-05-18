using System;
using System.Collections.Generic;
using System.Text;
using Kata.Models;

namespace Kata.Interface
{
    interface IDiscountCalculator
    {
        decimal CalculateDiscountedPrice(Item item);
    }
}
