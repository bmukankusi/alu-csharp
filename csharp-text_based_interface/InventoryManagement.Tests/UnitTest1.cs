using NUnit.Framework;
using InventoryLibrary;
using System.Collections.Generic;

namespace InventoryManagement.Tests
{
    [TestFixture]
    public class ItemTests
    {
        [Test]
        public void Test_Item_Creation()
        {
            Item item = new Item { name = "Laptop", price = 999.99f, tags = new List<string> { "Electronics" } };
            Assert.That(item.name, Is.EqualTo("Laptop"));
            Assert.That(item.price, Is.EqualTo(999.99f));
            Assert.That(item.tags.Contains("Electronics")); // Change this line
        }

        [Test]
        public void Test_Item_Default_Values()
        {
            Item item = new Item { name = "Phone" };
            Assert.That(item.description, Is.EqualTo(""));
            Assert.That(item.price, Is.EqualTo(0.00f));
            Assert.That(item.tags, Is.Empty); // Fix this line
        }
    }

    [TestFixture]
    public class UserTests
    {
        [Test]
        public void Test_User_Creation()
        {
            User user = new User { name = "John Doe" };
            Assert.That(user.name, Is.EqualTo("John Doe"));
        }
    }

    [TestFixture]
    public class InventoryTests
    {
        [Test]
        public void Test_Inventory_Creation()
        {
            Inventory inventory = new Inventory { user_id = "User123", item_id = "Item456", quantity = 5 };
            Assert.That(inventory.user_id, Is.EqualTo("User123"));
            Assert.That(inventory.item_id, Is.EqualTo("Item456"));
            Assert.That(inventory.quantity, Is.EqualTo(5));
        }

        [Test]
        public void Test_Inventory_Default_Quantity()
        {
            Inventory inventory = new Inventory { user_id = "User789", item_id = "Item999" };
            Assert.That(inventory.quantity, Is.EqualTo(1)); // Ensures default quantity is 1
        }
    }
}
