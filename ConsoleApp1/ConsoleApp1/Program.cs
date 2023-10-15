using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Net;
using System.Text;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //num1
            /*
            while (true)
            {
                Console.WriteLine("Выберите направление перевода:");
                Console.WriteLine("1. Из десятичной в двоичную");
                Console.WriteLine("2. Из двоичной в десятичную");
                Console.WriteLine("3. Из десятичной в восьмеричную");
                Console.WriteLine("4. Из восьмеричной в десятичную");
                Console.WriteLine("5. Из двоичной в восьмеричную");
                Console.WriteLine("6. Из восьмеричной в двоичную");
                Console.WriteLine("7. Выход");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 7)
                {
                    Console.WriteLine("Ошибка.Выберите от 1 до 7.");
                    continue;
                }
                if (choice == 7) break;


                Console.WriteLine("Введите число:");
                if (choice == 1)
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    string result = Convert.ToString(input, 2);
                    Console.WriteLine("в двоичной системе: " + result);
                }
                else if (choice == 2)
                {
                    string input = Console.ReadLine();
                    int result = Convert.ToInt32(input, 2);
                    Console.WriteLine("в десятичной системе: " + result);
                }
                else if (choice == 3)
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    string result = Convert.ToString(input, 8);
                    Console.WriteLine("в восьмеричной системе: " + result);
                }
                else if(choice == 4)
                {
                    string input = Console.ReadLine();
                    int result = Convert.ToInt32(input, 8);
                    Console.WriteLine("в десятичной системе: " + result);
                }
                else if (choice == 5)
                {
                    string input = Console.ReadLine();
                    int number = Convert.ToInt32(input, 2);
                    string result = Convert.ToString(number, 8);
                    Console.WriteLine("в восьмеричной системе: " + result);
                }
                else if(choice == 6)
                {
                    int input = Convert.ToInt32(Console.ReadLine(), 8); 
                    string result = Convert.ToString(input, 2);
                    Console.WriteLine("в двоичной системе: " + result);
                }
            }
            */
            //num2
            /*
            Console.WriteLine("Введите число от 0 до 9");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("zero");
            }
            else if(num == 1)
            {
                Console.WriteLine("one");
            }
            else if (num == 2)
            {
                Console.WriteLine("two");
            }
            else if (num == 3)
            {
                Console.WriteLine("three");
            }
            else if (num == 4)
            {
                Console.WriteLine("four");
            }
            else if (num == 5)
            {
                Console.WriteLine("five");
            }
            else if (num == 6)
            {
                Console.WriteLine("six");
            }
            else if (num == 7)
            {
                Console.WriteLine("seven");
            }
            else if (num == 8)
            {
                Console.WriteLine("eight");
            }
            else if (num == 9)
            {
                Console.WriteLine("nine");
            }
            else
            {
                Console.WriteLine("попробуйте заново");
            }
            */
            //num3
            /*
            Passport passport = new Passport("123456789", "FIO", null); ;
            Console.WriteLine(passport);
            */
            //num4
            /*
            Console.Write("Введите логическое выражение (например, 3>2 или 7<3): ");
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');
            int operand1 = int.Parse(tokens[0]);
            int operand2 = int.Parse(tokens[2]);
            string op = tokens[1];
            bool result;
            if (op == ">")
            {
                result = operand1 > operand2;
            }
            else if (op == "<")
            {
                result = operand1 < operand2;
            }
            else if (op == ">=")
            {
                result = operand1 >= operand2;
            }
            else if (op == "<=")
            {
                result = operand1 <= operand2;
            }
            else if (op == "==")
            {
                result = operand1 == operand2;
            }
            else if (op == "!=")
            {
                result = operand1 != operand2;
            }
            else
            {
                throw new ArgumentException("Неверный оператор.");
            }
            Console.WriteLine("Результат: " + result);
            */
        }
    }
    class Passport
    {
        private string passportNumber;
        private string fullName;
        private string issueDate;
        public Passport(string passportNumber, string fullName, string issueDate)
        {
            if (passportNumber == null || passportNumber.Length > 9 || passportNumber.Length < 1 ) 
            {
                throw new ArgumentException();
            }
            if(fullName == null)
            {
                throw new ArgumentException();
            }
            if(issueDate == null)
            {
                throw new ArgumentException();
            }
        }
        public string PassportNumber
        {
            get { return passportNumber; }
            set { passportNumber = value; }
        }
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
        public string IssueDate
        {
            get { return issueDate; }
            set { issueDate = value; }
        }

    }

}