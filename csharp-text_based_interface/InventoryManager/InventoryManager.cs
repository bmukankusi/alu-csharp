using System;
using InventoryLibrary;
using System.Text.Json;
using System.IO;

namespace InventoryManager
{
  public class JSONStorage
{
    private Dictionary<string, BaseClass> objects = new Dictionary<string, BaseClass>();
    private string filePath = "storage/inventory_manager.json";

    /// <summary>
    /// Retrieves all stored objects.
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
    /// </summary>
    public void Save()
    {
        Directory.CreateDirectory("storage");
        string jsonString = JsonSerializer.Serialize(objects);
        File.WriteAllText(filePath, jsonString);
    }

    /// <summary>
    /// Loads objects from a JSON file.
    /// </summary>
    public void Load()
    {
        if (File.Exists(filePath))
        {
            string jsonString = File.ReadAllText(filePath);
            objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(jsonString);
        }
    }
}
}

namespace InventoryManager
{
class Program
{
    static JSONStorage storage = new JSONStorage();
    static void Main()
    {
        storage.Load();
        while (true)
        {
            Console.WriteLine("\nInventory Manager\n-------------------------");
            Console.WriteLine("ClassNames | All | Create [ClassName] | Show [ClassName id] | Update [ClassName id] | Delete [ClassName id] | Exit");
            Console.Write("Command: ");
            string input = Console.ReadLine().Trim().ToLower();
            string[] args = input.Split(' ');
            if (args[0] == "exit") break;
            ProcessCommand(args);
        }
    }

    /// <summary>
    /// Processes user commands.
    /// </summary>
    static void ProcessCommand(string[] args)
    {
        switch (args[0])
        {
            case "classnames":
                Console.WriteLine("Item, User, Inventory");
                break;
            case "all":
                foreach (var obj in storage.All())
                    Console.WriteLine(obj.Key + " => " + JsonSerializer.Serialize(obj.Value));
                break;
            case "create":
                if (args.Length < 2) Console.WriteLine("Missing ClassName");
                else CreateObject(args[1]);
                break;
            case "show":
            case "update":
            case "delete":
                Console.WriteLine("Not implemented yet");
                break;
            default:
                Console.WriteLine("Invalid command");
                break;
        }
    }

    /// <summary>
    /// Creates a new object based on the specified class name.
    /// </summary>
    static void CreateObject(string className)
    {
        switch (className)
        {
            case "item":
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Name is required");
                    return;
                }
                Item newItem = new Item { name = name };
                storage.New(newItem);
                storage.Save();
                Console.WriteLine("Item created successfully");
                break;
            case "user":
                Console.Write("Enter name: ");
                name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Name is required");
                    return;
                }
                User newUser = new User { name = name };
                storage.New(newUser);
                storage.Save();
                Console.WriteLine("User created successfully");
                break;
            default:
                Console.WriteLine("Invalid object type");
                break;
        }
    }
}
}
