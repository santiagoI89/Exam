namespace evaluacion
{
    class program
    {      
        public static void Main(string[] args)
        {
            Operations MyOperations = new Operations();
            Console.WriteLine("Welcome to the payroll program");
            Console.WriteLine("Select one option");
            Console.WriteLine("1. If you want add a person");
            Console.WriteLine("2. exit to the program");
            int option1 = 1;
            string option = Console.ReadLine();
            switch(option)
            {
                case "1":
                    {
                        do
                        {
                            MyOperations.Payroll();
                            MyOperations.ShowInformation();
                            Console.WriteLine("\nDo you want add another person?");
                            Console.WriteLine("1. Add person");
                            Console.WriteLine("2. Exit to the program");
                            option = Console.ReadLine();
                        } while (option1 != 2);
                        break;
                    }
                    case "2":
                    {
                        Console.WriteLine("You are exiting to the program");
                        break ;
                    }
            }
        }
    }
    class Operations
    {
        Data MyData = new Data();
        public void Payroll()
        {
            try
            {
                Console.WriteLine("\nEnter the number document:");
                MyData.NumberDocument1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the firts name:");
                MyData.FirtsNmae1 = Console.ReadLine();
                Console.WriteLine("Enter the last name:");
                MyData.LastName1 = (Console.ReadLine());
                Console.WriteLine("Enter the basic salary:");
                MyData.BasicSalary1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the worked days:");
                MyData.WorkedDays1 = double.Parse(Console.ReadLine());
            }
            catch (Exception a)
            {
                Console.WriteLine("Error:"+a);
            }
            MyData.TotalSaslary1 = MyData.BasicSalary1 / 30 * (MyData.WorkedDays1);
            MyData.Transport1 = 117172 /30 *(MyData.WorkedDays1);
            MyData.Health1 = MyData.TotalSaslary1 * 0.04;
            MyData.Retereiment1 = MyData.TotalSaslary1 * 0.04;

            if (MyData.BasicSalary1<=2000000)
            {
                MyData.TotalSaslary1 = MyData.TotalSaslary1 + MyData.Health1;
            }
            else
            {
                MyData.TotalSaslary1 = MyData.TotalSaslary1+0;
            }
        }
        public void ShowInformation()
        {
            Console.WriteLine("\nNumber document: "+MyData.NumberDocument1);
            Console.WriteLine("Firts Name : "+ MyData.FirtsNmae1);
            Console.WriteLine("Last Nnme: "+ MyData.LastName1);
            Console.WriteLine("Basic Salary: "+ MyData.BasicSalary1);
            Console.WriteLine("Worked Days: "+ MyData.WorkedDays1);
            Console.WriteLine("Health: "+ MyData.Health1);
            Console.WriteLine("Retereiment: "+ MyData.Retereiment1);
            Console.WriteLine("Total Salary: "+ MyData.TotalSaslary1);
        }
    }
    class Data
    {
        private double NumberDocument;
        private string FirtsNmae;
        private string LastName;
        private double BasicSalary;
        private double WorkedDays;
        private double Health;
        private double Retereiment;
        private double Transport;
        private double TotalSaslary;

        public Data() { }
        public Data(double NumberDocument1, string FirtsNmae1, string LastName1, double BasicSalary1, double WorkedDays1, double Health1, double Retereiment1, double Transport1, double TotalSaslary1)
        {
        }

        public double NumberDocument1 { get => NumberDocument; set => NumberDocument = value; }
        public string FirtsNmae1 { get => FirtsNmae; set => FirtsNmae = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public double BasicSalary1 { get => BasicSalary; set => BasicSalary = value; }
        public double WorkedDays1 { get => WorkedDays; set => WorkedDays = value; }
        public double Health1 { get => Health; set => Health = value; }
        public double Retereiment1 { get => Retereiment; set => Retereiment = value; }
        public double Transport1 { get => Transport; set => Transport = value; }
        public double TotalSaslary1 { get => TotalSaslary; set => TotalSaslary = value; }
    }  
}