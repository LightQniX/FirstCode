using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO
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
            Console.WriteLine();
            int x, y;
            //Ход игрока
            Console.WriteLine("Ваш ход");
            Move1:
            Console.WriteLine("Введите какую строку выбираете из цифр: 0, 1, 2");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите какой столбец выбираете из цифр: 0, 1, 2");
            y = Int32.Parse(Console.ReadLine());

            if (board[x, y] != 'I')
            {
                Console.WriteLine("Эта ячейка занята! Выбирите другую координату.");
                goto Move1;
            }
            else
            {
                goto Next1;
            }
            Next1:
            board[x, y] = 'X';
            //Ход Бота
            Random rand = new Random();
            BotMove1:
            int botx = rand.Next(0,2);
            int boty = rand.Next(0,2);
            if (board[botx, boty] != 'I')
            {   
                goto BotMove1;
            }
            else
            {
                goto BotNext1;
            }
            BotNext1:
            board[botx, boty] = 'O';

            Console.WriteLine("Вот так выглядит ваше поле для игры :");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int k = 0; k < board.GetLength(0); k++)
                {
                    Console.Write(" {0} ", board[i, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //Ход игрока
            Console.WriteLine("Ваш ход");
            Move2:
            Console.WriteLine("Введите какую строку выбираете из цифр: 0, 1, 2");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите какой столбец выбираете из цифр: 0, 1, 2");
            y = Int32.Parse(Console.ReadLine());

            if (board[x, y] != 'I')
            {
                Console.WriteLine("Эта ячейка занята! Выбирите другую координату.");
                goto Move2;
            }
            else
            {
                goto Next2;
            }
            Next2:
            board[x, y] = 'X';
            //Ход Бота
            
            BotMove2:
             botx = rand.Next(0, 2);
             boty = rand.Next(0, 2);
            if (board[botx, boty] != 'I')
            {
                goto BotMove2;
            }
            else
            {
                goto BotNext2;
            }
            BotNext2:
            board[botx, boty] = 'O';

            Console.WriteLine("Вот так выглядит ваше поле для игры :");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int k = 0; k < board.GetLength(0); k++)
                {
                    Console.Write(" {0} ", board[i, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //Ход игрока
            Console.WriteLine("Ваш ход");
            Move3:
            Console.WriteLine("Введите какую строку выбираете из цифр: 0, 1, 2");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите какой столбец выбираете из цифр: 0, 1, 2");
            y = Int32.Parse(Console.ReadLine());

            if (board[x, y] != 'I')
            {
                Console.WriteLine("Эта ячейка занята! Выбирите другую координату.");
                goto Move3;
            }
            else
            {
                goto Next3;
            }
            Next3:
            board[x, y] = 'X';

            if ((board[0, 0] == 'X') && (board[0, 1] == 'X') && (board[0, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[1, 0] == 'X') && (board[1, 1] == 'X') && (board[1, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[2, 0] == 'X') && (board[2, 1] == 'X') && (board[2, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[0, 0] == 'X') && (board[1, 0] == 'X') && (board[2, 0] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[0, 1] == 'X') && (board[1, 1] == 'X') && (board[2, 1] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[0, 2] == 'X') && (board[1, 2] == 'X') && (board[2, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[0, 0] == 'X') && (board[1, 1] == 'X') && (board[2, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[2, 0] == 'X') && (board[1, 1] == 'X') && (board[0, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else
            {
                goto Exit1;
            }
            Exit1:

            //Ход Бота

            BotMove3:
            botx = rand.Next(0, 2);
            boty = rand.Next(0, 2);
            if (board[botx, boty] != 'I')
            {
                goto BotMove3;
            }
            else
            {
                goto BotNext3;
            }
            BotNext3:
            board[botx, boty] = 'O';
            if ((board[0, 0] == 'O') && (board[0, 1] == 'O') && (board[0, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[1, 0] == 'O') && (board[1, 1] == 'O') && (board[1, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[2, 0] == 'O') && (board[2, 1] == 'O') && (board[2, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 0] == 'O') && (board[1, 0] == 'O') && (board[2, 0] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 1] == 'O') && (board[1, 1] == 'O') && (board[2, 1] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 2] == 'O') && (board[1, 2] == 'O') && (board[2, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 0] == 'O') && (board[1, 1] == 'O') && (board[2, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[2, 0] == 'O') && (board[1, 1] == 'O') && (board[0, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else
            {
                goto ExitBot1;
            }
            ExitBot1:
            Console.WriteLine("Вот так выглядит ваше поле для игры :");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int k = 0; k < board.GetLength(0); k++)
                {
                    Console.Write(" {0} ", board[i, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //Ход игрока
            Console.WriteLine("Ваш ход");
            Move4:
            Console.WriteLine("Введите какую строку выбираете из цифр: 0, 1, 2");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите какой столбец выбираете из цифр: 0, 1, 2");
            y = Int32.Parse(Console.ReadLine());

            if (board[x, y] != 'I')
            {
                Console.WriteLine("Эта ячейка занята! Выбирите другую координату.");
                goto Move4;
            }
            else
            {
                goto Next4;
            }
            Next4:
            board[x, y] = 'X';

            if ((board[0, 0] == 'X') && (board[0, 1] == 'X') && (board[0, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[1, 0] == 'X') && (board[1, 1] == 'X') && (board[1, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[2, 0] == 'X') && (board[2, 1] == 'X') && (board[2, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[0, 0] == 'X') && (board[1, 0] == 'X') && (board[2, 0] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[0, 1] == 'X') && (board[1, 1] == 'X') && (board[2, 1] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[0, 2] == 'X') && (board[1, 2] == 'X') && (board[2, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[0, 0] == 'X') && (board[1, 1] == 'X') && (board[2, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[2, 0] == 'X') && (board[1, 1] == 'X') && (board[0, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else
            {
                goto Exit2;
            }
            Exit2:
            //Ход Бота

            BotMove4:
            botx = rand.Next(0, 2);
            boty = rand.Next(0, 2);
            if (board[botx, boty] != 'I')
            {
                goto BotMove4;
            }
            else
            {
                goto BotNext4;
            }
            BotNext4:
            board[botx, boty] = 'O';
            if ((board[0, 0] == 'O') && (board[0, 1] == 'O') && (board[0, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[1, 0] == 'O') && (board[1, 1] == 'O') && (board[1, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[2, 0] == 'O') && (board[2, 1] == 'O') && (board[2, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 0] == 'O') && (board[1, 0] == 'O') && (board[2, 0] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 1] == 'O') && (board[1, 1] == 'O') && (board[2, 1] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 2] == 'O') && (board[1, 2] == 'O') && (board[2, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 0] == 'O') && (board[1, 1] == 'O') && (board[2, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[2, 0] == 'O') && (board[1, 1] == 'O') && (board[0, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else
            {
                goto ExitBot2;
            }
            ExitBot2:
            Console.WriteLine("Вот так выглядит ваше поле для игры :");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int k = 0; k < board.GetLength(0); k++)
                {
                    Console.Write(" {0} ", board[i, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Ход игрока
            Console.WriteLine("Ваш ход");
            Move5:
            Console.WriteLine("Введите какую строку выбираете из цифр: 0, 1, 2");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите какой столбец выбираете из цифр: 0, 1, 2");
            y = Int32.Parse(Console.ReadLine());

            if (board[x, y] != 'I')
            {
                Console.WriteLine("Эта ячейка занята! Выбирите другую координату.");
                goto Move5;
            }
            else
            {
                goto Next5;
            }
            Next5:
            board[x, y] = 'X';

            if ((board[0, 0] == 'X') && (board[0, 1] == 'X') && (board[0, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[1, 0] == 'X') && (board[1, 1] == 'X') && (board[1, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[2, 0] == 'X') && (board[2, 1] == 'X') && (board[2, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[0, 0] == 'X') && (board[1, 0] == 'X') && (board[2, 0] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[0, 1] == 'X') && (board[1, 1] == 'X') && (board[2, 1] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[0, 2] == 'X') && (board[1, 2] == 'X') && (board[2, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[0, 0] == 'X') && (board[1, 1] == 'X') && (board[2, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[2, 0] == 'X') && (board[1, 1] == 'X') && (board[0, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else
            {
                goto Exit3;
            }
            Exit3:
            //Ход Бота

            BotMove5:
            botx = rand.Next(0, 2);
            boty = rand.Next(0, 2);
            if (board[botx, boty] != 'I')
            {
                goto BotMove5;
            }
            else
            {
                goto BotNext5;
            }
            BotNext5:
            board[botx, boty] = 'O';
            if ((board[0, 0] == 'O') && (board[0, 1] == 'O') && (board[0, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[1, 0] == 'O') && (board[1, 1] == 'O') && (board[1, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[2, 0] == 'O') && (board[2, 1] == 'O') && (board[2, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 0] == 'O') && (board[1, 0] == 'O') && (board[2, 0] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 1] == 'O') && (board[1, 1] == 'O') && (board[2, 1] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 2] == 'O') && (board[1, 2] == 'O') && (board[2, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 0] == 'O') && (board[1, 1] == 'O') && (board[2, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[2, 0] == 'O') && (board[1, 1] == 'O') && (board[0, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else
            {
                goto ExitBot3;
            }
            ExitBot3:
            Console.WriteLine("Вот так выглядит ваше поле для игры :");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int k = 0; k < board.GetLength(0); k++)
                {
                    Console.Write(" {0} ", board[i, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //Ход игрока
            Console.WriteLine("Ваш ход");
            Move6:
            Console.WriteLine("Введите какую строку выбираете из цифр: 0, 1, 2");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите какой столбец выбираете из цифр: 0, 1, 2");
            y = Int32.Parse(Console.ReadLine());

            if (board[x, y] != 'I')
            {
                Console.WriteLine("Эта ячейка занята! Выбирите другую координату.");
                goto Move6;
            }
            else
            {
                goto Next6;
            }
            Next6:
            board[x, y] = 'X';

            if ((board[0, 0] == 'X') && (board[0, 1] == 'X') && (board[0, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[1, 0] == 'X') && (board[1, 1] == 'X') && (board[1, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[2, 0] == 'X') && (board[2, 1] == 'X') && (board[2, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[0, 0] == 'X') && (board[1, 0] == 'X') && (board[2, 0] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[0, 1] == 'X') && (board[1, 1] == 'X') && (board[2, 1] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[0, 2] == 'X') && (board[1, 2] == 'X') && (board[2, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[0, 0] == 'X') && (board[1, 1] == 'X') && (board[2, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else if ((board[2, 0] == 'X') && (board[1, 1] == 'X') && (board[0, 2] == 'X'))
            {
                Console.WriteLine("Поздравляем! Вы одержали победу!");
                goto End;
            }
            else
            {
                goto Exit4;
            }
            Exit4:
            BotMove6:
            botx = rand.Next(0, 2);
            boty = rand.Next(0, 2);
            if (board[botx, boty] != 'I')
            {
                goto BotMove6;
            }
            else
            {
                goto BotNext6;
            }
            BotNext6:
            board[botx, boty] = 'O';
            if ((board[0, 0] == 'O') && (board[0, 1] == 'O') && (board[0, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[1, 0] == 'O') && (board[1, 1] == 'O') && (board[1, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[2, 0] == 'O') && (board[2, 1] == 'O') && (board[2, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 0] == 'O') && (board[1, 0] == 'O') && (board[2, 0] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 1] == 'O') && (board[1, 1] == 'O') && (board[2, 1] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 2] == 'O') && (board[1, 2] == 'O') && (board[2, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 0] == 'O') && (board[1, 1] == 'O') && (board[2, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[2, 0] == 'O') && (board[1, 1] == 'O') && (board[0, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else
            {
                goto ExitBot4;
            }
            ExitBot4:
            Console.WriteLine("Вот так выглядит ваше поле для игры :");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int k = 0; k < board.GetLength(0); k++)
                {
                    Console.Write(" {0} ", board[i, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            if ((board[0, 0] != 'I') && (board[0, 1] != 'I') && (board[0, 2] != 'I') &&
                (board[1, 0] != 'I') && (board[1, 1] != 'I') && (board[1, 2] != 'I') &&
                (board[2, 0] != 'I') && (board[2, 1] != 'I') && (board[2, 2] != 'I'))
            {
                Console.WriteLine("Нет свободных ячеек :(");
                goto End;
            }
            else
            {
                goto continue1;
            }
            continue1:
            //Ход Бота

            BotMove7:
            botx = rand.Next(0, 2);
            boty = rand.Next(0, 2);
            if (board[botx, boty] != 'I')
            {
                goto BotMove7;
            }
            else
            {
                goto BotNext7;
            }
            BotNext7:
            board[botx, boty] = 'O';
            if ((board[0, 0] == 'O') && (board[0, 1] == 'O') && (board[0, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[1, 0] == 'O') && (board[1, 1] == 'O') && (board[1, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[2, 0] == 'O') && (board[2, 1] == 'O') && (board[2, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 0] == 'O') && (board[1, 0] == 'O') && (board[2, 0] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 1] == 'O') && (board[1, 1] == 'O') && (board[2, 1] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 2] == 'O') && (board[1, 2] == 'O') && (board[2, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[0, 0] == 'O') && (board[1, 1] == 'O') && (board[2, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else if ((board[2, 0] == 'O') && (board[1, 1] == 'O') && (board[0, 2] == 'O'))
            {
                Console.WriteLine("Вы проиграли! Попробуйте снова!");
                goto End;
            }
            else
            {
                goto ExitBot5;
            }
            ExitBot5:
            Console.WriteLine("Вот так выглядит ваше поле для игры :");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int k = 0; k < board.GetLength(0); k++)
                {
                    Console.Write(" {0} ", board[i, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            if ((board[0, 0] != 'I') && (board[0, 1] != 'I') && (board[0, 2] != 'I') &&
                (board[1, 0] != 'I') && (board[1, 1] != 'I') && (board[1, 2] != 'I') &&
                (board[2, 0] != 'I') && (board[2, 1] != 'I') && (board[2, 2] != 'I'))
            {
                Console.WriteLine("Нет свободных ячеек :(");
                goto End;
            }
            else
            {
                goto continue2;
            }
            continue2:

            End:
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int k = 0; k < board.GetLength(0); k++)
                {
                    Console.Write(" {0} ", board[i, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("Увидимся!");
        }

    }
}
