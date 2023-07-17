using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LinqExercise19
{
    static void Main(string[] args)
    {

        List<string> listOfString = new List<string>();
        listOfString.Add("m");
        listOfString.Add("n");
        listOfString.Add("o");
        listOfString.Add("p");
        listOfString.Add("q");


        
        var _result1 = from x in listOfString
                       select x;
        Console.Write("Here is the list of items : \n");
        foreach (var tchar in _result1)
        {
            Console.WriteLine("Char: {0} ", tchar);
        }

        listOfString.RemoveAll(en => en == "q");


        var _result = from y in listOfString
                      select y;
        Console.Write("\nHere is the list after removing item 'q' from the list : \n");
        foreach (var rChar in _result)
        {
            Console.WriteLine("Char: {0} ", rChar);
        }

       
    }
}
