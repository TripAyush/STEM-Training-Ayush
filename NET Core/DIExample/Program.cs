using System;

namespace DIExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Without DI
            /*Bike bike = new Bike();
            bike.Drive();
            Car car = new Car();
            car.Drive();
            Bus bus = new Bus();
            bus.Drive();*/

            //Dependency Injection
            VehicleContainer vc = null;
            vc = new VehicleContainer(new Bike());
            vc.DriveVehicle();
            vc = new VehicleContainer(new Car());
            vc.DriveVehicle();
        }
    }
}
