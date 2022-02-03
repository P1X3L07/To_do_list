using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_list
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            int status = 0;
            while (again == true)
            {
                Console.WriteLine("1. My scroll list");
                Console.WriteLine("2. Add scroll");
                Console.WriteLine("Choose what to do ");
                int choose = Convert.ToInt32(Console.ReadLine());

                List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };

                if (choose == 1)
                {
                    Console.WriteLine("Scroll to learn list: ");
                    for (int i = 0; i < scrolls.Count; i++)
                    {
                        Console.WriteLine($"Scroll {i + 1} : {scrolls[i]}");
                    }
                    foreach(string name in scrolls)
                    {
                        Console.WriteLine($"Scroll {name}");
                    }
                }
                else if (choose == 2)
                {
                    Console.Write("How many scrolls to add : ");
                    int add = Convert.ToInt32(Console.ReadLine());

                    Console.Write("In what queue number? ");
                    int queue = Convert.ToInt32(Console.ReadLine());

                    string[] name = new string[add];
                    for(int i = 0; i < add; i++)
                    {
                        Console.Write($"Scroll name {i+1} : ");
                        name[i] = Console.ReadLine();
                    }
                    scrolls.InsertRange(queue, name);
                    status = 0;
                }
                Console.ReadLine();
            }
        }
    }
}
