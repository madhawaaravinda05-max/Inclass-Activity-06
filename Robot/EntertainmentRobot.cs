using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class EntertainmentRobot : RobotPrototype
    {
        public string EntertainmentFeature;

        public EntertainmentRobot(string modelName, int batteryCapacity, string softwareVersion, string entertainmentFeature) 
            : base(modelName, batteryCapacity, softwareVersion)
        {
            this.EntertainmentFeature = entertainmentFeature;
        }

        public override RobotPrototype Clone()
        {
            return new EntertainmentRobot(this.ModelName, this.BatteryCapacity, this.SoftwareVersion, this.EntertainmentFeature);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Entertainment Robot: Model: {ModelName}, Battery Capacity: {BatteryCapacity}h, Software Version: {SoftwareVersion}, Feature: {EntertainmentFeature}");
        }
    }
}
