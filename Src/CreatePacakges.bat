Rem Build project for Realase
ECHO Building project for Release configuration.
dotnet build -c Release

Rem Creating NuGet packages
ECHO Creating NuGet Package
dotnet pack --include-symbols --force -c Release --output ../Packages/NuGet/.

Rem Creating Unity NPM Project
ECHO Step 1: Publishing Code for Unity Package
dotnet publish com.iPAHeartBeat.Core.Abstraction.csproj -c Release --no-dependencies --framework net48 --output ../Unity/Packages/com.iPAHeartBeat.Core.Abstraction/Runtime/.

Rem Removing Extra DLL for Which Code Will avaialble via Unity package registries.
Rem ECHO Step 2: Removing Extra DLLs
Rem next line commented as does project does not uses NewtonSoft.Json
Rem del ../Unity\Packages\com.iPAHeartBeat.Core.Abstraction\Runtime\Newtonsoft.Json.dll
