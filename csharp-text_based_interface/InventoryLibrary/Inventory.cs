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

    public string user_id { get; set; }
    public string item_id { get; set; }
    public int quantity { get; set; } = 1;

    public Inventory() { }

    public Inventory(string userId, string itemId, int quantity)
    {
        this.user_id = userId;
        this.item_id = itemId;
        this.quantity = quantity >= 0 ? quantity : 1;
    }
}
}