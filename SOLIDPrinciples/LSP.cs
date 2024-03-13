using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    // The child class must extend the parent class and must not be forced to
    // change behaviour of parent class
    
    public interface IVehicle
    {
        void TurnOnEngine();
        void StartReverseGear();
    } 

    public class Car : IVehicle
    {
        public void TurnOnEngine()
        {

        }

        public void StartReverseGear()
        {

        }
    }

    public class Bike : IVehicle
    {
        public void TurnOnEngine()
        {

        }
        /*
         this is violation of LSP because Bycicle doesnot have reverse gear
        so if program calls Bike.StartReverseGear than there will be error
         */
        public void StartReverseGear()
        {
            throw new NotImplementedException();
        }
    }
}
