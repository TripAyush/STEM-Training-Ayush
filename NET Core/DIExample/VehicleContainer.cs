using System;
using System.Collections.Generic;
using System.Text;

namespace DIExample
{
    class VehicleContainer
    {
        IDrive drive = null;
        public VehicleContainer(IDrive drive)
        {
            this.drive = drive;
        }

        public void DriveVehicle()
        {
            drive.Drive();
        }
    }
}
