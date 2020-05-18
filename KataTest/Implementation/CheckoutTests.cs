using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kata.Interface;
using Kata.Models;

namespace Kata.Implementation.Tests
{
    [TestClass()]
    public class CheckoutTests
    {
        [TestMethod()]
        public void ScanTest()
        {
            ICheckout checkout = new Checkout();
            checkout.Scan(new Item() { SKU = "A99", UnitPrice = 0.5m, Quantity = 1 });
            Assert.AreEqual(0.5m, checkout.Total());
        }

        [TestMethod()]
        public void TotalTest()
        {
            ICheckout checkout = new Checkout();
            checkout.Scan(new Item() { SKU = "A99", UnitPrice = 0.5m, Quantity = 2 });
            Assert.AreEqual(1.0m, checkout.Total());
        }
    }
}