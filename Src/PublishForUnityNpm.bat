dotnet publish com.iPAHeartBeat.Core.Abstraction.csproj -c Release --no-dependencies --framework net48 --output ../Unity/Packages/com.iPAHeartBeat.Core.Abstraction/Runtime/.
Rem next line commented as does project does not uses NewtonSoft.Json
Rem del ../Unity\Packages\com.iPAHeartBeat.Core.Abstraction\Runtime\Newtonsoft.Json.dll
