using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp4
{
    class Operations
    {
      
        Data MyData = new Data();     
        public void  Payroll()
        {
            
            try
            {
                Console.WriteLine("Insert the number document");
                MyData.setNumberDocument(double.Parse(Console.ReadLine()));
                Console.WriteLine("Insert the Firts Name");
                MyData.setFirtsName(Console.ReadLine());
                Console.WriteLine("Insert the Last Name");
                MyData.setLastName(Console.ReadLine());
                Console.WriteLine("Insert the Basic Salary");
                MyData.setBasicSalary(double.Parse(Console.ReadLine()));
                Console.WriteLine("Insert the Worked Days ");
                MyData.setWorkedDays(double.Parse(Console.ReadLine()));
            }
            catch (Exception a)
            {
                Console.WriteLine("incorrect typing" + a.Message);
            }
            //OPERATIONS
            //Total Salary
            MyData.setTotalSalary(MyData.getBasicSalary() / 30 * (MyData.getWorkedDays()));
            //Pay transport 
            MyData.setPayTransport(117172 / 30 * (MyData.getWorkedDays()));
            // Total Salary
            if (MyData.getBasicSalary() < 2000000)
            {
                MyData.setTotalSalary(MyData.getTotalSalary() + MyData.getPayTransport());
            }
            else
            {
                MyData.setTotalSalary(MyData.getTotalSalary());
            }
            //Retereiment
            MyData.setRetereiment(MyData.getTotalSalary() * 0.04);
            //Health
            MyData.setHealth(MyData.getTotalSalary() * 0.04);

        }

        public void  ShowInformation()

        {
            

            Console.WriteLine("\nNumber Doucment: " + MyData.getNumberDocument());
            Console.WriteLine("Firts Name: " + MyData.getFirtsName());
            Console.WriteLine("Last Name: " + MyData.getLastName());
            Console.WriteLine("Basic Salary: " + MyData.getBasicSalary());
            Console.WriteLine("Worked Days: " + MyData.getWorkedDays());
            Console.WriteLine("Health: " + MyData.getHealth());
            Console.WriteLine("Retereiment: " + MyData.getRetereiment());
            Console.WriteLine("Transport: " + MyData.getPayTransport());
            Console.WriteLine("Total Salary: " + MyData.getTotalSalary());
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
        }

        public void SaveInformation(List<Operations> operationss)

        {
            string FileName = " Archivo.txt";
            try
            {
                string json = JsonConvert.SerializeObject(operationss);
                File.WriteAllText(FileName, json);
                Console.WriteLine("The data was saved");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro " + ex);
            }
            finally
            {
                Console.WriteLine("Reiniciando Proceso");
            }
        }

        

    }
}
