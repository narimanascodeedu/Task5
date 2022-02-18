using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Phone
{
    internal class Methods
    {
        public static string ReadString(string msg)
        {
            Console.Write(msg);
            Console.ForegroundColor = ConsoleColor.Green;
            string aStr = Console.ReadLine();
            Console.ForegroundColor= ConsoleColor.White;
            return aStr;
        }
        public static int ReadInteger(string msg)
        {

            l1:
            Console.Write(msg);
            Console.ForegroundColor = ConsoleColor.Green;
            string aStr = Console.ReadLine();
            Console.ForegroundColor= ConsoleColor.White;
            int num;
            try
            {
                num = Convert.ToInt32(aStr);
            }
            catch 
            {
                Methods.PrintError("Yeniden daxil edin: ");
                goto l1;
            }
            return num;
        }

        public static void PrintError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
