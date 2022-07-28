using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseTheCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare the string
            string str = "Hello Alex";

            // declare an array which will store each char from declared string
            char[] str_to_array = str.ToCharArray();

            // using for loop and if statment reverse case
            for(int i = 0; i < str_to_array.Length; i++)
            {
                // if the char is upper then reverse to lower
                if(Char.IsUpper(str_to_array[i]) == true)
                {
                    str_to_array[i] = Char.ToLower(str_to_array[i]);
                }
                // else if the char is lower then reverse to upper
                else if(Char.IsLower(str_to_array[i]) == true)
                {
                    str_to_array[i] = Char.ToUpper(str_to_array[i]);
                }
            }

            // save reversed char to string
            str = new string(str_to_array);

            // print the reverse string
            Console.WriteLine(str);

            Console.ReadLine(); // click to close
        }
    }
}
