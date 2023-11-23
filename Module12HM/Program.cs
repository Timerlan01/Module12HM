using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12HM
{
    class RacingGame
    {
        static void Main()
        {
            // Создаем автомобили разных типов
            SportsCar sportsCar = new SportsCar("Ferrari", 120);
            PassengerCar passengerCar = new PassengerCar("Toyota", 80);
            Truck truck = new Truck("Volvo", 60);
            Bus bus = new Bus("Mercedes", 70);

            // Подписываемся на событие "Финиш" для каждого автомобиля
            sportsCar.Finish += Car_Finish;
            passengerCar.Finish += Car_Finish;
            truck.Finish += Car_Finish;
            bus.Finish += Car_Finish;

            // Запускаем гонки
            StartRace(sportsCar, passengerCar, truck, bus);
        }
        // Метод для запуска гонок
        static void StartRace(params Car[] cars)
        {
            Console.WriteLine("Гонка началась!");

            while (true)
            {
                foreach (var car in cars)
                {
                    car.Drive();

                    // Проверяем условие завершения гонки
                    if (car.Speed * 10 >= 100)
                    {
                        car.Drive(); // Выводим последнее сообщение о движении
                        car.OnFinish(); // Вызываем метод "Финиш"
                        Console.WriteLine($"Победил автомобиль {car.Model}!");
                        return;
                    }
                }
                Console.WriteLine("-----");
            }
        }
    }
    static void Car_Finish(object sender, EventArgs e)
    {
  
    }
}
