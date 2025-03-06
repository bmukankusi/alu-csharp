using NUnit.Framework;
using InventoryLibrary;
using System.Collections.Generic;

namespace InventoryTests
{
    [TestFixture]
    public class InventoryTests
    {
        [Test]
        public void Test_Inventory_Creation()
        {
            Inventory inventory = new Inventory("User123", "Item456", 5);
            Assert.That(inventory.user_id, Is.EqualTo("User123"));
            Assert.That(inventory.item_id, Is.EqualTo("Item456"));
            Assert.That(inventory.quantity, Is.EqualTo(5));
        }

        [Test]
        public void Test_Inventory_Default_Quantity()
        {
            Inventory inventory = new Inventory("User789", "Item999", -1);
            Assert.That(inventory.quantity, Is.EqualTo(1)); // Ensures quantity cannot be negative
        }
    }
}
