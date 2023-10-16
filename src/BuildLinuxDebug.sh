#!/bin/sh
mv JoyRumble.Native/_project.json JoyRumble.Native/project.json
dotnet build /p:Configuration=LinuxDebug JoyRumble.NET.sln
mv JoyRumble.Native/project.json JoyRumble.Native/_project.json