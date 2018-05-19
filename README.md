# RpiWiFiOpcUaServer
This project is meant to give access to the WiFi interface of a Raspberry Pi 3 via Opc UA server interface, which is commonly available in all major SCADA and HMI systems. This way, the SCADA or HMI operator will be able to provide Rpi connectivity by using his own mobile phone as an hotspot.

## NetCore Console App deploying for Arm
dotnet publish -r linux-arm --self-contained -f netcoreapp2.0

## Raspberry Pi Deploy Guideline
Procedures to be performed on the Raspberry Pi (Raspian Stretch)

### 1-Install the .NET Core Runtime 2.0
See the tutorial below for the installation of the Net Core Runtime in the Raspberry Pi
https://blogs.msdn.microsoft.com/david/2017/07/20/setting_up_raspian_and_dotnet_core_2_0_on_a_raspberry_pi/

### 2-INSTALL NETWORK MANAGER
sudo apt-get install network-manager

### 3-SET STATIC IP FOR LAN and network-manager for Wifi
modify /etc/network/interfaces

auto lo
iface lo inet loopback

iface eth0 inet static
        address 192.168.1.132
        gateway 192.168.1.254
        netmask 255.255.255.0

### 4-LAUNCH NET CORE APP:
terminal on app folder
chmod 755 ./netcoreapp
./netcoreapp
