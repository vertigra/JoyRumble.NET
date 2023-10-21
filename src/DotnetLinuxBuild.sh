#!/usr/bin/env bash
############################################################
# Help                                                     #
############################################################
Help()
{
   # Display Help
   echo "Dotnet project build script for various platforms and configurations."
   echo
   echo "Syntax: DotnetLinuxBuild [-p|c|h]"
   echo "options:"
   echo "-c     biuld configuration. Possible values: LinuxDebug, LinuxRelease. Required."
   echo "-p     build platform. Possible values: ARM, ARM64. Required."
   echo "-h     Print this Help and exit."
   echo
}

#Configuration=""
#Platform=""

while getopts ":c:hp:" option; do
   case $option in
      c) # set configuration
         Configuration=$OPTARG;;
      h) # display Help
         Help
         exit;;
      p) # set platform
         Platform=$OPTARG;;
     \?) # invalid option
         echo "Error: Invalid option"
         exit;;
   esac
done

echo "Build configuration" $Configuration
echo "Build platform" $Platform

# Absolute path this script is in, thus /home/user/bin
SCRIPT_DIR=$( cd -- "$( dirname -- "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )

mv $SCRIPT_DIR/JoyRumble.Native/_project.json $SCRIPT_DIR/JoyRumble.Native/project.json
dotnet build /p:Configuration=$Configuration /p:Platform=$Platform $SCRIPT_DIR/JoyRumble.NET.sln
mv  $SCRIPT_DIR/JoyRumble.Native/project.json  $SCRIPT_DIR/JoyRumble.Native/_project.json
