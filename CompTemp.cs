using System.Management;
using LibreHardwareMonitor.Hardware;
using CompTemp;
using System;
using System.Timers;
using System.Windows.Forms;

namespace CompTemp
{
    public partial class CompTemp : Form
    {

        private ComputerMonitor monitor;

        private System.Timers.Timer timer;

        public CompTemp()
        {
            InitializeComponent();

            monitor = new ComputerMonitor();
            UpdateCompTemperature();

            timer = new System.Timers.Timer();

            timer.Interval = 500;

            timer.Elapsed += TimerElapsed;

            timer.Start();

            string cpuInfo = null;
            string cpuInfo1 = null;
            string cpuInfo2 = null;
            string mbInfo = null;
            string mbInfo1 = null;
            string gpuInfo = null;
            string ramInfo = null;
            string ramInfo1 = null;
            string ramInfo2 = null;

            var cpu = new ManagementObjectSearcher("Select * from Win32_Processor");
            var motherboard = new ManagementObjectSearcher("select * from Win32_BaseBoard");
            var gpu = new ManagementObjectSearcher("select * from Win32_VideoController");
            var ram = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");

            foreach (var obj in cpu.Get())
            {
                ulong capacity = Convert.ToUInt64(obj["NumberOfCores"]);
                ulong threadCount = Convert.ToUInt64(obj["ThreadCount"]);
                cpuInfo = (string)obj["Name"];
                cpuInfo1 += $"{capacity}";
                cpuInfo2 += $"{threadCount}";
            }

            foreach (var obj in motherboard.Get())
            {
                mbInfo = (string)obj["Product"];
                mbInfo1 = (string)obj["Manufacturer"];
            }

            foreach (var obj in gpu.Get())
            {
                gpuInfo = (string)obj["VideoProcessor"];
            }

            foreach (var obj in ram.Get())
            {
                ulong capacity = Convert.ToUInt64(obj["Capacity"]);
                ulong capacityGB = capacity / (1024 * 1024 * 1024);
                ramInfo1 += $"{capacityGB} GB\n ";
                ramInfo += $"{obj["Manufacturer"]}\n ";
                ramInfo2 += $"{obj["Speed"]} MHz\n\n ";
            }

            txtModel.Text = cpuInfo;
            txtCore.Text = cpuInfo1;
            txtThread.Text = cpuInfo2;
            txtMotherboard.Text = mbInfo;
            txtMakeMB.Text = mbInfo1;
            txtGpu.Text = gpuInfo;
            txtRam1.Text = ramInfo;
            txtRam2.Text = ramInfo1;
            txtRam3.Text = ramInfo2;
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            UpdateCompTemperature();
        }

        private void UpdateCompTemperature()
        {
            float? temperature = monitor.GetCPUTemperature();
            float? gpuTemp = monitor.GetGPUTemperature();

            if (temperature.HasValue)
            {
                txtGpuTemp.Text = gpuTemp.Value.ToString();
                txtCpuTemp.Text = temperature.Value.ToString();
            }
            else
            {
                txtGpuTemp.Text = "N/A";
                txtCpuTemp.Text = "N/A";
            }
        }


        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fileReload_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}
