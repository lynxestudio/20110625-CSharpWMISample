using System;
using System.Management;
namespace PCProperties.Lib {
public class PCManager {
    static ManagementObjectSearcher searcher = null;
    PC pcomputer = null;
public PCManager() { searcher = new ManagementObjectSearcher(); }
public PC Select() {
    pcomputer = new PC();
    searcher.Query = new ObjectQuery("Select * from Win32_DesktopMonitor");
    ManagementObjectCollection coll = searcher.Get();
    foreach (ManagementObject objmng in coll) {
    pcomputer.Monitor = objmng["MonitorManufacturer"].ToString();
    pcomputer.MonitorType = objmng["Name"].ToString();
    }            
    searcher.Query = new ObjectQuery("Select * from Win32_OperatingSystem");
    coll = searcher.Get();
    foreach (ManagementObject objmng in coll){
    pcomputer.RamMemory = objmng["TotalVisibleMemorySize"].ToString() + "Mb";
    pcomputer.OperatingSystem = objmng["Name"].ToString();
    pcomputer.OperatingSystemVersion = objmng["Version"].ToString();
    }
    searcher.Query = new ObjectQuery("Select * from Win32_DiskDrive");
    coll = searcher.Get();
    foreach (ManagementObject objmng in coll)
    pcomputer.HardDisk = (Convert.ToDouble(objmng["Size"]) 
        / 1024000).ToString() + "Mb";
    searcher.Query = new ObjectQuery("Select * from Win32_CDROMDrive");
    coll = searcher.Get();
    foreach (ManagementObject objmng in coll)
    pcomputer.CdRom = objmng["Name"].ToString();
    searcher.Query = new ObjectQuery("Select * from Win32_Processor");
    coll = searcher.Get();
    foreach (ManagementObject objmng in coll){
    pcomputer.ProcessorSpeed = objmng["MaxClockSpeed"].ToString();
    pcomputer.Processor = objmng["Name"].ToString();
    }
    searcher.Query = new ObjectQuery("Select * from Win32_NetworkAdapterConfiguration");
    coll = searcher.Get();
    foreach (ManagementObject objmng in coll){
    if (!string.IsNullOrEmpty(pcomputer.MacAddress) &&
    !string.IsNullOrEmpty(pcomputer.IPAddress)){
    pcomputer.MacAddress = objmng["MacAddress"].ToString();
    pcomputer.IPAddress = ((string[])(objmng["IPAddress"]))[0];
    }
}
return pcomputer;   
        }
    }
}