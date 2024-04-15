using System;
using System.Collections.Generic;
using UsbDeviceLib;
using UsbDeviceLib.Model;

namespace UsbDeviceExplorer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Searching for USB devices...");
            Console.WriteLine("");

            try
            {
                List<UsbDriveInfo> usbDrives = UsbDriveSearcher.GetUsbDrives();
                if (usbDrives.Count > 0)
                {
                    int driveCounter = 1;
                    foreach (var drive in usbDrives)
                    {
                        Console.WriteLine($"USB Drive {driveCounter++} Information:");
                        var driveDetails = UsbDriveUtilities.GetUsbDriveInfo(drive);
                        foreach (var detail in driveDetails)
                        {
                            Console.WriteLine(detail);
                        }
                        Console.WriteLine(new string('-', 50)); // Separator
                    }
                    Console.WriteLine("Presenting in Json:");
                    Console.WriteLine(UsbDriveUtilities.GetUsbDrivesAsJson(usbDrives));
                }
                else
                {
                    Console.WriteLine("No USB drives found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}