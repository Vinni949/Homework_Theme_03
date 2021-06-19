using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_03
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Просматривая сайты по поиску работы, у вас вызывает интерес следующая вакансия:

             Требуемый опыт работы: без опыта
             Частичная занятость, удалённая работа

             Описание

             Стартап «Micarosppoftle» занимающийся разработкой
             многопользовательских игр ищет разработчиков в свою команду.
             Компания готова рассмотреть C#-программистов не имеющих опыта в разработке, 
             но желающих развиваться в сфере разработки игр на платформе.NET.

             Должность Интерн C#/
            
             Основные требования:
            C#, операторы ввода и вывода данных, управляющие конструкции 
             
             Конкурентным преимуществом будет знание процедурного программирования.


             Не технические требования:
            английский на уровне понимания документации и справочных материалов

             В качестве тестового задания предлагается решить следующую задачу.

             Написать игру, в которою могут играть два игрока.
             При старте, игрокам предлагается ввести свои никнеймы.
             Никнеймы хранятся до конца игры.
             Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
             Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
             Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
             введенное число вычитается из gameNumber
             Новое значение gameNumber показывается игрокам на экране.
             Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
             Игра поздравляет победителя, предлагая сыграть реванш

             * Бонус:
             Подумать над возможностью реализации разных уровней сложности.
             В качестве уровней сложности может выступать настраиваемое, в начале игры,
             значение userTry, изменение диапазона gameNumber, или указание большего количества игроков(3, 4, 5...)

             ***Сложный бонус
            Подумать над возможностью реализации однопользовательской игры
            т е игрок должен играть с компьютером

             Демонстрация
             Число: 12,
             Ход User1: 3

             Число: 9
             Ход User2: 4

             Число: 5
             Ход User1: 2

             Число: 3
             Ход User2: 3

             User2 победил!
            */
            bool i = true;
            while (i)
            {
                Console.WriteLine("Выберите режим игры:");
                Console.WriteLine("1-игра против ИИ, 2-игра двух играков,3-игра трех играков,0-выход");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        ComputerVSuser();
                        break;
                    case 2:
                        UserVSuser();
                        break;
                    case 3:
                        UserVSuserVSuser();
                        break;
                    case 0:
                        i = false;
                        break;

                }
            }

            void ComputerVSuser()
            {
                Console.Clear();
                Console.Write("Введите ник первого игрока:");
                string user1 = Console.ReadLine();
                Console.Write("Второй игрок компьютер!");
                string user2 = "Компьютер";
                    Console.WriteLine($"Играют {user1} и {user2}!");
                    int rand = Complexity();
                bool f = true;
                int m;
                while (rand > 0)
                    {
                    Console.WriteLine(rand);
                    Console.WriteLine("{0}, ваш ход", f ? user1 : user2);
                    if (f)
                    {
                        m = int.Parse(Console.ReadLine());
                        while (!(m >= 1 && m <= 4))
                        {
                            Console.WriteLine("Некорректный ход! {0}, повторите ввод", f ? user1 : user2);
                            m = int.Parse(Console.ReadLine());
                        }
                    }
                    rand -= m;
                    f = !f;
               } 
            }

            void UserVSuser()
            {
                while (true)
                {
                    Console.Clear();
                    int count = 0;
                    Console.Write("никнейм первого игрока: ");
                    string user1 = Console.ReadLine();
                    Console.Write("никнейм второго игрока: ");
                    string user2 = Console.ReadLine();
                    gameNumber=
                    Console.WriteLine("загадонное число: " + gameNumber);
                    Console.WriteLine("введите число от 1 до 4:");
                    while (gameNumber != 0)
                    {
                        Console.WriteLine(count % 2 == 0 ? $"ход игрока {user1}" : $"ход игрока {user2}");
                        int userTry = Check();
                        if (gameNumber - userTry < 0)
                        {
                            Console.WriteLine("результат не может быть меньше 0, введите другое число");
                            continue;
                        }
                        gameNumber -= userTry;
                        count++;
                        Console.WriteLine("осталось: " + gameNumber);
                    }
                    Console.WriteLine(count % 2 != 0 ? $"выиграл игрок {user1}" : $"выиграл игрок {user2}");
                    Console.WriteLine("чтобы сыграть еще раз нажите пробел");
                    if (Console.ReadKey().Key != ConsoleKey.Spacebar) break;
                }

            }
            
            void UserVSuserVSuser()
            {
                Console.Clear();
                Console.Write("Введите ник первого игрока:");
                string user1 = Console.ReadLine();
                Console.Write("Введите ник второго игрока:");
                string user2 = Console.ReadLine();
                Console.Write("Введите ник третьего игрока:");
                string user3 = Console.ReadLine();
                bool i = true;
                    Console.WriteLine($"Играют {user1} , {user2} и {user3}!");
                    int rand = Complexity();
                    while (rand > 0)
                    {
                        Console.WriteLine(rand);
                        Console.Write($"Ход игрока: {user1} \nвведите число от 1 до 4х :");
                        int us1 = Convert.ToInt16(Console.ReadLine());
                        if (us1 <= rand)
                        {
                            rand -= us1;
                        }
                        if (rand <= 0)
                        {
                            Console.WriteLine($"{user1} победил!");
                            break;
                        }
                        Console.Write($"Ход игрока: {user2} \nвведите число от 1 до 4х :");
                        int us2 = Convert.ToInt16(Console.ReadKey());
                        if (us2 <= rand)
                        {
                            rand -= us2;
                        }
                        if (rand <= 0)
                        {
                            Console.WriteLine($"{user2} победил!");
                            break;
                        }
                        Console.Write($"Ход игрока: {user3} \nвведите число от 1 до 4х :");
                        int us3 = Convert.ToInt16(Console.ReadLine());
                        if (us3 <= rand)
                        {
                            rand -= us3;
                        }
                        if (rand <= 0)
                        {
                            Console.WriteLine($"{user3} победил!");
                            break;
                        }
                    }
            }
            int Check()
            {
                int x;
                while (true)
                {
                    while (!int.TryParse(Console.ReadLine(), out x)) Console.WriteLine("нужно вести число!");
                    if (x < 1 || x > 4)
                    {
                        Console.WriteLine("нужно ввести число от 1 до 4");
                        continue;
                    }
                    break;
                }
                return x;
            }

            int Complexity()
            {
                Random rand = new Random();
                int minRand = 0, maxRand = 0;
                Console.WriteLine("Выберите сложность! \n 1-легко, 2-средне, 3-сложно");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        minRand = 12;
                        maxRand = 120;
                        break;
                    case 2:
                        minRand = 10;
                        maxRand = 240;
                        break;
                    case 3:
                        minRand = 0;
                        maxRand = 360;
                        break;
                }
                int rdn = rand.Next(minRand, maxRand);
                Console.WriteLine(minRand + " " + maxRand + " " + rdn);//для проверки функции.
                return rdn;
            }


        }

    }
}
