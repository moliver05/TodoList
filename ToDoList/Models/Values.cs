using System.Collections.Generic;
using System;
namespace ToDoList.Models
{
  public class Values
  {
    private string _description;
    private static List<Item> _instances = new List<Item> {};

    public Item (string description)
    {
      _description = description;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
    public static List<Item> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
  public class Program
  {
    public static void Main ()
    {
      Console.WriteLine("Would You like to add an item to your list or view your list? (Add/View)");
      string response = Console.ReadLine().ToLower();

      if (response == "add")
      {
        Console.WriteLine ("Please Add To Do:");
        string wordEntered = Console.ReadLine();
        Item newItem = new Item(wordEntered);
        newItem.Save();

        Console.WriteLine (wordEntered +  " has been added to your list.");
        Main();
      }
      else if (response == "view")
      {
        List<Item> instances = Item.GetAll();
        for (int i = 0; i < instances.Count; i++)
        {
          string instanceDescription = instances[i].GetDescription();
          Console.WriteLine((i + 1) + ". " + instanceDescription);
        }
        Main();
      }
      else
      {
        Console.WriteLine("Would you like to quit the program? Type 'yes' to quit, otherwise hit enter to continue.");
        if (Console.ReadLine() != "yes")
        {
          Main();
        }
      }
    }
  }
}
