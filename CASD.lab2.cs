using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

    }
    public struct Complex
    {
        public double x; public double y;
        public Complex(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return x.ToString() + " " + y.ToString() + "i";
        }
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.x + b.x, a.y + b.y);
        }
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.x - b.x, a.y - b.y);
        }
        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.x * b.x - b.y * a.y, a.x *  b.y + a.y * b.x);
        }
        public static Complex operator /(Complex a, Complex b)
        {
            return new Complex(((a.x * b.x) + (a.y * b.y)) / ((Math.Pow(b.x, 2)) + (Math.Pow(b.y, 2))), ((a.y * b.x) - (a.x * b.y)) / ((Math.Pow(b.x, 2)) + (Math.Pow(b.y, 2))));
        }
        public double Module()
        {
            return Math.Sqrt((Math.Pow(x, 2)) + (Math.Pow(y, 2)));
        }
        public double Argument()
        {
            if (x > 0) return Math.Atan(y / x);
            if ((x < 0) && (y >= 0)) return Math.PI + Math.Atan(y / x);
            if ((x < 0) && (y < 0)) return (-Math.PI + Math.Atan(y / x));
            if ((x == 0) && (y > 0)) return (Math.PI / 2);
            if ((x == 0) && (y < 0)) return (-Math.PI / 2);
            return 0;
        }
        public double ReturnValid()
        {
            return x;
        }
        
        public double ReturnImaginary()
        {
            return y;
        }
        static void Main(string[] args)

        {         
            Console.Write("Введите действительную часть: ");
            string StringValid = Console.ReadLine();
            Console.Write("Введите мнимую часть: ");
            string StringImaginary = Console.ReadLine();

            double Valid = Convert.ToDouble(StringValid);
            double Imaginary = Convert.ToDouble(StringImaginary);

            
            Complex a = new Complex(Valid, Imaginary);

            bool ExitFromProgram = false;
            while(ExitFromProgram == false) 
            {
                string stringValid2 = "";
                string stringImaginary2 = "";
                double Valid2 = 0.00;
                double Imaginary2 = 0.00;
                Complex b = new Complex(0, 0);

                Console.WriteLine("");
                Console.WriteLine("Выберите интересующий вас вариант:");
                Console.WriteLine("1. Сложение.");
                Console.WriteLine("2. Вычитание.");
                Console.WriteLine("3. Умножение.");
                Console.WriteLine("4. Деление.");
                Console.WriteLine("5. Модуль.(это че ваще)");
                Console.WriteLine("6. Аргумент.(тоже хз абсолютно)");
                Console.WriteLine("7. Вывести действительную часть.");
                Console.WriteLine("8. Вывести мнимую часть.");
                Console.WriteLine("9. Вывести комплексные число.");
                Console.WriteLine("Введите \"q\" или \"Q\" для выхода.");

                string UserChoose = Console.ReadLine();

                switch (UserChoose)
                {
                    case "1" :
                        Console.Write("Введите действительную часть второго числа: ");
                        stringValid2 = Console.ReadLine();
                        Console.Write("Введите мнимую часть второго числа: ");
                        stringImaginary2 = Console.ReadLine();

                        Valid2 = Convert.ToDouble(stringValid2);
                        Imaginary2 = Convert.ToDouble(stringImaginary2);

                        b += new Complex(Valid2, Imaginary2);
                        Console.WriteLine((a + b).ToString());
                        break;
                    case "2" :
                        Console.Write("Введите действительную часть второго числа: ");
                        stringValid2 = Console.ReadLine();
                        Console.Write("Введите мнимую часть второго числа: ");
                        stringImaginary2 = Console.ReadLine();

                        Valid2 = Convert.ToDouble(stringValid2);
                        Imaginary2 = Convert.ToDouble(stringImaginary2);

                        b += new Complex(Valid2, Imaginary2);
                        Console.WriteLine((a + b).ToString());
                        break;
                    case "3" :
                        Console.Write("Введите действительную часть второго числа: ");
                        stringValid2 = Console.ReadLine();
                        Console.Write("Введите мнимую часть второго числа: ");
                        stringImaginary2 = Console.ReadLine();

                        Valid2 = Convert.ToDouble(stringValid2);
                        Imaginary2 = Convert.ToDouble(stringImaginary2);

                        b += new Complex(Valid2, Imaginary2);
                        Console.WriteLine((a * b).ToString());
                        break;
                    case "4" :
                        Console.Write("Введите действительную часть второго числа: ");
                        stringValid2 = Console.ReadLine();
                        Console.Write("Введите мнимую часть второго числа: ");
                        stringImaginary2 = Console.ReadLine();

                        Valid2 = Convert.ToDouble(stringValid2);
                        Imaginary2 = Convert.ToDouble(stringImaginary2);

                        b += new Complex(Valid2, Imaginary2);
                        Console.WriteLine((a / b).ToString());
                        break;
                    case "5" :
                        Console.WriteLine((a).Module());
                        break;
                    case "6" :
                        Console.WriteLine((a).Argument());
                        break;
                    case "7":
                        Console.WriteLine((a).ReturnValid());
                        break;
                    case "8" :
                        Console.WriteLine((a).ReturnImaginary());
                        break;
                    case "9":
                        Console.WriteLine((a).ToString());
                        break;
                    case ("Q"):
                        ExitFromProgram = true;
                        break;
                    case ("q"):
                        ExitFromProgram = true;
                        break;
                    default:
                        Console.WriteLine("\nНеизвестная команда.\n");
                        break;
                }
            }
        }
    }
}
