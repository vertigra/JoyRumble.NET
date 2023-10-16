#!/usr/bin/env bash

# Absolute path this script is in, thus /home/user/bin
SCRIPT_DIR=$( cd -- "$( dirname -- "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )

mv $SCRIPT_DIR/JoyRumble.Native/_project.json $SCRIPT_DIR/JoyRumble.Native/project.json
dotnet build /p:Configuration=LinuxDebug $SCRIPT_DIR/JoyRumble.NET.sln
mv  $SCRIPT_DIR/JoyRumble.Native/project.json  $SCRIPT_DIR/JoyRumble.Native/_project.json