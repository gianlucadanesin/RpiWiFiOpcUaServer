# RpiWiFiOpcUaServer
This project is meant to host a OpcUa Server on a Raspberry Pi, in order to get access to the WiFi interface connectivity.  
OpcUa has been chosen, as it is commonly available in all major SCADA and HMI systems.  
This way, the SCADA or HMI operator will be able to connect the Rpi WiFi to the internet by using his own mobile phone as an hotspot.  

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
        address 192.168.1.132 (* MODIFY THE ADDRESS AS PREFERRED *)  
        gateway 192.168.1.254 (* MODIFY THE ADDRESS AS PREFERRED *)   
        netmask 255.255.255.0 (* MODIFY THE MASK AS PREFERRED *)   
  
### 4-LAUNCH NET CORE APP:
terminal on app folder  
chmod 755 ./netcoreapp  
./netcoreapp  

## Connecting from a OPC UA Client
For local browsing, use the address:
opc.tcp://localhost:62567/RpiWiFiOpcUaServer

### Tip for Siemens Simatic TIA Advanced
OPC UA Client driver on TIA Advanced requires name resolution.  
For the driver to work, you need to enter the OpcUa server IP address on the host file (On Windows PCs), or
lmhosts registry entries (On Windows CE)  
https://support.microsoft.com/en-us/help/199370/how-to-load-host-entries-into-windows-ce-device