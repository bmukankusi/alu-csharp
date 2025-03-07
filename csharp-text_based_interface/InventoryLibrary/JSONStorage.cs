using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    /// <summary>
    /// Handles storing and retrieving inventory data as JSON.
    /// </summary>
    public class JSONStorage
    {
        private Dictionary<string, BaseClass> objects = new Dictionary<string, BaseClass>();
        private string filePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, 
            "InventoryLibrary", 
            "storage", 
            "inventory_manager.json"
        );

        /// <summary>
        /// Retrieves all stored objects, indexed by their ID.
        /// </summary>
        public Dictionary<string, BaseClass> All() => objects;

        /// <summary>
        /// Adds a new object to storage.
        /// </summary>
        public void New(BaseClass obj)
        {
            string key = obj.GetType().Name + "." + obj.id;
            objects[key] = obj;
        }

        /// <summary>
        /// Saves objects to a JSON file.
        /// Creates the file and directory if they do not exist.
        /// </summary>
        public void Save()
{
    string? directoryPath = Path.GetDirectoryName(filePath);
    
    if (!Directory.Exists(directoryPath))
    {
        if (directoryPath != null)
        {
            Directory.CreateDirectory(directoryPath);
        }
    }

    string jsonString = JsonSerializer.Serialize(objects);
    File.WriteAllText(filePath, jsonString);
}


        /// <summary>
        /// Loads objects from a JSON file, if it exists.
        /// </summary>
        public void Load()
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(jsonString) ?? new Dictionary<string, BaseClass>();
            }
        }
    }
}

