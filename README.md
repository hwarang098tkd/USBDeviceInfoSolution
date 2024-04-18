# UsbDeviceLib

UsbDeviceLib is a .NET library designed to facilitate easy and efficient management of USB devices on Windows systems. It provides robust tools to retrieve detailed information about connected USB drives, including device names, storage capacity, file systems, and more.

## Features

- **Detect USB Drives**: Automatically identifies all connected removable USB storage devices.
- **Asynchronous Data Retrieval**: Fetches data asynchronously, ensuring non-blocking operations in your applications.
- **Detailed Information**: Extracts detailed information about each device, such as device name, serial number, size, and volume details.
- **Data Serialization**: Supports converting USB drive data into JSON format for easy integration with other applications or for logging purposes.

## Installation

UsbDeviceLib is available as a NuGet package. You can install it using the following methods:

### Via .NET CLI

```bash
dotnet add package UsbDeviceLib
```

## Usage

Here are some examples of how to use UsbDeviceLib to manage USB devices:

List All Connected USB Devices

```csharp
var usbDrives = UsbDriveSearcher.GetUsbDrives();
foreach(var drive in usbDrives)
{
    Console.WriteLine(drive);
}
```

Asynchronous Usage
```csharp
var usbDrives = await UsbDriveSearcher.GetUsbDrivesAsync();
foreach(var drive in usbDrives)
{
    Console.WriteLine(drive);
}
```

Convert USB Drive Information to JSON
```csharp
string jsonOutput = UsbDriveUtilities.GetUsbDrivesAsJson(usbDrives);
Console.WriteLine(jsonOutput);
```

## Contributing
Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are greatly appreciated.

##  Contact
Ntanos David-Vasileios - davidvdanos@gmail.com

Project Link: https://github.com/hwarang098tkd/USBDeviceInfoSolution

## License

[MIT](https://choosealicense.com/licenses/mit/)
