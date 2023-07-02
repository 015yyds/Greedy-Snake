﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贪吃蛇
{
    struct Position
    {
        public int x,y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator == (Position p1, Position p2)
        {
            if(p1.x==p2.x && p1.y==p2.y)
            {
                return true;
            }
            return false;
        }

        public static bool operator != (Position p1, Position p2)
        {
            if (p1.x == p2.x && p1.y == p2.y)
            {
                return false;
            }
            return true;
        }
    }
}
