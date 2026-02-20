# ClubMembers Module Package

This folder contains the NuGet package project for the ClubMembers module.

## Building the Package

### Option 1: Using the Build Script (Recommended)

**Windows:**
```cmd
build-package.cmd
```

**PowerShell:**
```powershell
.\build-package.ps1
```

### Option 2: Manual Build

```cmd
cd ModulePackages\ClubMembers
dotnet build -c Release
dotnet pack -c Release --no-build
```

The package will be created at: `..\..\nupkgs\Oqtane.Modules.ClubMembers.1.0.0.nupkg`

## Installing the Package

1. **Copy the package file** to your Oqtane site's `Packages` folder:
   - The Packages folder is typically located at: `{ContentRoot}\Packages`
   - For example: `C:\inetpub\wwwroot\YourSite\Packages\`

2. **Restart the application** (or wait for auto-restart):
   - Oqtane automatically detects new packages in the Packages folder on startup
   - The module will be automatically installed
   - Database migrations will run automatically

3. **Verify installation**:
   - Log into your Oqtane site as Host
   - Go to Admin → Module Definitions
   - You should see "ClubMembers" in the list
   - You can now add the module to any page

## Package Contents

The package includes:
- **lib/net10.0/Oqtane.Modules.ClubMembers.dll** - Compiled module assembly (server + client code)
- **content/Modules/ClubMembers/Client/** - Client-side Razor components, CSS, and services
- **content/Modules/ClubMembers/Server/** - Server-side migrations and repository code
- **content/Modules/ClubMembers/Shared/** - Shared model classes

## Automatic Migration

When the package is installed, Oqtane will:
1. Extract the DLL to the bin folder
2. Extract content files to the appropriate locations
3. Call the `ClubMembersManager.Install()` method
4. Run database migrations automatically
5. Register the module definition

No manual database steps are required!

## Updating the Module

To update the module:
1. Build a new package with an incremented version number
2. Update the `Version` in `ClubMembers.csproj` and `ModuleInfo.cs`
3. Copy the new package to the Packages folder
4. Restart the application
5. Oqtane will detect the version change and run upgrade migrations

## Troubleshooting

- **Module not appearing**: Check that the package was copied to the correct Packages folder and the application was restarted
- **Migration errors**: Check the application logs for detailed error messages
- **Missing files**: Verify the package was built in Release mode and contains all content files

