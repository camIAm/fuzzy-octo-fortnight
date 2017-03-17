using System;
using System.Collections.Generic;

using ConsoleApplication.Interface;

namespace ConsoleApplication.Models
{
    public class Point : IComparable<Point>, IComparable, ILocation
    {
        public double x,y,r;
        public double X{
            get{ return x; }
            set{ x = value;}
        }
        public double Y{
            get{ return y; }
            set{ y = value;}
        }
        public double R{
            get{ return r; }
            set{ r = getRadialDistance2D(x,y);}
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            this.r = getRadialDistance2D(x,y);    
        }
  
        public int CompareTo(Point other){ // generic IComparable<Point>
            if(Equals(other)) return 0;
            Console.WriteLine("r:{0}    other.r:{1}",r,other.r);
            return r.CompareTo(other.r);
        }

        public int CompareTo(object other){
            if(!(other is Point)){
                throw new InvalidOperationException("CompareTo: Not a note");
            }
            return(CompareTo((Point)other));
        }
        public double getRadialDistance2D(double x, double y)
        {
            return Math.Sqrt((x*x)+(y*y));
        }
        public double getRadialDistance2D(Point p)
        {
            double radialDistance = getRadialDistance2D(p.x, p.y);
            return radialDistance;
        }
        public override string ToString()
        {
            return this.X.ToString() + "," + this.Y.ToString();
        }

    }
}