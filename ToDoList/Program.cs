using System;
using System.Collections.Generic;
using ToDoList.Models;

public class Program
{
   public static string response = "";
  public static void Main()
  {
    Console.WriteLine("Welcome to the To Do List.");
    GreetUser();
    List<Item> newList = new List<Item> {};
    AskUser();


  }
  public static void GreetUser()
  {
    Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View/Exit)");
    response = Console.ReadLine();
    AskUser();
  }
  public static void AskUser()
  {
  if(response == "Add")
    {
      Console.WriteLine("Please, enter the description for the new item");
      string addItem = Console.ReadLine();
      Item newItem = new Item(addItem);
      Console.WriteLine($"{addItem} has been added to your list. Would you like to add an item to your list or view your list? (Add/View/Exit)");
      
      GreetUser();
    }
    else if (response == "View")
    {
      List<Item> result = Item.GetAll();
      foreach (Item thisItem in result)
      {
        Console.WriteLine(thisItem.Description);
      }
      GreetUser();
    }
    else if (response == "Exit")
    {
      Console.WriteLine("BYE.");
      response = "";
    }
  }
}