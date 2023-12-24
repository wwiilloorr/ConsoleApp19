using System;
namespace ConsoleApp16
{
    class Type
    {
        public string Name = "";
        public int Choose = 0;
        public void chooseType()
        {
            Console.WriteLine("Виберіть режим прання: Бавовна - 1; Швидке прання - 2; Кольрове - 3; Делікатне - 4");
            Choose = Convert.ToInt32(Console.ReadLine());

            if (Choose == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ви вибрали режим: Бавовна");
                Console.ResetColor();
            }
            else if (Choose == 2)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Ви вибрали режим: Швидке прання");
                Console.ResetColor();
            }
            else if (Choose == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Ви вибрали режим: Кольрове");
                Console.ResetColor();
            }
            else if (Choose == 4)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Ви вибрали режим:  Делікатне");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Помилка!!Такої операції немає!!");
                Console.ResetColor();
            }
        }

    }
    class WashingMachine
    {
        public string Name = "";
        public double Time = 0;
        public WashingMachine(string Name)
        {

        }
        public void showchoseTime()
        {
            Console.Write("На скільки хочете поставити стіраться??(1 - 5min): ");
            Time = Convert.ToDouble(Console.ReadLine());
            if (Time > 1 && Time < 5)
            {
                Console.WriteLine("Встановленнтй час прання:" + Time + "Minutes");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Помилка!!Ваше число не входить до діапазону!!!");
                Console.ResetColor();
            }
        }
        int start = 0;
        int numF = 0;
        bool door;
        public void closeandstartWashingMachine()
        {
            Console.Write("Закрити двері?(так - 1; ні - 2): ");
            numF = Convert.ToInt32(Console.ReadLine());
            if (numF == 1)
            {
                Console.Write("Двері закриті!!");
                door = true;
            }
            else if (numF == 2)
            {
                Console.Write("Двері відкриті!!!");
                door = false;
            }
            else
            {
                Console.Write("Error!!! ");

            }
            Console.Write("Чи хочетке почати  прання? - 1: ");
            start = Convert.ToInt32(Console.ReadLine());

            if (door == true)
            {
                if (start == 1)
                {
                    Console.Write("Прання Почато!!На " + Time + "хвилин!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Error!!!");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Error!!!");
                Console.ResetColor();
            }


        }
        int choice = 0;
        int Powder = 0;
        public void doWashingPowder()
        {
            Console.Write("Чи бажаєте засипати пральний порошок??(1 - yes; 2 - no): ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Скільки хочете добавити???(1 - 5кг): ");
                Powder = Convert.ToInt32(Console.ReadLine());
                if (Powder >= 1 && Powder <= 5)
                {
                    Console.Write("Загружено: " + Powder + " kg of powder!!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Error!!! Ваша стіралка переповнена!!!");
                    Console.ResetColor();
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Ну як хочеш!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Error");
                Console.ResetColor();
            }
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            WashingMachine obj = new WashingMachine("G PRO X SPEED ");
            Type type = new Type();

            double choose1 = 0;
            double choose2 = 0;
            while (true)
            {
                Console.Write("1 - Налаштування стіралки; 2 - Запуск: ");
                choose1 = Convert.ToDouble(Console.ReadLine());
                if (choose1 == 1)
                {
                    Console.Write("1 - Час прання; 2 - Тип прання: ");
                    choose2 = Convert.ToDouble(Console.ReadLine());
                    if (choose2 == 1)
                    {
                        obj.showchoseTime();
                    }
                    else if (choose2 == 2)
                    {
                        type.chooseType();
                    }
                    else if (choose2 == 3)
                    {
                        obj.doWashingPowder();
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                else if (choose1 == 2)
                {
                    obj.closeandstartWashingMachine();
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}