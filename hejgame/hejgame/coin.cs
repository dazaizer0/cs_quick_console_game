using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hejgame
{

    internal class coin
    {

        static Random random = new Random();


        public static bool is_active = true;

        public static string mark = "C";

        static int random_position_x = random.Next(-settings.map_size, settings.map_size);
        static int random_position_y = random.Next(-settings.map_size, settings.map_size);
        public static int position_x = random_position_x;
        public static int position_y = random_position_y; 

        public static void position_refresh()
        {

            if (!is_active)
            {

                random_position_x = random.Next(-settings.map_size, settings.map_size);
                random_position_y = random.Next(-settings.map_size, settings.map_size);
                position_x = random_position_x;
                position_y = random_position_y;

                is_active = true;
            }
        }
    }
}
