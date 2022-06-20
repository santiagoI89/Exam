using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class Data
    {
        private double NumberDocument;
        private string FirtsName;
        private string LastName;
        private double BasicSalary;
        private double WorkedDays;
        private double Health;
        private double Retereiment;
        private double PayTransport;
        private double TotalSalary;
        

        public Data() { }
        
        

        public void setNumberDocument(double NumberDocument1)
        {
            NumberDocument = NumberDocument1;
        }

        public string getNumberDocument()
        {
            return ""+NumberDocument;
        }
        //1
        public void setFirtsName(string FirtsName1)
        {
            FirtsName = FirtsName1;
        }
        public string getFirtsName()
        {
            return FirtsName;
        }
        //2
        public void setLastName(string LastName1)
        {
            LastName = LastName1;
        }
        public string getLastName()
        {
            return LastName;
        }
        //3
        public void setBasicSalary(double BasicSalary1)
        {
            BasicSalary = BasicSalary1;
        }
        public double getBasicSalary()
        {
            return BasicSalary;
        }
        //4
        public void setWorkedDays(double WorkedDays1)
        {
            WorkedDays = WorkedDays1;
        }
        public double getWorkedDays()
        {
            return WorkedDays;
        }
        //5
        public void setHealth(double Health1)
        {
            Health = Health1;
        }
        public double getHealth()
        {
            return Health;
        }
        //6
        public void setRetereiment(double Retereiment1)
        {
            Retereiment = Retereiment1;
        }
        public double getRetereiment()
        {
            return Retereiment;
        }
        //7
        public void setPayTransport(double PayTransport1)
        {
            PayTransport = PayTransport1;
        }
        public double getPayTransport()
        {
            return PayTransport;
        }
        //8
        public void setTotalSalary(double TotalSalary1)
        {
            TotalSalary = TotalSalary1;
        }
        public double getTotalSalary()
        {
            return TotalSalary;
        }
    }
}