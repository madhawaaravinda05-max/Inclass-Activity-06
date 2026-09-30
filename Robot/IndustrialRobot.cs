using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class IndustrialRobot : RobotPrototype
    {
        public string IndustrialTask;

        public IndustrialRobot(string modelName, int batteryCapacity, string softwareVersion, string industrialTask) 
            : base(modelName, batteryCapacity, softwareVersion)
        {
            this.IndustrialTask = industrialTask;
        }

        public override RobotPrototype Clone()
        {
            return new IndustrialRobot(this.ModelName, this.BatteryCapacity, this.SoftwareVersion, this.IndustrialTask);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Industrial Robot: Model: {ModelName}, Battery Capacity: {BatteryCapacity}h, Software Version: {SoftwareVersion}, Task: {IndustrialTask}");
        }
    }
}
