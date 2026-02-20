# Change to the script directory
Set-Location $PSScriptRoot

Write-Host "Building ClubMembers Module Package..." -ForegroundColor Green
Write-Host ""

# Build the package project in Release mode
Write-Host "Building project..." -ForegroundColor Cyan
dotnet build -c Release

if ($LASTEXITCODE -ne 0) {
    Write-Host "Build failed!" -ForegroundColor Red
    exit 1
}

# Create the NuGet package
Write-Host "Creating NuGet package..." -ForegroundColor Cyan
dotnet pack -c Release --no-build

if ($LASTEXITCODE -ne 0) {
    Write-Host "Packaging failed!" -ForegroundColor Red
    exit 1
}

Write-Host ""
Write-Host "========================================" -ForegroundColor Green
Write-Host "Package created successfully!" -ForegroundColor Green
Write-Host "========================================" -ForegroundColor Green
Write-Host "Location: ..\..\nupkgs\Oqtane.Modules.ClubMembers.1.0.0.nupkg" -ForegroundColor Cyan
Write-Host ""
Write-Host "To install:" -ForegroundColor Yellow
Write-Host "1. Copy the .nupkg file to your Oqtane site's Packages folder" -ForegroundColor White
Write-Host "   (typically: {ContentRoot}\Packages\)" -ForegroundColor Gray
Write-Host "2. Restart the application (or wait for auto-restart)" -ForegroundColor White
Write-Host "3. The module will be automatically installed and migrations will run" -ForegroundColor White
Write-Host ""

