using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    static class Globals
    {
		public static Dictionary<uint, List<int>> line = new Dictionary<uint, List<int>>();
        //Dictionary containing equations to be plotted.
        //
        //Each key represents a color as follows:
        // 0 : black
        // 1 : red
        // 2 : green
        // 3 : blue
        //
        //Each list contains the components of an equation to be plotted, with it's final value representing the equation being used as follows:
        // 0 : y = mx + b (line)
        // 1 : y = ax^2 + bx + c (quadratic)
        // 2 : y = ax^3 + bx^2 + cx + d (cubic)
        // 3 : (x-h)^2 + (y-k)^2 = r^2 (circle)

	}
}

