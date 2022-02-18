using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Phone
{
    internal class Mobile
    {
        public int id;
        public string name;
        public double price;
        public string operatingSystem;
        public int productionYear;

        static int counter = 0;
        public Mobile()
        {
            counter++;
            id = counter;
        }
        public override string ToString()
        {
            return $"No: {id}\n" +
                $"Name: {name}\n" +
                $"Price: {price}\n" +
                $"Operating System: {operatingSystem}\n" +
                $"Production Year: {productionYear}";
        }
    }

}
