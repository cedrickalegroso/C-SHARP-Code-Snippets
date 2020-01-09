using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c06_Alegroso_Tuition
{
    class Program
    {

        struct Student
        {
            public string name;
            public string sar;
            public double yearLevel;
            public double unitsEnrolled;

        }


        static double methodtotalTuition(string sar, double yearLevel, double unitsEnrolled)
        {
            if (sar == "S") // if student is scholar
            {
                return   methodYearLevel(yearLevel);
            }
            else if (sar == "A")  // if student is athlete
            {
                return (methodunitsEnrolled(unitsEnrolled) / 2) + methodYearLevel(yearLevel);
            }
            else if (sar == "R")  // if student is regular
            {
               
                return  methodunitsEnrolled(unitsEnrolled) + methodYearLevel(yearLevel);
            }
            else
            {
                return 0;
            }

        }

   
        static double methodYearLevel(double yearLevel)
        {
            if ( yearLevel  == 1 ){
                return 1000;
            } else if ( yearLevel == 2 || yearLevel == 5){
                return 2000;
            } else if ( yearLevel == 3 ){
                return 4000;
            } else if ( yearLevel == 4 ){
                return 3000;
            } else {
                return 0;
            }
        }

        static double methodunitsEnrolled(double unitsEnrolled )
        {
            return unitsEnrolled * 600;
        }


        static void Main(string[] args)
        {


            Student student1;
            Student student2;
            Student student3;


      
            Console.Write("Student's Name: ");
            student1.name = Console.ReadLine();
            Console.Write("Scholar/Athlete/Regular [S, A, R]: ");
            student1.sar = Console.ReadLine();
            Console.Write("Year level: ");
            student1.yearLevel = int.Parse(Console.ReadLine());
            Console.Write("No of Units Enrolled: ");
            student1.unitsEnrolled = int.Parse(Console.ReadLine());


            Console.Write("Student's Name: ");
            student2.name = Console.ReadLine();
            Console.Write("Scholar/Athlete/Regular [S, A, R]: ");
            student2.sar = Console.ReadLine();
            Console.Write("Year level: ");
            student2.yearLevel = int.Parse(Console.ReadLine());
            Console.Write("No of Units Enrolled: ");
            student2.unitsEnrolled = int.Parse(Console.ReadLine());



          
            Console.Write("Student's Name: ");
            student3.name = Console.ReadLine();
            Console.Write("Scholar/Athlete/Regular [S, A, R]: ");
            student3.sar = Console.ReadLine();
            Console.Write("Year level: ");
            student3.yearLevel = int.Parse(Console.ReadLine());
            Console.Write("No of Units Enrolled: ");
            student3.unitsEnrolled = int.Parse(Console.ReadLine());



            Console.WriteLine(student1.name + "'s  tuition is  P" + (methodtotalTuition(student1.sar, student1.yearLevel, student1.unitsEnrolled)));
            Console.WriteLine(student2.name + "'s  tuition is  P" + (methodtotalTuition(student2.sar, student2.yearLevel, student2.unitsEnrolled)));
            Console.WriteLine(student3.name + "'s  tuition is  P" + (methodtotalTuition(student3.sar, student3.yearLevel, student3.unitsEnrolled)));
        }
    }
}
