using LibreHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompTemp
{
    public class ComputerMonitor : IDisposable
    {
        private Computer computer;

        public ComputerMonitor()
        {
            computer = new Computer
            {
                IsCpuEnabled = true, // Enable CPU monitoring
                IsGpuEnabled = true, // Enable CPU monitoring
            };

            computer.Open();
        }

        public float? GetCPUTemperature()
        {
            foreach (var hardwareItem in computer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.Cpu)
                {
                    hardwareItem.Update();
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature && sensor.Name.Contains("Package"))
                        {
                            return sensor.Value;
                        }
                    }
                }
            }
            return null;
        }

        public float? GetGPUTemperature()
        {
            foreach (var hardwareItem in computer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.GpuAmd || hardwareItem.HardwareType == HardwareType.GpuNvidia)
                {
                    hardwareItem.Update();
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            // Adjust this condition to match the name or type of your GPU temperature sensor
                            if (sensor.Name.Contains("Temperature") || sensor.Name.Contains("GPU Core"))
                            {
                                return sensor.Value;
                            }
                        }
                    }
                }
            }

            return null;
        }

        public void Dispose()
        {
            computer.Close();
        }
    }
}
