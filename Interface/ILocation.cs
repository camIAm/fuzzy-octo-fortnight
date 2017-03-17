using System;
using ConsoleApplication.Models;

namespace ConsoleApplication.Interface{

    public interface ILocation
    {
        double getRadialDistance2D(Point p);
        double getRadialDistance2D(double x, double y);
    }
}