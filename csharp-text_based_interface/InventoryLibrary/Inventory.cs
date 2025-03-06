namespace InventoryLibrary
{
    /// <summary>
    /// Represents an inventory entry.
    /// </summary>
    public class Inventory : BaseClass
    {
        /// <summary>
        /// ID of the user who owns the inventory entry.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// ID of the item in inventory.
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// Quantity of the item, must be at least 0.
        /// </summary>
        private int quantity;
        public int Quantity
        {
            get => quantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantity cannot be less than 0.");
                quantity = value;
            }
        }

        /// <summary>
        /// Constructor initializes the inventory with required user and item IDs.
        /// </summary>
        public Inventory(string userId, string itemId, int quantity = 1)
        {
            UserId = userId;
            ItemId = itemId;
            Quantity = quantity;
        }
    }
}
