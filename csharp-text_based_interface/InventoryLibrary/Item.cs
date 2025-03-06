using System.Collections.Generic;

namespace InventoryLibrary
     {
     /// <summary>
    /// Represents an item in the inventory.
    /// </summary>
    public class Item : BaseClass
    {
        public required string name { get; set; }
        public string description { get; set; } = "";
        public float price { get; set; } = 0.00f;
        public List<string> tags { get; set; } = new List<string>();
    }
}