using FindAllMeth.Models;
using System;

namespace FindAllMeth
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFindMeth<string> names = new MyFindMeth<string>();

            names.Add("Mirsamir");
            names.Add("Elmir");
            names.Add("Semi");
            names.Add("Niyam");
            names.Add("Lazim");
            names.Add("Elmir");

            var result = names.FindAll(m => m == "Elmir");

            Console.WriteLine(result);
        }
    }
}
