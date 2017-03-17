using System;
using System.Collections.Generic;
using ConsoleApplication.Models;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double time = 3.0;
            double init = 0.0;
            double final = 9.0;
            Velocity1D velocity = new Velocity1D();
            double vel =velocity.getInstantVelocity(init, final, time);
            Console.WriteLine("velocity:{0}m/s", vel);

            Point p1 = new Point(1,2);
            Console.WriteLine("p1.R:{0}",p1.R);
            Point p2 = new Point(4,4);
            Console.WriteLine("p2.R:{0}",p2.R);
            int result = p1.CompareTo(p2);
            Console.WriteLine("result:{0}", result);
            
            List<Point> pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);
            pointList.Sort();
            foreach(var point in pointList){
                Console.WriteLine(point);
            }
            ObjectProp obj = new ObjectProp(100,40);
            Console.WriteLine("mass: {0}, volume:{1}, density:{2}",obj.Mass, obj.Volume, obj.Density);

        
        }
    }
}
