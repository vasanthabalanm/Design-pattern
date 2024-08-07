﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public  class Car_Factory : Vehicle_Factory
    {
        public override Vehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
