using System;

namespace France
{
    class Program
    {

        struct Loan
        {
            public int duration;
            public string name;
            public double LA;
        }



        static void Main(string[] args)
        {


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

            Console.Write("\n" + l1.name + "'s total expected payment is" + calcTotalLoan( l1.duration, l1.LA));
            Console.Write("\n" + l2.name + "'s total expected payment is" + calcTotalLoan( l2.duration, l2.LA));
            Console.Write("\n" + l3.name + "'s total expected payment is" + calcTotalLoan( l3.duration, l3.LA));


        }

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
            } else
            {
                return  0;
            }
           
        }
        static double calcTotalLoan(int duration, double LA)
        {
      
            return LA * calcRate(duration);
        }

    }
}
