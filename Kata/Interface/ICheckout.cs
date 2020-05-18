using System;
using System.Collections.Generic;
using System.Text;
using Kata.Models;

namespace Kata.Interface
{
    public interface ICheckout
    {
        void Scan(Item item);
        decimal Total(); 
    }
}
