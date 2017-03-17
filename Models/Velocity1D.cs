using System;

using ConsoleApplication.Interface;

namespace ConsoleApplication.Models
{
    public class Velocity1D : IVelocity
    {
        public double _time;
        public double _initialPosition;
        public double _finalPosition;
        //double velocity;
        public double _displacement;
        public double Time{
            get{return _time;}
            //set{time = value;}
        }
        public double Displacement{
            get {return _displacement;} 
            //set {displacement = value;} //getTotalPositiveLinearDisplacement(initialPosition, finalPosition);}
            }
        public Velocity1D(){}
        public Velocity1D(double time, double initialPostion, double finalPosition){
            _time =time;
            _initialPosition = initialPostion;
            _finalPosition = finalPosition;
        }
        public double getTotalPositiveLinearDisplacement(double initial, double final){
            
            double displacement;
            
            if(final>initial){
                displacement = final - initial;
            }
            else{
                displacement = initial - final;
            }
            return displacement;
        }

        public double getInstantVelocity(double initialPosition, double finalPosition, double time){
            double displacement = getTotalPositiveLinearDisplacement(initialPosition ,finalPosition);
            Console.WriteLine("print displacement:{0}",displacement);
            return getInstantVelocity(displacement, time);
        }
        public double getInstantVelocity(double displacement, double time){
            return displacement/time;
        }
        /*
        public double getInstantVelocity(this Velocity1D v){
            return v.displacement/v.time;
        }
        */
    }
}