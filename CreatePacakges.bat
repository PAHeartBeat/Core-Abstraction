@REM Build project for Release
ECHO Building project for Release configuration.
dotnet clean Src/. -c Debug
dotnet clean Src/. -c Release
dotnet build Src/. -c Release

@REM Creating NuGet packages
ECHO Creating NuGet Package
dotnet pack Src/. --include-symbols --force -c Release --output ./Packages/NuGet/.

@REM Creating Unity NPM Project
ECHO Step 1: Publishing Code for Unity Package
set location=com.iPAHeartBeat.Core.Abstraction
del ./Unity/Packages/%location%/Runtime/*.*
dotnet publish Src/%location%.csproj -c Release --no-dependencies --framework net471 --output ./Unity/Packages/%location%/Runtime/.

@REM @REM Removing Extra DLL for Which Code Will available via Unity package registries.
@REM ECHO Step 2: Removing Extra DLLs
del Unity/Packages/%location%/Runtime/Newtonsoft.Json.dll

@REM Create Node package for Unity
ECHO Step 3: Creating Node Package for Unity Package Manger.
cd Unity/Packages/%location%
npm pack --pack-destination="../../../Packages/UnityNPM/"
cd ..
cd ..
cd ..
ECHO Packages are Created.
