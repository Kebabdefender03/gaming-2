using System;

namespace Gaming_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv ditt namn");

            String name = Console.ReadLine();


            if (name == "lebron james" || name == "michael jordan")
            {
                Console.WriteLine("Välkommen, wakanda forever!");
            }



            // if (name != "micke")
            //    Console.WriteLine(" lost, ya bum");
            //}
            else
            {
                Console.WriteLine("yu are lmao");
            }


            Console.ReadLine();

            Jump();

            Console.ReadLine();
        }

        static void Jump()
        {
            Console.WriteLine("it's large like ur lmao");

            Jump();
        }
    }

}
