using Стрелочное_меню;

class Torty
{
        static string Cake = "";
        static int Price = 0; 
        
        static void Main()
        {
            while (true)
            {
            Console.Clear();
            Console.WriteLine("  Выберите параметры для вашего торта:");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("   1. Выбор формы.");
            Console.WriteLine("   2. Выбор размера.");
            Console.WriteLine("   3. Выбор вкуса");
            Console.WriteLine("   4. Колличество коржей.");
            Console.WriteLine("   5. Выбор глазури.");
            Console.WriteLine("   6. Выбор декора.");
            Console.WriteLine("   7. Закончить заказ.");

            Console.WriteLine($"Цена: {Price}");
                Console.WriteLine($"Вы выбрали: {Cake}");
                
                int selected = Arrow.Show(2, 8);

                if (selected == 2)
                {
                    FormaTorta();
                }
                else if (selected == 3)
                {
                    RazmerTorta();
                }
                else if (selected == 4)
                {
                    VkusTorta();
                }
                else if (selected == 5) 
                {
                    KolichestvoKorjei();
                }
                else if (selected == 6) 
                {
                    GlazurTorta();
                }
                else if (selected == 7)
                {
           
                    DekorTorta();
                }
                else if (selected == 8)
                {
                    ConsoleKeyInfo key;

                    File.AppendAllText("заказ.txt", "\n Заказ от " + DateTime.Now);
                    File.AppendAllText("заказ.txt", $"\n Заказ: {Cake}");
                    File.AppendAllText("заказ.txt", $"\n Цена: {Price}");


                    Console.Clear();

                    Console.WriteLine("Нажмите клавишу Escape для создания нового заказа.");
                    key = Console.ReadKey();

                    if (key.Key == ConsoleKey.Escape)
                    {
                        Cake = "";
                        Price = 0;
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break; 
                    }
                }

            }
        }
        
        static void FormaTorta()
        {
            int posission = 2;
            ConsoleKeyInfo key;

            do
            {
            Console.Clear();
            Console.WriteLine("Задайте желаемую форму для вашего торта.");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("   1. Квадрат - 200.");
            Console.WriteLine("   2. Треугольник - 150.");
            Console.WriteLine("   3. Круг - 120.");
            Console.WriteLine("    Нажмите Escape, чтобы вернуться в меню.");


            Console.SetCursorPosition(0, posission);
                Console.WriteLine("->");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow && posission != 2)
                {
                    posission--;
                }
                else if (key.Key == ConsoleKey.DownArrow && posission != 4)
                {
                    posission++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (posission == 2)
                    {
                        Cake += "Квадрат; ";
                        Price += 200;
                    }
                    else if (posission == 3)
                    {
                        Cake += "Треугольник; ";
                        Price += 150;
                    }
                    else if (posission == 4)
                    {
                        Cake += "Круг; ";
                        Price += 120;
                    }
                }
            } while (key.Key != ConsoleKey.Escape);


        }


        static void RazmerTorta()
        {
            int posission = 2;
            ConsoleKeyInfo key;

            do
            {
            Console.Clear();
            Console.WriteLine("Выберите желаемый размер для вашего торта.");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("   1. Маленький - 70.");
            Console.WriteLine("   2. Средний - 120.");
            Console.WriteLine("   3. Большой - 200.");
            Console.WriteLine("    Нажмите Escape, чтобы вернуться в меню.");

            Console.SetCursorPosition(0, posission);
                Console.WriteLine("->");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow && posission != 2)
                {
                    posission--;
                }
                else if (key.Key == ConsoleKey.DownArrow && posission != 4)
                {
                    posission++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (posission == 2)
                    {
                        Cake += "Маленький; ";
                        Price += 70;
                    }
                    else if (posission == 3)
                    {
                        Cake += "Средний; ";
                        Price += 120;
                    }
                    else if (posission == 4)
                    {
                        Cake += "Большой; ";
                        Price += 200;
                    }

                }

            } while (key.Key != ConsoleKey.Escape);

        }

        static void VkusTorta()
        {
            int posission = 2;
            ConsoleKeyInfo key;

            do
            {
            Console.Clear();
            Console.WriteLine("Выберите желаемый вкус для вашего торта.");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("   1. Ваниль - 70.");
            Console.WriteLine("   2. Шоколад - 60.");
            Console.WriteLine("   3. Манго - 100.");
            Console.WriteLine("   4. Выбрать свой вкус - 250.");
            Console.WriteLine("    Нажмите Escape, чтобы вернуться в меню.");

            Console.SetCursorPosition(0, posission);
                Console.WriteLine("->");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow && posission != 2)
                {
                    posission--;
                }
                else if (key.Key == ConsoleKey.DownArrow && posission != 5)
                {
                    posission++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (posission == 2)
                    {
                        Cake += "Ванильный; ";
                        Price += 70;
                    }
                    else if (posission == 3)
                    {
                        Cake += "Шоколад; ";
                        Price += 60;
                    }
                    else if (posission == 4)
                    {
                        Cake += "Манго; ";
                        Price += 100;
                    }
                    else if (posission == 5)
                    {
                        Cake += "Ваш вкус; ";
                        Price += 250;
                    }
                }
            } while (key.Key != ConsoleKey.Escape);
        }

        static void KolichestvoKorjei()
        {
            int posission = 2;
            ConsoleKeyInfo key;

            do
            {
            Console.Clear();
            Console.WriteLine("Задайте желаемое количество коржей в вашем торте.");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("   1. 2 коржа - 180.");
            Console.WriteLine("   2. 3 коржа - 200.");
            Console.WriteLine("   3. 4 коржа - 250.");
            Console.WriteLine("   Нажмите Escape, чтобы вернуться в меню.");

            Console.SetCursorPosition(0, posission);
                Console.WriteLine("->");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow && posission != 2)
                {
                    posission--;
                }
                else if (key.Key == ConsoleKey.DownArrow && posission != 4)
                {
                    posission++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (posission == 2)
                    {
                        Cake += "2 коржа; ";
                        Price += 180;
                    }
                    else if (posission == 3)
                    {
                        Cake += "3 коржа; ";
                        Price += 200;
                    }
                    else if (posission == 4)
                    {
                        Cake += "4 коржа; ";
                        Price += 250;
                    }
                }
            } while (key.Key != ConsoleKey.Escape);
        }

        static void GlazurTorta()
        {
            int posission = 2;
            ConsoleKeyInfo key;

            do
            {
            Console.Clear();
            Console.WriteLine("Выберите желаемую глазурь для торта.");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("   1. Кремовая - 100.");
            Console.WriteLine("   2. Шоколадная - 120.");
            Console.WriteLine("   3. Марципановая - 200.");
            Console.WriteLine("    Нажмите Escape, чтобы вернуться в меню.");

            Console.SetCursorPosition(0, posission);
                Console.WriteLine("->");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow && posission != 2)
                {
                    posission--;
                }
                else if (key.Key == ConsoleKey.DownArrow && posission != 4)
                {
                    posission++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (posission == 2)
                    {
                        Cake += "Кремовая; ";
                        Price += 100;
                    }
                    else if (posission == 3)
                    {
                        Cake += "Шоколадная; ";
                        Price += 120;
                    }
                    else if (posission == 4)
                    {
                        Cake += "Марципановая; ";
                        Price += 200;
                    }

                }

            } while (key.Key != ConsoleKey.Escape);

        }


        static void DekorTorta()
        {
            int posission = 2;
            ConsoleKeyInfo key;

            do
            {
            Console.Clear();
            Console.WriteLine("Выберите желаемый декор для торта.");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("   1. Узоры - 150.");
            Console.WriteLine("   2. Ваш рисунок - 200");
            Console.WriteLine("   3. Фигуры из мастики или марципана - 300");
            Console.WriteLine("   Нажмите Escape, чтобы вернуться в меню.");

            Console.SetCursorPosition(0, posission);
                Console.WriteLine("->");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow && posission != 2)
                {
                    posission--;
                }
                else if (key.Key == ConsoleKey.DownArrow && posission != 4)
                {
                    posission++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (posission == 2)
                    {
                        Cake += "Узоры; ";
                        Price += 150;
                    }
                    else if (posission == 3)
                    {
                        Cake += "Ваш рисунок; ";
                        Price += 200;
                    }
                    else if (posission == 4)
                    {
                        Cake += "Фигурки из мастики и марципана; ";
                        Price += 300;
                    }
                }
            } while (key.Key != ConsoleKey.Escape);
        }    
}