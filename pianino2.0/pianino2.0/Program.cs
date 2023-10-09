using System;

namespace Programm
{
    class ConsolePiano
    {
        static int[] PervaOcktava = new int[] { 2093, 2217, 2349, 2489, 2637 };
        static int[] VtoraOcktava = new int[] { 4186, 4435, 4699, 4978, 5274 };

        static int OcktavaGhz = 1;
        static void Main()
        {

            Console.WriteLine("Переключение между Октавами F1-F2");
            Console.WriteLine("Клавишы воспризведения: Q_A_Z_W_S_X");
            ConsoleKey key = Console.ReadKey().Key;

            while (key != ConsoleKey.Escape)
            {
                if (key == ConsoleKey.F1)
                {
                    Console.WriteLine("Октава 7");
                    OcktavaGhz = 1;
                    AudioSoundUser(key);
                }
                if (key == ConsoleKey.F2)
                {
                    Console.WriteLine("Октава 8");
                    OcktavaGhz = 2;
                    AudioSoundUser(key);
                }

                key = Console.ReadKey().Key;
                AudioSoundUser(key);
                Console.Clear();
            }
        }

        public static void AudioSoundUser(ConsoleKey bind)
        {
            switch (bind)
            {
                case ConsoleKey.Q:
                    if (OcktavaGhz == 1) Console.Beep(PervaOcktava[0], 300);
                    if (OcktavaGhz == 2) Console.Beep(VtoraOcktava[0], 300);
                    break;
                case ConsoleKey.A:
                    if (OcktavaGhz == 1) Console.Beep(PervaOcktava[1], 300);
                    if (OcktavaGhz == 2) Console.Beep(VtoraOcktava[1], 300);
                    break;
                case ConsoleKey.Z:
                    if (OcktavaGhz == 1) Console.Beep(PervaOcktava[2], 300);
                    if (OcktavaGhz == 2) Console.Beep(VtoraOcktava[2], 300);
                    break;
                case ConsoleKey.W:
                    if (OcktavaGhz == 1) Console.Beep(PervaOcktava[3], 300);
                    if (OcktavaGhz == 2) Console.Beep(VtoraOcktava[3], 300);
                    break;
                case ConsoleKey.S:
                    if (OcktavaGhz == 1) Console.Beep(PervaOcktava[4], 300);
                    if (OcktavaGhz == 2) Console.Beep(VtoraOcktava[4], 300);
                    break;
                case ConsoleKey.X:
                    if (OcktavaGhz == 1) Console.Beep(PervaOcktava[4], 300);
                    if (OcktavaGhz == 2) Console.Beep(VtoraOcktava[4], 300);
                    break;
            }
        }
    }

}