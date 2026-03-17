using System;
using System.Collections.Generic;

internal static class Program
{
    private static void Main()
    {
        List<string> list = new List<string>();

        string status1 = "1";
        string status2 = "2";
        string status3 = "3";

        List<string> info = new List<string>();
        list.Add(status1);
        list.Add(status2);
        list.Add(status3);

        if (list == null ||
            !list.Contains(status1) ||
            !list.Contains(status2) ||
            !list.Contains(status3))
        {
            Console.WriteLine("List is empty.");
        }
        else if (list.Contains(status3))
        {
            if (!list.Contains(status1) || !list.Contains(status2))
            {
                Console.WriteLine("List has only status3.");
            }
            Console.WriteLine("List has items.");
        }
        else
        {
            Console.WriteLine("List has no items.");
        }
    }
}
