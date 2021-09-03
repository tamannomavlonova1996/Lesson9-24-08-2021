using System;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Теперь запишите сумму:");
                int SUM = int.Parse(Console.ReadLine());
                Converter ExchangeRates=new Converter(10.2183,11.0174,0.1316);
                Console.WriteLine($"\t\tКурс валют на сегодня: \n\t\t1 USD = {10.2183} TJS\n\t\t1 EUR = {11.0174} TJS \n\t\t1 RUB = {0.1316} TJS");
                Console.WriteLine("\nПожалуйста, выберите тип конвертации:");
                Console.WriteLine("Для конвертация сомони в доллар нажмите - 1");
                Console.WriteLine("Для конвертация сомони в евро нажмите - 2");
                Console.WriteLine("Для конвертация сомони в рубл нажмите - 3");
                Console.WriteLine("Для конвертация доллар в сомони нажмите - 4");
                Console.WriteLine("Для конвертация евро в сомони нажмите - 5");
                Console.WriteLine("Для конвертация рубл в сомони нажмите - 6");
                int Choice = int.Parse(Console.ReadLine());
                switch(Choice)
                {
                    case 1:
                        Console.WriteLine($"{SUM} сомони = {ExchangeRates.SomToUsd(SUM)} доллар");
                        break;
                    case 2:
                        Console.WriteLine($"{SUM} сомони = {ExchangeRates.SomToEur(SUM)} евро");
                        break;
                    case 3:
                        Console.WriteLine($"{SUM} сомони = {ExchangeRates.SomToRub(SUM)} рубл");
                        break;
                    case 4:
                        Console.WriteLine($"{SUM} доллар = {ExchangeRates.UsdToSom(SUM)} сомони");
                        break;
                    case 5:
                        Console.WriteLine($"{SUM} евро ={ExchangeRates.EurToSom(SUM)} сомони");
                        break;
                    case 6:
                        Console.WriteLine($"{SUM} рубл = {ExchangeRates.RubToSom(SUM)} сомони");
                        break;
                    default:
                        Console.WriteLine("Неправильная команда. Пожалуйста, попробуйте еще раз");
                        break;
                }
                Console.ReadKey();
                Employee employee = new Employee("Tom", "Jerry", "manager", 1);
                employee.CalculateSalary();
            }
        }
    }

     public class Converter 
        {
            private double USD{ get; set;}
            private double EUR {get; set;}
            private double RUB {get; set;}
            public Converter(double usd, double eur, double rub)
            {
                this.USD = usd;
                this.EUR = eur;
                this.RUB=rub;
            }
            public double SomToUsd(double som)
            {
                return Math.Round(som/USD,4);
            }
            public double SomToEur(double som)
            {
                return Math.Round(som/EUR,4);
            }
            public double SomToRub(double som)
            {
                return Math.Round(som/RUB,4);
            }
            public double UsdToSom(double usd)
            {
                return Math.Round(usd*USD,4);
            }
            public double EurToSom(double eur)
            {
                return Math.Round(eur*EUR,4);
            }
            public double RubToSom(double rub)
            {
                return Math.Round(rub*RUB,4);
            }
        }

    //2 task
    public class Employee
    {
        private string _name;
        private string _surname;
        private string _position;
        private int _experience;

        public string Position
        {
            get { return _position; }
            set
            {
                if (value != "programmer" || value != "manager")
                {
                    Console.WriteLine("Position can only be programmer or manager");
                }
                else
                {
                    _position = value;
                }
            }
        }

        public int Experience
        {
            get { return _experience; }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Experience can not be less than 0 :)");
                }
                else if (value > 82)
                {
                    Console.WriteLine("Experience can not be more than 82");
                }
                else
                {
                    _experience = value;
                }
            }
        }

        public Employee(string name, string surname, string position, int experience)
        {
            _name = name;
            _surname = surname;
            _position = position;
            _experience = experience;
        }

        public void CalculateSalary()
        {
            if (Position.Equals("programmer"))
            {
                int salary = 1000 + 1000 * (Experience * 5) / 100;
                double taxes = (salary * 13 / 100) + (salary * 1 / 100);
                Console.WriteLine(
                    $"Name: {_name}, surname: {_surname}, position: {Position}, salary: {salary}, taxes: {Math.Round((taxes), 2)}");
            }

            if (Position.Equals("manager"))
            {
                int salary = 800 + 800 * (Experience * 5) / 100;
                double taxes = (salary * 13 / 100) + (salary * 1 / 100);
                Console.WriteLine(
                    $"Name: {_name}, surname: {_surname}, position: {Position}, salary: {salary}, taxes: {Math.Round((taxes), 2)}");
            }
        }
    }
}