using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Interface
{
    interface ICheckout
    {
        void Scan(string item);
        decimal Total(); 
    }
}
