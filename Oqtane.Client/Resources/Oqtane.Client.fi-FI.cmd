dotnet build -c Release ..\..\Oqtane.sln
mkdir ..\..\Oqtane.Server\bin\Debug\net9.0\fi-FI
copy ..\..\Oqtane.Server\bin\Release\net9.0\fi-FI\Oqtane.Client.resources.dll ..\..\Oqtane.Server\bin\Debug\net9.0\fi-FI\Oqtane.Client.resources.dll
..\..\Oqtane.Package\nuget.exe pack Oqtane.Client.fi-FI.nuspec
pause 

