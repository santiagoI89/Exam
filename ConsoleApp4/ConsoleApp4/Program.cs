using System;
using System.IO;
namespace ConsoleApp4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Operations MyOperations = new Operations();
            List<Operations> operationss = new List<Operations>();

            Console.WriteLine("Select one option: ");
            Console.WriteLine("1. If you want add a person");
            Console.WriteLine("2. If you want exit the program");
            string option = (Console.ReadLine());
            int option2 = 1;
            switch (option)
            {
                case "1":
                    {
                        do
                        {
                            MyOperations.Payroll();
                            MyOperations.ShowInformation();
                            MyOperations.SaveInformation(operationss);
                            Console.WriteLine("\nDo you want add another person?");
                            Console.WriteLine("1. add person");
                            Console.WriteLine("2. Exit to the program");
                            option2 = int.Parse(Console.ReadLine());
                        } while (option2 != 2);
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You are exiting to the program");
                        break;
                    }
            }
        }


    }

}