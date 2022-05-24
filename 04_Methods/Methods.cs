using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04_Methods
{
    public class Methods
    {
        
        //int x = ExplainMethod(3); // variables must have the same datatype as the methods's return type
        public void ExplainMethod(int x)
        {
            //Method body
            Console.WriteLine("Public is the access modifier.");
            Console.WriteLine("Void is the return type");
            Console.WriteLine("ExplainMethod is the Name");
            Console.WriteLine("int x is ThreadExceptionEventArgs parameter");
            Console.WriteLine("Name + Params = Signature");
        }
    }

    public string FullName(string first, string last)
    {
        return $"{first} {last}";
    }
}