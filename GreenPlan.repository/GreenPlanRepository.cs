using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenPlan.repository
{
    public class GreenPlanRepository
    {
        //DB



        //Create



        //Read



        //Update



        //Delete



        //Seed Data Method

        public void SeedCarData()
        {
            Car = new Car ("Ford", "MaverickXLT", 2022, Color.Silver, 29, BodyStyle.PickupTruck, Transmission.automatic, 4, 36944, Drivetrain.AllWheelDrive, FuelType.Gasoline );
        }
    }
}