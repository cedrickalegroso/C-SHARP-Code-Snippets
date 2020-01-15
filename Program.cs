using System;

namespace Canteen
{
    class Program
    {

        struct Canteen
        {
            public string foodName;
            public int Quantity;
            public int ppu;
        }


        struct Loan
        {
            public int duration;
            public string name;
            public double LA;
        }


        struct traingle
        {
            public double height;
            public double basE;
        }



        static void Main(string[] args)
        {
            int Prog;

            Console.Write(" Choose 1 = Canteem | 2 = Loan | 3 = Area of traingle ");
            Prog = int.Parse(Console.ReadLine());


            if (Prog == 1)
            {
                Console.WriteLine(" WELCOME TO CANTEEN APP ");


                Canteen c1, c2, c3;

                Console.Write("Enter food Name:");
                c1.foodName = Console.ReadLine();
                Console.Write("Enter Quantity: ");
                c1.Quantity = int.Parse(Console.ReadLine());
                Console.Write("Enter price per unit: ");
                c1.ppu = int.Parse(Console.ReadLine());

                CalcCanteen1(c1.Quantity, c1.ppu);

                Console.Write("Enter food Name:");
                c2.foodName = Console.ReadLine();
                Console.Write("Enter Quantity: ");
                c2.Quantity = int.Parse(Console.ReadLine());
                Console.Write("Enter price per unit: ");
                c2.ppu = int.Parse(Console.ReadLine());

                CalcCanteen2(c2.Quantity, c2.ppu);

                Console.Write("Enter food Name:");
                c3.foodName = Console.ReadLine();
                Console.Write("Enter Quantity: ");
                c3.Quantity = int.Parse(Console.ReadLine());
                Console.Write("Enter price per unit: ");
                c3.ppu = int.Parse(Console.ReadLine());

                CalcCanteen3(c3.Quantity, c3.ppu);

                Console.WriteLine("The total cost of " + c1.foodName + "," + c2.foodName + " and " + c3.foodName + " is " + (CalcTotal(CalcCanteen1(c1.Quantity, c1.ppu), CalcCanteen2(c2.Quantity, c2.ppu), CalcCanteen3(c3.Quantity, c3.ppu))));



            } else if (Prog == 2)
            {
                Console.WriteLine(" WELCOME TO LOAN APP ");


                Loan l1, l2, l3;

                Console.Write("Enter name: ");
                l1.name = Console.ReadLine();
                Console.Write("Enter loan amount: ");
                l1.LA = double.Parse(Console.ReadLine());
                Console.Write("Enter duration[6,12,24]: ");
                l1.duration = int.Parse(Console.ReadLine());

                Console.Write("Enter name: ");
                l2.name = Console.ReadLine();
                Console.Write("Enter loan amount: ");
                l2.LA = double.Parse(Console.ReadLine());
                Console.Write("Enter duration[6,12,24]: ");
                l2.duration = int.Parse(Console.ReadLine());

                Console.Write("Enter name: ");
                l3.name = Console.ReadLine();
                Console.Write("Enter loan amount: ");
                l3.LA = double.Parse(Console.ReadLine());
                Console.Write("Enter duration[6,12,24]: ");
                l3.duration = int.Parse(Console.ReadLine());

                Console.Write("\n" + l1.name + "'s total expected payment per month is " + (calcTotalLoanMonthly(l1.duration, l1.LA)) + " for " + l1.duration  + " total of "  + calcTotalLoan(l1.duration, l1.LA));
                Console.Write("\n" + l2.name + "'s total expected payment per month is " + (calcTotalLoanMonthly(l2.duration, l2.LA)) + " for " + l2.duration + " total of " +  calcTotalLoan(l2.duration, l2.LA));
                Console.Write("\n" + l3.name + "'s total expected payment per month is " + (calcTotalLoanMonthly(l3.duration, l3.LA)) + " for " + l3.duration + " total of " +  calcTotalLoan(l3.duration, l3.LA));


            } else if (Prog == 3)
            {
                Console.WriteLine(" WELCOME TO AREA APP ");


                traingle t1;

              
                Console.Write("Enter h: ");
                t1.height = double.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                t1.basE = double.Parse(Console.ReadLine());


                Console.Write(" The calculation of the area is " + CalcT(t1.height, t1.basE));
            }




        }

        // Canteen

        static double CalcCanteen1(int Quantity, int ppu)
        {
            return Quantity * ppu;
        }

        static double CalcCanteen2(int Quantity, int ppu)
        {
            return Quantity * ppu;
        }

        static double CalcCanteen3(int Quantity, int ppu)
        {
            return Quantity * ppu;
        }

        static double CalcTotal(double CalcCanteen1, double CalcCanteen2, double CalcCanteen3)
        {
            return CalcCanteen1 + CalcCanteen2 + CalcCanteen3;
        }



        // Loan 

        static double calcRate(int duration)
        {

            if (duration == 6)
            {
                return .05;
            }
            else if (duration == 12)
            {
                return .07;
            }
            else if (duration == 24)
            {
                return .08;
            }
            else
            {
                return 0;
            }

        }
        static double calcTotalLoan(int duration, double LA)
        {

            return ((LA * calcRate(duration)) + LA) ;
        }


        static double calcTotalLoanMonthly(int duration, double LA)
        {

            return ((LA * calcRate(duration)) + LA) / duration;
        }


        // Traignle 


        static double CalcT(double height, double basE)
        {
            return (height * basE) / 2;
        }
    }
}
