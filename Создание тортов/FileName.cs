namespace Стрелочное_меню
{
    public class Arrow
    {
        public static int Show(int minimum, int maximum)
        {
            {
                int posission = 2;
                ConsoleKeyInfo key;

                do
                {
                    Console.SetCursorPosition(0, posission);
                    Console.WriteLine("->");

                    key = Console.ReadKey();

                    Console.SetCursorPosition(0, posission);
                    Console.WriteLine("  ");

                    if (key.Key == ConsoleKey.UpArrow && posission != 2)
                    {
                        posission--;
                        if (posission == 2)
                        {

                        }
                    }
                    else if (key.Key == ConsoleKey.DownArrow && posission != 8)
                    {
                        posission++;

                    }
                } while (key.Key != ConsoleKey.Enter);
                return posission;
            }
        }
    }




}