# Troubleshooting System.Runtime Errors on Linux

If you're getting `System.Runtime, Version=10.0.0.0` errors on Linux, check the following:

## 1. Verify .NET Runtime Version

On your Linux server, check the installed .NET version:

```bash
dotnet --version
```

The module requires **.NET 10.0**. If you have a different version, you need to:
- Install .NET 10.0 runtime on Linux
- Or rebuild the module for your current .NET version

## 2. Check Runtime Installation

Ensure the .NET 10.0 runtime (not just SDK) is installed:

```bash
dotnet --list-runtimes
```

You should see something like:
```
Microsoft.AspNetCore.App 10.0.x [/path/to/runtime]
Microsoft.NETCore.App 10.0.x [/path/to/runtime]
```

## 3. Verify Oqtane Framework Version

The module is built for Oqtane 10.0.3. Ensure your Linux server is running the same Oqtane version.

## 4. Rebuild the Module

If the .NET version matches, try rebuilding the module:

```cmd
cd ModulePackages\ClubMembers
dotnet clean
dotnet build -c Release
dotnet pack -c Release --no-build
```

## 5. Check Application Logs

Check the Oqtane application logs on Linux for more detailed error information about which assembly is failing to load.

## Common Solutions

- **Install .NET 10.0 Runtime**: If missing, install it from https://dotnet.microsoft.com/download
- **Version Mismatch**: If your Oqtane site is running .NET 9.0 or earlier, you'll need to rebuild the module for that version
- **Runtime Path Issues**: Ensure the .NET runtime is in the system PATH


