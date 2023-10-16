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
