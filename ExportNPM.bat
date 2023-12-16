# Creating Unity NPM Project
ECHO Step 1: Publishing Code for Unity Package
export LOCATION=com.iPAHeartBeat.Core.Abstraction
# rm Unity/Packages/$LOCATION/Runtime/* -r
dotnet publish Src/$LOCATION.csproj -c Release --no-dependencies --framework net471 --output ./Unity/Packages/$LOCATION/Runtime/.

# Removing Extra DLL for Which Code Will available via Unity package registries.
ECHO Step 2: Removing Extra DLLs
rm ./Unity/Packages/$LOCATION/Runtime/Newtonsoft.Json.dll -f

# Create Node package for Unity
ECHO Step 3: Creating Node Package for Unity Package Manager.
cd Unity/Packages/$LOCATION
npm pack --pack-destination="../../../Packages/UnityNPM/"
cd ..
cd ..
cd ..
ECHO Packages are Created.
