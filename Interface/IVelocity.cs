using System;

namespace ConsoleApplication.Interface
{

public interface IVelocity{
 double getTotalPositiveLinearDisplacement(double initial, double final);
double getInstantVelocity(double initialPosition, double finalPosition, double time);
double getInstantVelocity(double displacement, double time);
    }
}