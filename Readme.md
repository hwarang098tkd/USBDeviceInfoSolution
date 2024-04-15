# UsbDeviceLib

`UsbDeviceLib` is a .NET class library that provides detailed information about connected USB drives on a Windows system. This library utilizes Windows Management Instrumentation (WMI) to gather data on USB drives, including device names, storage capacity, file systems, and more.

## Features

- **Device Discovery**: List all connected USB drives.
- **Volume Information**: Get detailed info about each volume on the USB drives.
- **Asynchronous API**: Provides asynchronous methods for performing IO operations that won't block your main thread.
- **JSON Output**: Ability to serialize USB drive information into JSON for easy integration with other systems or for reporting purposes.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- .NET Framework 4.8
- Newtonsoft.Json 12.0.3 or higher

### Installing

To use `UsbDeviceLib` in your project, follow these simple steps:

1. Install the package via NuGet:

   ```bash
   Install-Package UsbDeviceLib -Version x.x.x

### Usage
Below are some examples of how to use UsbDeviceLib:
```
// Listing USB Drives
var usbDrives = UsbDriveSearcher.GetUsbDrives();
foreach(var drive in usbDrives)
{
    Console.WriteLine(drive);
}

// Asynchronous Usage
var usbDrivesAsync = await UsbDriveSearcher.GetUsbDrivesAsync();
foreach(var drive in usbDrivesAsync)
{
    Console.WriteLine(drive);
}

// Getting JSON Representation
string jsonOutput = UsbDriveUtilities.GetUsbDrivesAsJson(usbDrives);
Console.WriteLine(jsonOutput);

