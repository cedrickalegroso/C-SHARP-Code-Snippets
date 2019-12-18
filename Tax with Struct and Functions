using System;

namespace FucntionTax
{
    class Program
    {

        struct taxStruct
        {
            public int dependents;
            public string Status;
            public double InitIncome;
        }

        // First we call the main function then it will call the children functions
        // then after getting the returned results from each children it will solve the tax
        static double totalTax(double InitIncome, string Status, int dependents)
        {
            return  InitTax(InitIncome) - InitialStatus(Status) + dependentsInit(dependents);
        }

        // Children funtion for getting the initial Tax
        static double InitTax(double InitIncome)
        {

            if (InitIncome >= 500000)
            {
                return InitIncome * 0.20;
            }
            else if (InitIncome >= 250001)
            {
                return InitIncome * 0.15;
            }
            else if (InitIncome >= 100001)
            {
                return InitIncome * 0.10;
            }
            else if (InitIncome <= 100001)
            {
                return InitIncome * 0.05;
            }
            else
            {
                return 0;
            }



        }

        // Children funtion for getting the initial Status
        static double InitialStatus(string Status)
        {

            if (Status == "S")
            {
                return 10000;
            }
            else if (Status == "M")
            {
                return 20000;
            }
            else if (Status == "W")
            {
                return 10000;
            }
            else if (Status == "D")
            {
                return 30000;
            }
            else
            {
                return 0;
            }

        }


        // Children funtion for getting the initial dependent
        static int dependentsInit(int dependents)
        {

            if (dependents >= 5)
            {
                return 50000;
            }
            else if (dependents < 5)
            {
                return 10000 * dependents;
            }
            else
            {
                return 0;
            }

        }



        static void Main(string[] args)
        {

            taxStruct tax1;

            Console.Write("Enter Your Income: ");
            tax1.InitIncome = int.Parse(Console.ReadLine());
            Console.Write("Enter Your Status: ");
            tax1.Status = Console.ReadLine();
            Console.Write("Enter Number of dependents: ");
            tax1.dependents = int.Parse(Console.ReadLine());


            Console.WriteLine(totalTax(tax1.InitIncome, tax1.Status, tax1.dependents));

            
        }
    }
}
