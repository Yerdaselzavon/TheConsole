using System;

class EntryPoint
{
    static void Main()
    {
        Console.Write("I am ");
        Console.Write("learning from the ");
        Console.Write("best C# course");
        //puts any key (console cursor) on same line
        Console.Write("I am testing new line in console.write\n");
        // \n puts new line work for both write and writeline
        //Below is menu challenge, 1 instance of console.write
        Console.Write("1. Add new item\n2. Edit an item\n3. Remove an item\n4. Exit\nYour choice:\n");
        //Both are the same functionally, but below is easier to read. Visual studio automatically concatinates the strings 
        //together when pressing the enter key within a single string
        Console.Write("1. Add new item" +
            "\n2. Edit an item" +
            "\n3. Remove an item" +
            "\n4. Exit" +
            "\nYour choice:\n");
    }
}