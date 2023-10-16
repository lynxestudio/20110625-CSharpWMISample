using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using PCProperties.Lib;

namespace PCProperties
{
class Program
{
static void Main(string[] args)
{
PC pc = new PCManager().Select();
Console.WriteLine("\n System Properties");
Console.WriteLine("===============================\n");
Console.WriteLine(" RAM Memory\t[ {0} ]", pc.RamMemory);
Console.WriteLine(" Processor\t[ {0} ]", pc.Processor);
Console.WriteLine(" IP Adrress:\t[ {0} ]", pc.IPAddress);
Console.WriteLine(" OS:\t[ {0} ]\n", pc.OperatingSystem);
Console.WriteLine(" Hard Disk:\t[ {0} ]", pc.HardDisk);
Console.WriteLine(" Monitor:\t[ {0} ]", pc.Monitor);
Console.WriteLine(" Monitor Type:\t[ {0} ]", pc.MonitorType);
Console.WriteLine(" Cdrom:\t[ {0} ]", pc.CdRom);
Console.WriteLine(" Processor Speed:\t[ {0} ]", pc.ProcessorSpeed);

Console.ReadLine();
}
}
}
