using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            var products = new List<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes", "Wrestling Shoes", "Soccer Ball", "Football", "Shoulder Pads", 
                "Trail Running Shoes", "Cycling Shoes", "Kayak", "Kayak Paddles"};

            Console.WriteLine();

            var kayakProducts = products.Where(x => x.Contains("Kayak")).ToList();

            Console.WriteLine();

            foreach (var item in kayakProducts)
            {
                Console.Write(item + ", \n");
            }

            Console.WriteLine();

            var shoeProducts = products.Where(x => x.Contains("Shoes")).ToList();

            foreach (var item in shoeProducts)
            {
                Console.Write(item + ", ");

            }
            Console.WriteLine();

            var ballProducts = products.Where(x => x.Contains("ball")).ToList();
            for (int i = 0; i < ballProducts.Count; i++)
            {
                Console.Write(ballProducts[i] + ", ");
                Console.WriteLine();
            }

            Console.WriteLine();

            foreach (var item in ballProducts)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();

            foreach (var item in ballProducts.OrderBy(x => x))
            {
                Console.Write(item + ", ");
            }

            products.Add("RAM");
            products.Add("motherboard");
            products.Add("solid state hard drive");
            products.Add("graphics card");
            products.Add("ATX case");
            products.Add("monitor");

            Console.WriteLine(products.OrderByDescending(x => x.Length).First());
            Console.WriteLine();
            Console.WriteLine(products.OrderBy(x => x.Length).First());
            Console.WriteLine();
            Console.WriteLine(products.OrderBy(x => x.Length).Skip(3).Take(1).First());
            Console.WriteLine();
            Console.WriteLine(ballProducts.OrderByDescending(x => x.Length).Skip(1).Take(1).First());
            Console.WriteLine();

            var reversedProducts = products.OrderByDescending(x => x.Length).ToList();
            foreach (var item in reversedProducts)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();

            foreach (var item in products.OrderByDescending(x => x.Length))
            {
                Console.Write(item + ", ");
            }


            Console.ReadKey();
        }
    }
}
