using System;
using ConsoleApplication.Interface;

namespace ConsoleApplication.Models
{
    public class ObjectProp : IMassProperty
    {
        double mass, volume, density;
        public double Mass {get{return mass;} set{ mass = value;}}
        public double Volume { get{return volume;} set{ volume = value;}}
        public double Density { get{ return density;} set{ density = value;}}
        public ObjectProp(){}
        public ObjectProp(double volume, double density){
            this.volume = volume;
            this.density = density;
            this.mass = getMass(volume, density);
        }
        public double getMass(double volume, double density){
            return volume*density;
        }
        public override string ToString(){
            return mass.ToString()+ "kg ," + volume.ToString() + "m^3,"+ density.ToString()+ "kg/m^3";
        }
    }
}