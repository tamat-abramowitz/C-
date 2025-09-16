
using Lesson2;
using System;
using System.Collections.Generic;


public class Program
{
    static void Main(string[] args)
    {
        List<Shelf> shelves = new List<Shelf>();
        shelves.Add(new Shelf
        {
            shelfNum = 1,
            colNum = 2,
            weightCapacity = 100,
            current = 0,
            oneItem = new Book
            {
                price = 40,
                barcode = 123456,
                name = "sidur",
                age = 5,
                wheight = 0.4
            }
        });
        shelves.Add(new Shelf
        {
            shelfNum = 2,
            colNum = 3,
            weightCapacity = 200,
            current = 100,
            oneItem = new Book
            {
                price = 45,
                barcode = 654321,
                name = "Learning C#",
                age = 16,
                wheight = 0.75
            }
        });
        shelves.Add(new Shelf
        {
            shelfNum = 3,
            colNum = 1,
            weightCapacity = 150,
            current = 50,
            oneItem = new Book
            {
                price = 20,
                barcode = 789012,
                name = "eazy java",
                age = 15,
                wheight = 1.2
            }
        });
        shelves.Add(new Shelf
        {
            shelfNum = 4,
            colNum = 4,
            weightCapacity = 200,
            current = 200,
            oneItem = new Toy
            {
                price = 30,
                barcode = 345678,
                name = "chumash",
                age = 4,
                wheight = 1.5
            }
        });

        Console.WriteLine("מדפים מלאים:");
        foreach (var shelf in shelves)
        {
            if (shelf.isFull())
                Console.WriteLine(shelf.oneItem.name);
        }


        Console.WriteLine("\nספרים לילדים:");
        foreach (var shelf in shelves)
        {
            if (shelf.oneItem.age < 10)
                Console.WriteLine(shelf.oneItem.name);
        }

        Console.WriteLine("\nספרים יקרים:");
        foreach (var shelf in shelves)
        {
            if (shelf.oneItem.price >= 100)
                Console.WriteLine(shelf.oneItem.name);
        }


        // כל המופעים של ספר מסוים
        string name1 = "sidur";
        Console.WriteLine($"\nכל המדפים עם {name1}:");
        foreach (var shelf in shelves)
        {
            if (shelf.oneItem.name == name1)
                Console.WriteLine(shelf.oneItem.name);
        }

        string name2 = "sidur";
        double bookWeight = 0.4;
        bool hasPlace = false;
        foreach (var shelf in shelves)
        {
            if (shelf.oneItem.name == name2 &&
                shelf.current + bookWeight <= shelf.weightCapacity)
            {
                hasPlace = true;
                break;
            }
        }
        Console.WriteLine($"\nיש מקום לספר {name2}? {hasPlace}");
    }
}


