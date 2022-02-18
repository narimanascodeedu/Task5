using System;

namespace ConsoleApp.Phone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            l1:
            num = Methods.ReadInteger("Nece Telefon: ");
            if (num <= 0)
            {
                Methods.PrintError("Yeniden daxil edin");
                goto l1;
            }

            Mobile[] mobiles = new Mobile[num];
            for (int i = 0; i < mobiles.Length; i++)
            {
                Mobile mobile = new Mobile();
                mobile.name = Methods.ReadString($"{i + 1}-Telefonun adi: ");
                l2:
                mobile.price = Methods.ReadInteger($"{i + 1}-Telefonun qiymeti: ");
                if (mobile.price < 0)
                {
                    Methods.PrintError("Yeniden daxil edin");
                    goto l2;
                }
                mobile.operatingSystem = Methods.ReadString($"{i + 1}-Telefonun emeliyyat sistemi: ");
                l3:
                mobile.productionYear = Methods.ReadInteger($"{i + 1}-Telefonun istehsal ili: ");
                if (mobile.productionYear <= 2010)
                {
                    Methods.PrintError("istehsal ili 2010-dan yuxari olmalidir!");
                    goto l3;
                }
                mobiles[i] = mobile;
                Console.WriteLine("-----------------------------------------------");
            }
            Console.WriteLine("################## List of Mobiles #####################");
            foreach (var item in mobiles)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(item);
                Console.WriteLine("**********************");
            }
            




        }
    }
}
