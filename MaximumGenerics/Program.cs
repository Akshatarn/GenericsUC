using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic Use Case's ");
            FindMax.FindMaxValue(20, 30, 40);                   
            FindMax.FindMaxValue(20.20f, 30.20f, 40.40f);      
            FindMax.FindMaxValue("abc", "def", "ghi");       
        }
    }
}
