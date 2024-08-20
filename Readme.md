# Easymetering AmiDLL Usage Guide

## Overview

This guide provides instructions on how to use the AmiDLL library for serial communication in C#. The library allows you to open a serial port, perform a handshake, execute read, write, and procedure commands, and close the port when finished.

## Installation

To use the AmiDLL library, include `AmiDLL.dll` in your C# project. Additionally, ensure the following dependency DLLs are included:

-   `BouncyCastle.Cryptography.dll`
-   `Curve25519.dll`
-   `RJCP.SerialPortStream.dll`

Ensure that the `AmiDLL` namespace is referenced in your code.

```csharp
using AmiDLL;
```

## Usage

### Create an Instance

Create an instance of the `EzmAmi` class by providing the serial port name and baud rate.

```csharp
EzmAmi ezmAmi = new EzmAmi(serialPortName, baudrate);
```

### Open Serial Port

Open the serial port to begin communication.

```csharp
ezmAmi.OpenSerialPort();
```

### Perform Handshake

Perform a handshake to establish communication. This step is crucial; without it, no further communication can be established.

```csharp
ezmAmi.DoHandshake();
```

### Execute Read Commands

To perform read commands, use the `Get` prefix. For example, to get the MAC address:

```csharp
ezmAmi.GetMacAddress();
```

### Execute Procedure Commands

To execute procedure commands, use the `Exec` prefix. For example, to switch to boot mode:

```csharp
ezmAmi.ExecBootMode();
```

Some execution commands require parameters. For example, to reset with a delay:

```csharp
ezmAmi.ExecReset(delayInSeconds);
```

### Execute Write Commands

To perform write commands, use the `Set` prefix. These commands always require a parameter. For example, to set the customer password:

```csharp
ezmAmi.SetCustomerPassword(password);
```

### End Session

When you have finished working, use the `ExecEndSession` command to end the session:

```csharp
ezmAmi.ExecEndSession();
```

### Close Serial Port

Finally, close the serial port:

```csharp
ezmAmi.CloseSerialPort();
```

### Error Handling

The methods in the AmiDLL library might throw exceptions if there are communication errors. It is recommended to use try/catch blocks to handle these exceptions:

```csharp
try
{
    ezmAmi.OpenSerialPort();
    ezmAmi.DoHandshake();
    string macAddress = ezmAmi.GetMacAddress();
    ezmAmi.ExecBootMode();
    ezmAmi.ExecReset(10);
    ezmAmi.SetCustomerPassword("09030405060102070800");
    ezmAmi.ExecEndSession();
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}
finally
{
    ezmAmi.CloseSerialPort();
}
```

## Example

Here is a complete example demonstrating the usage of the AmiDLL library:

```csharp
using AmiDLL;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Create instance
            EzmAmi ezmAmi = new EzmAmi("COM3", 9600);

            // Open serial port
            ezmAmi.OpenSerialPort();

            // Perform handshake
            ezmAmi.DoHandshake();

            // Execute read command
            string macAddress = ezmAmi.GetMacAddress();

            // Execute procedure command
            ezmAmi.ExecBootMode();

            // Execute procedure command with parameter
            ezmAmi.ExecReset(10);

            // Execute write command
            ezmAmi.SetCustomerPassword("09030405060102070800");

            // End session
            ezmAmi.ExecEndSession();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            // Close serial port
            ezmAmi.CloseSerialPort();
        }
    }

}
```

## Notes

-   Ensure the serial port name and baud rate are correctly set when creating the `EzmAmi` instance.
-   Always perform the handshake before executing any other commands.
-   Use appropriate prefixes (`Get`, `Exec`, `Set`) for different types of commands.
-   End the session and close the serial port properly to release resources.
-   Handle exceptions using try/catch blocks to manage communication errors.
