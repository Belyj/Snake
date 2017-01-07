using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 3, '*');
            point1.Draw();
            Point point2 = new Point(4, 5, '#');
            point2.Draw();
            Point point3 = new Point(7, 10, '%');
            point3.Draw();
            Point point4 = new Point(4, 4, '$');
            point4.Draw();

            List<Point> pList = new List<Point>();
            pList.Add(point1);
            pList.Add(point2);
            pList.Add(point3);
            pList.Add(point4);
            Console.ReadLine();
        }
    }
}
