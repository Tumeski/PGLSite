@echo off
echo Building ClubMembers Module Package...
echo.

REM Change to the script directory
cd /d "%~dp0"

REM Build the package project in Release mode
echo Building project...
dotnet build -c Release
if errorlevel 1 (
    echo Build failed!
    pause
    exit /b 1
)

REM Create the NuGet package
echo Creating NuGet package...
dotnet pack -c Release --no-build
if errorlevel 1 (
    echo Packaging failed!
    pause
    exit /b 1
)

echo.
echo ========================================
echo Package created successfully!
echo ========================================
echo Location: ..\..\nupkgs\Oqtane.Modules.ClubMembers.1.0.0.nupkg
echo.
echo To install:
echo 1. Copy the .nupkg file to your Oqtane site's Packages folder
echo    (typically: {ContentRoot}\Packages\)
echo 2. Restart the application (or wait for auto-restart)
echo 3. The module will be automatically installed and migrations will run
echo.
pause

