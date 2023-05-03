using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TSS;

namespace TSSTests
{
    [TestClass]
    public class UnitTest1
    {
        private int quantity;
        private double price;

        [TestMethod]
        public void TotalOfEmptyCart()
        {
            Cart cart = new Cart(new List<Item>());
            Assert.AreEqual(0.0, cart.Total);
        }

        [TestMethod]
        public void TotalOfCartOneItem()
        {
            Cart cart = new Cart(new List<Item> { new Item(quantity = 1, price = 299.99) });
            Assert.AreEqual(299.99, cart.Total);
        }

        [TestMethod]
        public void TotalOfCartMultipleItems()
        {
            Cart cart = new Cart(new List<Item> { new Item(quantity = 1, price = 299.99), new Item(quantity = 1, price = 99.99), new Item(quantity = 1, price = 9.99) });
            Assert.AreEqual(409.97, cart.Total);
        }

        [TestMethod]
        public void TotalOfCartMultipleQuantities()
        {
            Cart cart = new Cart(new List<Item> { new Item(quantity = 2, price = 100.0) , new Item(quantity = 1, price = 10.0), new Item(quantity = 7, price = 50.0)});
            Assert.AreEqual(560.0, cart.Total);
        }

    }
}
