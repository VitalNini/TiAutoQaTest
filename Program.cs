using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;



namespace Tria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter coordinate x of dot A: \n");
            string stringCooxA = Console.ReadLine();

            Console.Write("Enter coordinate y of dot A: \n");
            string stringCooyA = Console.ReadLine();

            Console.Write("Enter coordinate x of dot B: \n");
            string stringCooxB = Console.ReadLine();

            Console.Write("Enter coordinate y of dot B: \n");
            string stringCooyB = Console.ReadLine();

            Console.Write("Enter coordinate x of dot C: \n");
            string stringCooxC = Console.ReadLine();

            Console.Write("Enter coordinate y of dot C: \n");
            string stringCooyC = Console.ReadLine();


            string[] Coords = { stringCooxA, stringCooyA, stringCooxB, stringCooyB, stringCooxC, stringCooyC };
            int temps1 = Coords.Length;


            double[] temps2 = new double[temps1];
            for (int i = 0; i < Coords.Length; i++)
                if (Coords[i].Contains("/"))

                {
                    string num1 = Convert.ToString(Coords[i][0]);
                    string num2 = Convert.ToString(Coords[i][2]);
                    double num3 = Convert.ToDouble(num1);
                    double num4 = Convert.ToDouble(num2);
                    double t = num3 / num4;
                    temps2[i] = t;
                }
                else
                {
                    temps2[i] = double.Parse(Coords[i]); ;

                }
            double AB0 = Math.Sqrt(Math.Pow(temps2[0] - temps2[2], 2) + Math.Pow(temps2[1] - temps2[3], 2));
            string AB = Convert.ToString(AB0);
            Console.WriteLine("\nLength of AB is: '" + AB + "'");
            
            double BC0 = Math.Sqrt(Math.Pow(temps2[2] - temps2[4], 2) + Math.Pow(temps2[3] - temps2[5], 2));
            string BC = Convert.ToString(BC0);
            Console.WriteLine("Length of BC is: '"+ BC+"'");

            double AC0 = Math.Sqrt(Math.Pow(temps2[0] - temps2[4], 2) + Math.Pow(temps2[1] - temps2[5], 2));
            string AC = Convert.ToString(AC0);
            Console.WriteLine("Length of AC is: '"+AC +"'");


            // describe tiangle
            if ((AC0 != AB0 || AC0 != BC0 || BC0 != AB0) && (AB0 != 0 || AC0 != 0 || BC0 != 0) )
            {
                Console.WriteLine("\nTriangle IS NOT 'Equilateral'");

            }
            else if (AC0 == AB0 && AC0 == BC0 && BC0 == AB0 && AB0 != 0 || AC0 != 0 || BC0 != 0)
            {
                Console.WriteLine("\nTriangle IS  'Equilateral'");
            }
            if ((AC0 == AB0 || AC0 == BC0 || BC0 == AB0)  && (AB0 != 0 || AC0 != 0 || BC0 != 0 )&&( AB0 != 0 || AC0 != 0 || BC0 != 0))
            {
                Console.WriteLine("Triangle IS 'Isosceles'");


            }
            else if ( (AC0 != AB0 && AC0 != BC0 && BC0 != AB0) &&( AB0 != 0 || AC0 != 0 || BC0 != 0))
            {
                Console.WriteLine("Triangle IS NOT 'Isosceles'");


            }

            if (Math.Pow(BC0, 2) - (Math.Pow(AC0, 2) + Math.Pow(AC0, 2)) <= 0.00000001  && AB0 != 0 || AC0 != 0 || BC0 != 0)
            {
                Console.WriteLine("Triangle IS 'Right'");

            }
            else if (Math.Pow(BC0, 2) - (Math.Pow(AC0, 2) + Math.Pow(AC0, 2)) >= 0.00000001  && AB0 != 0 || AC0 != 0 || BC0 != 0)
            {
                Console.WriteLine("Triangle IS NOT 'Right'");

            }
            if (AB0 ==0 || AC0 == 0 || BC0 ==0 )
            {
                Console.WriteLine("NOT  a triangle");
            }
            double perimeter = AB0 + BC0 + AC0;
            string peri = Convert.ToString(perimeter);
            Console.WriteLine("\nPerimeter: '"+ peri+"'");
            

            int index = 0;
            Console.WriteLine("\nParaty in range from 0 to triangle perimeter: ");
            do
            {
                Console.WriteLine(index);
                index = index + 2;

            } while ( perimeter > index);

            Console.ReadLine();
            

        }

    }
}

