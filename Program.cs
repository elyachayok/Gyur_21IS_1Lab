using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG_21IS
{

        class Car
        {
            //Открытые поля для хранения данных
            public string Brand;   
            public string Number;   
            public double Mileage;  

            //Метод Show() — показать данные об автомобиле
            public void Show()
            {
                Console.WriteLine($"Марка: {Brand}");
                Console.WriteLine($"Номер: {Number}");
                Console.WriteLine($"Пробег: {Mileage} км");
            }

            //Метод расчета среднего пробега за год
            //age — возраст автомобиля (в годах), передается как параметр
            public double SredProbeg(int age)
            {
                if (age <= 0)
                {
                    Console.WriteLine("Возраст должен быть больше 0!");
                    return 0;
                }
                return Mileage / age; 
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                //Создаем объект класса Car
                Car myCar = new Car();

                //Задаем значения полям объекта
                myCar.Brand = "Жигули";
                myCar.Number = "Т144ТО";
                myCar.Mileage = 10350;

                //Выводим данные об автомобиле на экран
                Console.WriteLine("--- Данные об автомобиле ---");
                myCar.Show();

                //Считаем средний пробег за год (возраст = 2 года)
                double sred = myCar.SredProbeg(2);
                Console.WriteLine($"\nСредний пробег за год (возраст авто: 2 года): {sred} км");

                Console.ReadKey();
            }
        }
    
}


