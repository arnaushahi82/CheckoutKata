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
        public void ScanMultipleItemsTest()
        {
            ICheckout checkout = new Checkout();
            checkout.Scan(new Item() { SKU = "A99", UnitPrice = 0.5m, Quantity = 1 });
            checkout.Scan(new Item() { SKU = "C40", UnitPrice = 0.6m, Quantity = 1 });
            checkout.Scan(new Item() { SKU = "A99", UnitPrice = 0.5m, Quantity = 1 });
            Assert.AreEqual(2, checkout.TotalItemsScanned());
            
        }

        [TestMethod()]
        public void TotalTest()
        {
            ICheckout checkout = new Checkout();
            checkout.Scan(new Item() { SKU = "A99", UnitPrice = 0.5m, Quantity = 2 });
            Assert.AreEqual(1.0m, checkout.Total());
        }

        [TestMethod()]
        public void TotalWithSpecialOfferTest()
        {
            ICheckout checkout = new Checkout();
            
            checkout.Scan(new Item(){SKU = "B15", Quantity = 2, UnitPrice = .3m, 
                Offer = new SpecialOffer(){Quantity = 2, OfferPrice = .45m}});
            Assert.AreEqual(0.45m, checkout.Total());
        }
    }
}