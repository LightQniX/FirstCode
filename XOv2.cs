using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO.v_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру:'Крестики - Нолики' !");
            Console.WriteLine("Чтобы начать игру нажмите любую клавишу");
            Console.ReadKey();
            Console.WriteLine("Символ 'I' означает, что поле свободно, и вы можете его использовать в качестве хода");
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
            Console.WriteLine();
            Random rand = new Random();
            char[,] board = new char[3, 3];
            board[0, 0] = 'I'; board[0, 1] = 'I'; board[0, 2] = 'I';
            board[1, 0] = 'I'; board[1, 1] = 'I'; board[1, 2] = 'I';
            board[2, 0] = 'I'; board[2, 1] = 'I'; board[2, 2] = 'I';
            Console.WriteLine("Вот так выглядит ваше поле для игры :");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int k = 0; k < board.GetLength(0); k++)
                {
                    Console.Write(" {0} ", board[i, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Для старта нажмите любую клавишу");
            Console.ReadLine();
            for (int turn = 1, GG = 0; GG == 0; turn++)
            {
                int x = 0, y = 0, FF = 0;
                Console.WriteLine("Ход №" + turn);
                while (FF == 0)/*Ход Игрока*/
                {
                    TurnPlayer(ref x, ref y);
                    if (board[x, y] != 'I')
                    {
                        Console.WriteLine("Эта ячейка занята! Выбирите другую координату.");
                        continue;
                    }
                    else
                    {
                        board[x, y] = 'x';
                    }
                    if ((board[0, 0] == 'x') && (board[0, 1] == 'x') && (board[0, 2] == 'x'))
                    {
                        Console.WriteLine("Поздравляем! Вы одержали победу!");
                        GG++;FF++; board[0, 0] = 'X'; board[0, 1] = 'X'; board[0, 2] = 'X';continue;
                    }
                    else if ((board[1, 0] == 'x') && (board[1, 1] == 'x') && (board[1, 2] == 'x'))
                    {
                        Console.WriteLine("Поздравляем! Вы одержали победу!");
                        GG++; FF++; board[1, 0] = 'X'; board[1, 1] = 'X'; board[1, 2] = 'X';continue;
                    }
                    else if ((board[2, 0] == 'x') && (board[2, 1] == 'x') && (board[2, 2] == 'x'))
                    {
                        Console.WriteLine("Поздравляем! Вы одержали победу!");
                        GG++; FF++; board[2, 0] = 'X'; board[2, 1] = 'X'; board[2, 2] = 'X';continue;
                    }
                    else if ((board[0, 0] == 'x') && (board[1, 0] == 'x') && (board[2, 0] == 'x'))
                    {
                        Console.WriteLine("Поздравляем! Вы одержали победу!");
                        GG++; FF++; board[2, 0] = 'X'; board[2, 1] = 'X'; board[2, 2] = 'X';continue;
                    }
                    else if ((board[0, 1] == 'x') && (board[1, 1] == 'x') && (board[2, 1] == 'x'))
                    {
                        Console.WriteLine("Поздравляем! Вы одержали победу!");
                        GG++; FF++; board[0, 1] = 'X'; board[1, 1] = 'X'; board[2, 1] = 'X';continue;
                    }
                    else if ((board[0, 2] == 'x') && (board[1, 2] == 'x') && (board[2, 2] == 'x'))
                    {
                        Console.WriteLine("Поздравляем! Вы одержали победу!");
                        GG++; FF++; board[0, 2] = 'X'; board[1, 2] = 'X'; board[2, 2] = 'X';continue;
                    }
                    else if ((board[0, 0] == 'x') && (board[1, 1] == 'x') && (board[2, 2] == 'x'))
                    {
                        Console.WriteLine("Поздравляем! Вы одержали победу!");
                        GG++; FF++; board[0, 0] = 'X'; board[1, 1] = 'X'; board[2, 2] = 'X';continue;
                    }
                    else if ((board[2, 0] == 'x') && (board[1, 1] == 'x') && (board[0, 2] == 'x'))
                    {
                        Console.WriteLine("Поздравляем! Вы одержали победу!");
                        GG++; FF++; board[2, 0] = 'X'; board[1, 1] = 'X'; board[0, 2] = 'X'; continue;
                    }
                    else

                    if ((board[0, 0] != 'I') && (board[0, 1] != 'I') && (board[0, 2] != 'I') &&
                        (board[1, 0] != 'I') && (board[1, 1] != 'I') && (board[1, 2] != 'I') &&
                        (board[2, 0] != 'I') && (board[2, 1] != 'I') && (board[2, 2] != 'I'))
                    {
                        Console.WriteLine("Нет свободных ячеек :(");
                        FF++; GG++; break;
                    }
                    else
                        break;
                }//конец while

                while (FF == 0)/*Ход Бота*/
                {
                    int botX = rand.Next(0, 3);
                    int botY = rand.Next(0, 3);

                    if (board[botX, botY] != 'I')
                        continue;
                    else
                        board[botX, botY] = 'o';
                    if ((board[0, 0] == 'o') && (board[0, 1] == 'o') && (board[0, 2] == 'o'))
                    {
                        Console.WriteLine("Вы проиграли! Попробуйте снова!");
                        GG++; FF++; board[0, 0] = 'O'; board[0, 1] = 'O'; board[0, 2] = 'O'; continue;
                    }
                    else if ((board[1, 0] == 'o') && (board[1, 1] == 'o') && (board[1, 2] == 'o'))
                    {
                        Console.WriteLine("Вы проиграли! Попробуйте снова!");
                        GG++; FF++; board[1, 0] = 'O'; board[1, 1] = 'O'; board[1, 2] = 'O'; continue;
                    }
                    else if ((board[2, 0] == 'o') && (board[2, 1] == 'o') && (board[2, 2] == 'o'))
                    {
                        Console.WriteLine("Вы проиграли! Попробуйте снова!");
                        GG++; FF++; board[2, 0] = 'O'; board[2, 1] = 'O'; board[2, 2] = 'O'; continue;
                    }
                    else if ((board[0, 0] == 'o') && (board[1, 0] == 'o') && (board[2, 0] == 'o'))
                    {
                        Console.WriteLine("Вы проиграли! Попробуйте снова!");
                        GG++; FF++; board[0, 0] = 'O'; board[1, 0] = 'O'; board[2, 0] = 'O'; continue;
                    }
                    else if ((board[0, 1] == 'o') && (board[1, 1] == 'o') && (board[2, 1] == 'o'))
                    {
                        Console.WriteLine("Вы проиграли! Попробуйте снова!");
                        GG++; FF++; board[0, 1] = 'O'; board[1, 1] = 'O'; board[2, 1] = 'O'; continue;
                    }
                    else if ((board[0, 2] == 'o') && (board[1, 2] == 'o') && (board[2, 2] == 'o'))
                    {
                        Console.WriteLine("Вы проиграли! Попробуйте снова!");
                        GG++; FF++; board[0, 2] = 'O'; board[1, 2] = 'O'; board[2, 2] = 'O'; continue;
                    }
                    else if ((board[0, 0] == 'o') && (board[1, 1] == 'o') && (board[2, 2] == 'o'))
                    {
                        Console.WriteLine("Вы проиграли! Попробуйте снова!");
                        GG++; FF++; board[0, 0] = 'O'; board[1, 1] = 'O'; board[2, 2] = 'O'; continue;
                    }
                    else if ((board[2, 0] == 'o') && (board[1, 1] == 'o') && (board[0, 2] == 'o'))
                    {
                        Console.WriteLine("Вы проиграли! Попробуйте снова!");
                        GG++; FF++; board[2, 0] = 'O'; board[1, 1] = 'O'; board[0, 2] = 'O'; continue;
                    }
                    else

                    if ((board[0, 0] != 'I') && (board[0, 1] != 'I') && (board[0, 2] != 'I') &&
                        (board[1, 0] != 'I') && (board[1, 1] != 'I') && (board[1, 2] != 'I') &&
                        (board[2, 0] != 'I') && (board[2, 1] != 'I') && (board[2, 2] != 'I'))
                    {
                        Console.WriteLine("Нет свободных ячеек :(");
                        FF++; GG++; break;
                    }
                    else
                        break;
                }//конец while
                Console.WriteLine("Вот ваше итоговое поле:");
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int k = 0; k < board.GetLength(0); k++)
                    {
                        Console.Write(" {0} ", board[i, k]);
                    }
                    Console.WriteLine();
                }
            }//конец игры for
            Console.WriteLine("До скорых встреч!");
            Console.ReadKey();
        }
        //Метод: Ход Игрока
        static int TurnPlayer(ref int x, ref int y)
        {
            Console.WriteLine("Введите какую строку выбираете из цифр: 0, 1, 2");
            int a = Int32.Parse(Console.ReadLine());
            x = a;
            Console.WriteLine("Введите какой столбец выбираете из цифр: 0, 1, 2");
            int b = Int32.Parse(Console.ReadLine());
            y = b;
            return x; return y;
        }
    }
    
       
    
}
