using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder_och_funktioner
{
    class Program
    {
        //Övning 1

        static void CelsiusTillFarenheit()
        {
            Console.Write("Mata in grader Celcius: ");
            double Celsius = double.Parse(Console.ReadLine());
            double Farenheit = (Celsius / 5.0) * 9 + 32;
            Console.WriteLine(Celsius + " celsius är lika mycket som "+ Farenheit + " farenheit!");
        }

        //Övning 2

        static void CirkelnsArea(double Radie)
        {
            double Area = Math.Round(Radie * Radie * Math.PI,2);
            Console.WriteLine("Area: " + Area);


        }
        static void CirkelnsOmkrets(double Radie)
        {
            double Omkrets = Math.Round(Radie * 2 * Math.PI,2);
            ;
            Console.WriteLine("Omkrets: " + Omkrets);
        }


        
        static void Main(string[] args)
        {
            //CelsiusTillFarenheit();
            Console.Write("Mata in cirkelns radie: ");
            double Radie = double.Parse(Console.ReadLine());

            CirkelnsArea(Radie);
            CirkelnsOmkrets(Radie);
        }
    }
}
