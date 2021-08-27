using System;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Converter converter = new Converter(10, 10, 10);
                converter.ConvertToSomoni(true, false, false);
                converter.ConvertFromSomoni(true, false, false);
                Employee employee = new Employee("Tom", "Jerry", "manager", 1);
                employee.CalculateSalary();
            }
        }
    }

    public class Converter
    {
        private double _usd;
        private double _eur;
        private double _rub;

        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }

        public void ConvertToSomoni(bool usd, bool eur, bool rub)
        {
            if (usd)
            {
                Console.WriteLine(Math.Round((_usd * 11.33), 2));
            }

            if (eur)
            {
                Console.WriteLine(Math.Round((_eur * 13.95), 2));
            }

            if (rub)
            {
                Console.WriteLine(_rub * 0.1535);
            }
        }

        public void ConvertFromSomoni(bool usd, bool eur, bool rub)
        {
            if (usd)
            {
                Console.WriteLine(Math.Round((_usd / 11.33), 2));
            }

            if (eur)
            {
                Console.WriteLine(Math.Round((_eur / 13.95), 2));
            }

            if (rub)
            {
                Console.WriteLine(Math.Round((_rub / 0.1535), 2));
            }
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