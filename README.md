# JoyRumble.NET

[![ARM64 Debug Build](https://github.com/vertigra/JoyRumble.NET/actions/workflows/dotnet.yml/badge.svg)](https://github.com/vertigra/JoyRumble.NET/actions/workflows/dotnet.yml)

## Install xpad driver in Linux (raspberrypi)

```bash
$ sudo apt-get install raspberrypi-kernel-headers
$ sudo apt-get install dkms 
$ sudo git clone https://github.com/paroj/xpad.git /usr/src/xpad-0.4
$ sudo dkms install -m xpad -v 0.4
```

## Build 

### Linux (ARM64) 

```bash
$ git clone https://github.com/vertigra/JoyRumble.NET.git
$ chmod +x JoyRumble.NET/src/BuildLinuxDebug.sh
$ bash JoyRumble.NET/src/BuildLinuxDebug.sh
```
You will find the results of the build in the directory `JoyRumble.NET/src/bin/LinuxDebug`

### Windows (Visual Studio 2022)
To compile a project in Visual Studio 2022, you need to configure [C++ Remote Debugging](https://learn.microsoft.com/en-us/visualstudio/debugger/remote-debugging-cpp?view=vs-2022) with any Linux device on the ARM64 platform. 
After that, build the project using `VisualStudioDebug` or `VisualStudioRelease` configurations and the `ARM64` platform.

You will find the results of the build in the directory `JoyRumble.NET/src/bin/LinuxDebug`

The resulting program cannot be used on the Windows platform, but it can be used on the Linux (ARM64) platform
