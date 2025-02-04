using System;
using System.Collections.Generic;
class Array
{

    static void PrintList(List<int> list)
    {

        foreach (var i in list)
        {
            Console.Write(i + " ");
        }
        Console.Write("\n");
    }

    static void Main()
    {


        List<int> list = new List<int>() { 10, 20, 30 };

        Array.PrintList(list);
        list.Add(10);
        Array.PrintList(list);
        list.AddRange(new List<int>() { 30, 45, 67 });
        Array.PrintList(list);




    }

}