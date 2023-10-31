using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR__2_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для решения квадратных уравнений.");            
            double a, b, c;
            string error = "При выполнении программы была обнаружена ошибка";
            try
            {
                StreamReader stream = new StreamReader("abc.txt"); 
                string filePath = stream.ReadLine();
                string[] parts = filePath.Split(';');                
                if (!double.TryParse(parts[0], out a) || !double.TryParse(parts[1], out b) || !double.TryParse(parts[2], out c))
                    throw new IncorrectDataException();
                a = Convert.ToDouble(parts[0]);
                if (a == 0)
                    throw new FirstArgException();
                Console.WriteLine("a = " + a);
                 b = Convert.ToDouble(parts[1]);
                Console.WriteLine("b = " + b);
                 c = Convert.ToDouble(parts[2]);
                Console.WriteLine("c = " + c);
                
                double discriminant = b * b - 4 * a * c;
                Console.WriteLine("Дискриминант = " + discriminant);
                if (discriminant < 0)
                    throw new NegativeDiscriminantException();
                if (discriminant == 0)
                {
                    Console.WriteLine("x=" + (-b/(2*a)));                    
                }
                if (discriminant > 0)
                {
                    Console.WriteLine("X1= " + ((-b - Math.Sqrt(discriminant)) / (2 * a)));
                    Console.WriteLine("X2= " + ((-b + Math.Sqrt(discriminant)) / (2 * a)));
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(error);
            }
            catch (FirstArgException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(error);
            }
            catch (NegativeDiscriminantException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(error);
            }
            catch (IncorrectDataException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(error);
            }           
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(error);
            }
            Console.ReadLine();
        }
    }
}