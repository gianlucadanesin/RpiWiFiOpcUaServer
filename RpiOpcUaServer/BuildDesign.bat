@echo off
setlocal

REM SET PATH=%PATH%;..\..\..\Scripts;..\..\Bin;..\..\..\Bin

echo Building ModelDesign
Opc.Ua.ModelCompiler.exe -d2 ".\ModelDesign.xml" -cg ".\ModelDesign.csv" -o2 ".\"
echo Success!

copy RpiWiFiOpcUa.Constants.cs ..\Client
copy RpiWiFiOpcUa.DataTypes.cs ..\Client


