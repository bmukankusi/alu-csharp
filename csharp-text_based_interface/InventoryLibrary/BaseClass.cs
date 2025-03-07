using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    /// <summary>
    /// Base class for all inventory objects.
    /// </summary>
    public class BaseClass
    {
        public string id { get; set; }

        /// <summary>
        /// Date and time the object was created.
        /// </summary>
        public DateTime date_created { get; set; }
        public DateTime date_updated { get; set; }

        /// <summary>
        /// Default constructor, initializes the object with default values.
        /// </summary>

        public BaseClass()
        {
            id = Guid.NewGuid().ToString();
            date_created = DateTime.UtcNow;
            date_updated = DateTime.UtcNow;
        }
    }
}