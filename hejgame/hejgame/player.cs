using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hejgame
{

    internal class player
    {

        public static string mark = "P";

        public static int position_x = 2;
        public static int position_y = 2;


        private static int SCORE;
        public static int score
        {
            get { return SCORE; }
            set { SCORE = value; }
        }
    }
}
