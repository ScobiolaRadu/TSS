using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TSS;

namespace TSSTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TotalOfEmptyCart()
        {
            Cart cart = new Cart(new List<Item>());
            Assert.AreEqual(0.0, cart.Total);
        }

        [TestMethod]
        public void TotalOfCartOneItem()
        {
            Cart cart = new Cart(new List<Item> { new Item(1, 299.99) });
            Assert.AreEqual(299.99, cart.Total);
        }

        [TestMethod]
        public void TotalOfCartMultipleItems()
        {
            Cart cart = new Cart(new List<Item> { new Item(1, 299.99), new Item(1, 99.99), new Item(1, 9.99) });
            Assert.AreEqual(409.97, cart.Total);
        }

        [TestMethod]
        public void TotalOfCartMultipleQuantities()
        {
            Cart cart = new Cart(new List<Item> { new Item(2, 100.0) , new Item(1, 10.0), new Item(7, 50.0)});
            Assert.AreEqual(560.0, cart.Total);
        }

        [TestMethod]
        public void CheckUserCredentials()
        {
            Client client = new Client("test@gmail.com", "secret");
            Assert.AreEqual("test@gmail.com" + "secret", client.Credentials(client));
        }

    }
}
