using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class ServiceRobot : RobotPrototype
    {
        public string ServiceTask;

        public ServiceRobot(string modelName, int batteryCapacity, string softwareVersion, string serviceTask) 
            : base(modelName, batteryCapacity, softwareVersion)
        {
            this.ServiceTask = serviceTask;
        }

        public override RobotPrototype Clone()
        {
            return new ServiceRobot(this.ModelName, this.BatteryCapacity, this.SoftwareVersion, this.ServiceTask);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Service Robot: Model: {ModelName}, Battery Capacity: {BatteryCapacity}h, Software Version: {SoftwareVersion}, Task: {ServiceTask}");
        }
    }
}
