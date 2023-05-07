using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hejgame
{
    internal class settings
    {

        public static int map_size = 5;
        public static int window_size_y = 12;
        public static int window_size_x = 32;

        public static void apply_settings() 
        {

            Console.WindowHeight = window_size_y;
            Console.WindowWidth = window_size_x;

            Console.BufferHeight = window_size_y;
            Console.BufferWidth = window_size_x;
        }
    }
}
