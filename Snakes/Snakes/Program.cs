using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine Upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine Downline = new HorizontalLine(0, 78, 24, '+');
            VertikalLine Leftline = new VertikalLine(0, 24, 0, '+');
            VertikalLine Rightline = new VertikalLine(0, 24, 78, '+');
            Upline.Drow();
            Downline.Drow();
            Rightline.Drow();
            Leftline.Drow();

            Point p2 = new Point(4, 5, '*');           
            p2.Draw();
          
            Console.ReadLine();
        }
    }
}
