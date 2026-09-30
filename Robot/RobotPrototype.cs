using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public abstract class RobotPrototype
    {
        public string ModelName;
        public int BatteryCapacity;
        public string SoftwareVersion;

        public RobotPrototype(string modelName, int batteryCapacity, string softwareVersion)
        {
            this.ModelName = modelName;
            this.BatteryCapacity = batteryCapacity;
            this.SoftwareVersion = softwareVersion;
        }

        public abstract RobotPrototype Clone();
        public abstract void DisplayDetails();
    }
}
