using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CrazyProg
{
    internal class Program
    {

        public static void Main()
        {
            int doing;
       
            Console.WriteLine(">>>>>>>>> WELCOME, MY FRIEND <<<<<<<<<");
            Console.WriteLine("Нажмите ENTER, чтобы продолжить и увидеть меню");
            Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Выберите из меню программу, которую хотите открыть и введите её номер:");
            Console.WriteLine("1. Игра 'Угадай число'");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Для выхода из программы");
            Console.WriteLine("-------------------------------------------------------------------------");

            doing = int.Parse(Console.ReadLine());

         
                switch (doing)
                {
                    case 1:
                        GuessTheNumb();
                        break;
                    case 2:
                        ProdsDo();
                        break;
                    case 3:
                        DivsOfNumb();
                        break;
                    case 4:
                        Console.WriteLine("Вы завершили работу с программой");
                        break;
                    default:
                    Console.WriteLine("Такого числа в меню нет! Возвращаю Вас в главное меню, попробуйте ещё раз!");
                    Console.WriteLine();
                    Main();
                    break;
 
                }
         
        }
        private static void GuessTheNumb()
        {
            Console.WriteLine(">>>> УГАДАЙ ЧИСЛО <<<<");
            Console.WriteLine("Программа загадывает число от 0 до 100");
            Console.WriteLine("Ваша задача - отгадать его");
            Console.WriteLine("На протяжении игры Вы будете вводить число и получать подсказки: близко оно к загаданному или нет");
            Console.WriteLine("Удачи! :) ");
            Console.Write("Введите число и игра начнётся: ");
            Random rand = new Random();
            int yourwin = rand.Next(0, 101);
            int guessWho;
            string respons;
            int trying = 0;

            do
            {

                guessWho = Convert.ToInt32(Console.ReadLine());
                trying++;
               
              if (guessWho > 100 || guessWho < 0)
                {
                    Console.WriteLine("Вам же сказали от 0 до 100, не изобретайте велосипед, введите ещё раз!!!");
                    continue;
                }

                if (guessWho > yourwin)
                {
                    Console.WriteLine("Загаданное число меньше! Пробуй ещё раз!");
                    continue;
                }
                if (guessWho < yourwin)
                {
                    Console.WriteLine("Загаданное число больше! Пробуй ещё раз!");
                    continue;
                }
                if (guessWho == yourwin)
                {
     
                    int lastD = trying % 10;

                    if (trying % 10 == 1 && trying != 10 && trying != 11 && trying != 12 && trying != 13 && trying != 14 && trying != 15 && trying != 16 && trying != 17 && trying != 18 && trying != 19)
                    {
                        Console.WriteLine($"Это было число {guessWho} ! Молодец, ты угадал его за {trying} попытку!");

                    }
                    if (trying > 10 && trying <= 19)
                    {
                        Console.WriteLine($"Это было число {guessWho} ! Молодец, ты угадал его за {trying} попыток!");
                    }
                    if (trying != 12 && lastD == 2 || lastD == 3 && trying != 13 || lastD == 4 && trying != 14)
                    {
                        Console.WriteLine($"Это было число {guessWho} ! Молодец, ты угадал его за {trying} попытки!");
                    }
                    if (lastD == 0 || lastD >= 5 && trying != 10 && trying != 13 && trying != 14 && trying != 15 && trying != 16 && trying != 17 && trying != 18 && trying != 19)
                    {
                        Console.WriteLine($"Это было число {guessWho} ! Молодец, ты угадал его за {trying} попыток!");
                    }

                    Console.WriteLine("Если хочешь продолжить - введи 'погнали', если устал и хочешь выйти в меню - введи 'выход' ");
                    respons = Console.ReadLine().ToLower();

                  if (respons == "погнали")
                  {
                        Console.WriteLine("Продолжаем!");
                        Console.WriteLine();
                        GuessTheNumb();
                        break;
                  }

                  if (respons == "выход")

                  {
                        Console.WriteLine("Вы вышли из программы в главное меню");
                        Console.WriteLine();
                        Main();
                        break;
                        
                       
                  }
                  else
                  {
                        Console.WriteLine("Ошибка: неверное значение, возвращаем в главное меню");
                        Console.WriteLine();
                        Main();
                        break;
                      
                  }

                }
            } while (guessWho != yourwin);
        }
        private static void ProdsDo()
        {
            Console.WriteLine("Вы выбрали таблицу умножения, нажмите ENTER, чтобы программа вывела её на экран:");
            Console.ReadLine();

            int[,] mas = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mas[i, j] = (i+1)*(j+1);
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("{0,4}", mas[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введите 'меню', чтобы вернуться в главное меню");
            string choice2 = Console.ReadLine();

            if (choice2 == "меню")
            {
                Console.WriteLine("Выходим в меню");
                Console.WriteLine();
                Main();
            }
            else
            {
                Console.WriteLine("Неверное значение, но мы всё равно выводим Вас в главное меню :) ");
                Console.WriteLine();
                Main();
            }
        }
        private static void DivsOfNumb()
        {
            string MoreAnswers;

            Console.WriteLine("Программа ищет числа, на которые нацело делится введённое число, то есть его делители");
            Console.Write("Введите ваше число: ");

            do
            {

                int numberCheck = Convert.ToInt32(Console.ReadLine());

                if (numberCheck <= 0)
                {
                    Console.WriteLine("Вводите только целые числа, которые больше нуля!!!");
                    DivsOfNumb();
                    break;
                }

             
                Console.WriteLine($"Делители числа {numberCheck}:");


                for (int i = 1; i <= numberCheck; i++)
                {

                    if (numberCheck % i == 0)
                    {

                        Console.WriteLine(i);

                    }
                }
                Console.WriteLine("Если Вы хотите выйти из программы в меню - введите 'выход', если хотите найти делители ещё одного числа - введите 'ещё' ");
                MoreAnswers = Console.ReadLine().ToLower();

                if (MoreAnswers == "ещё")
                {
                    Console.WriteLine("Продолжаем!");
                    Console.WriteLine();
                    DivsOfNumb();
                    break;
                }
                if (MoreAnswers == "выход")
                {
                    Console.WriteLine("Вы вышли из программы в главное меню");
                    Console.WriteLine();
                    Main();
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка: неверное значение, возвращаем Вас в главное меню ");
                    Console.WriteLine("P.S. если Вы хотели продолжить - попробуйте ещё раз и убедитесь, что Вы не обижаете букву 'ё' (((");
                    Console.WriteLine();
                    Main();
                    break;
                }
            }
            while (MoreAnswers != "выход");
        }
    }
}