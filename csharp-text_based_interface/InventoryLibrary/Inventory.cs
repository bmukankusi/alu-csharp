using System;
using System.Collections.Generic;


namespace InventoryLibrary

{
    /// <summary>
    /// Represents an inventory entry and the quantity of items in the inventory.
    /// </summary>
    public class Inventory : BaseClass
    {
        /// <summary>
        /// ID of the user who owns the inventory entry.
        /// User ID can be used to retrieve user information, and to track user inventory.
        /// </summary>
        public string user_id { get; set; } = string.Empty;

        /// <summary>
        /// ID of the item in the inventory entry.
        /// </summary>
        public string item_id { get; set; } = string.Empty;

        /// <summary>
        /// Item quantity in the inventory entry.
        /// </summary> 

        public int quantity { get; set; } = 1;


        /// <summary>
        /// Default constructor, initializes the inventory entry with default values.
        /// </summary>

        public Inventory() { }

        public Inventory(string userId, string itemId, int quantity)
        {
            this.user_id = userId;
            this.item_id = itemId;
            this.quantity = quantity >= 0 ? quantity : 1;
        }
    }
}