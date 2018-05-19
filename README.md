# RpiWiFiOpcUaServer
This project is meant to give access to the WiFi interface of a Raspberry Pi 3 via Opc UA server interface, which is commonly available in all major SCADA and HMI systems. This way, the SCADA or HMI operator will be able to provide Rpi connectivity by using his own mobile phone as an hotspot.

# NetCore Console App deploying for Arm
dotnet publish -r linux-arm --self-contained -f netcoreapp2.0

# Raspberry Pi Deploy Guideline
Procedures required on Raspberry Pi (Raspian Stretch):

# 1-Install the .NET Core Runtime 2.0
=================================
Run sudo apt-get install curl libunwind8 gettext. This will use the apt-get package manager to install three prerequiste packages.
Run curl -sSL -o dotnet.tar.gz https://dotnetcli.blob.core.windows.net/dotnet/Runtime/release/2.0.0/dotnet-runtime-latest-linux-arm.tar.gz to download the latest .NET Core Runtime for ARM32. This is refereed to as armhf on the Daily Builds page.
Run sudo mkdir -p /opt/dotnet && sudo tar zxf dotnet.tar.gz -C /opt/dotnet to create a destination folder and extract the downloaded package into it.
Run sudo ln -s /opt/dotnet/dotnet /usr/local/bin` to set up a symbolic link...a shortcut to you Windows folks 😉 to the dotnet executable.
Test the installation by typing dotnet --help.

=================================
2-INSTALL NETWORK MANAGER
=================================
sudo apt-get install network-manager

=================================
3-SET STATIC IP FOR LAN and network-manager for Wifi
=================================
modify /etc/network/interfaces

auto lo
iface lo inet loopback

iface eth0 inet static
        address 192.168.1.132
        gateway 192.168.1.254
        netmask 255.255.255.0

=================================
4-LAUNCH NET CORE APP:
=================================
terminal on app folder
chmod 755 ./netcoreapp
./netcoreapp
