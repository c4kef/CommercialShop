SET pathToMT=C:\Program Files (x86)\Windows Kits\10\bin\10.0.19041.0\x64
SET pathToManifest=D:\Projects\CommercialShop\Client\app1.manifest
SET pathToExe=D:\Projects\CommercialShop\Build\Compiled\C4ke.exe

cd /D C:\
cd %pathToMT%
mt.exe -nologo -manifest "%pathToManifest%" -outputresource:"%pathToExe%;#1"