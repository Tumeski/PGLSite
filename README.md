# Oqtane Framework

![Oqtane](https://github.com/oqtane/framework/blob/master/oqtane.png?raw=true "Oqtane")

Oqtane is an open source Content Management System (CMS) and Application Framework that provides advanced functionality for developing web, mobile, and desktop applications on modern .NET. 

Oqtane allows you to "Build Applications, Not Infrastructure" which means that you can focus your efforts on solving your unique business challenges rather than wasting time and effort on building general infrastructure. 

Oqtane is "Rocket Fuel for Blazor" as it provides powerful capabilities to accelerate your Blazor development experience, providing scalable services and a composable UI which can be hosted on Static Blazor, Blazor Server, Blazor WebAssembly, or Blazor Hybrid (via .NET MAUI).

Oqtane is being developed based on some fundamental principles which are outlined in the [Oqtane Philosophy](https://www.oqtane.org/blog/!/20/oqtane-philosophy). This project is an official member of the .NET Foundation and is governed by the **[.NET Foundation Contributor Covenant Code of Conduct](https://dotnetfoundation.org/code-of-conduct)**

# Latest Release

[6.1.3](https://github.com/oqtane/oqtane.framework/releases/tag/v6.1.3) was released on May 29, 2025 and is a maintenance release including 59 pull requests by 5 different contributors, pushing the total number of project commits all-time to over 6600. The Oqtane framework continues to evolve at a rapid pace to meet the needs of .NET developers.

# Try It Now!

Microsoft's Public Cloud (requires an Azure account)  
[![Deploy to Azure](https://aka.ms/deploytoazurebutton)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Foqtane%2Foqtane.framework%2Fdev%2Fazuredeploy.json) 

A free ASP.NET hosting account. No hidden fees. No credit card required.  
[![Deploy to MonsterASP.NET](https://www.oqtane.org/files/Public/MonsterASPNET.png)](https://www.monsterasp.net/) 

# Getting Started (Version 6)

**Installing using source code from the Dev/Master branch:**

- Install **[.NET 9.0.5 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)**.

- Install the latest edition (v17.12 or higher) of [Visual Studio 2022](https://visualstudio.microsoft.com/downloads) with the **ASP.NET and web development** workload enabled. Oqtane works with ALL editions of Visual Studio from Community to Enterprise. If you wish to use LocalDB for development ( not a requirement as Oqtane supports SQLite, mySQL, and PostgreSQL ) you must also install the **Data storage and processing**.  

- Clone (or download) the Oqtane Master or Dev branch source code to your local system.

- Open the **Oqtane.sln** solution file.

- **Important:** Rebuild the entire solution before running it (ie. Build / Rebuild Solution).
  
- Make sure you specify Oqtane.Server as the Startup Project.

- Run the application... an Installation Wizard screen will be displayed which will allow you to configure your preferred database and create a host user account.

**Developing a custom module:**  

- follow the instructions for installing using source code outlined above

- login as the host user

- navigate to Control Panel (gear icon at top-right of page), Admin Dashboard, Module Management

- select Create Module

- enter information corresponding to the module you wish to create and then select the Create button

- make note of the Location where the code was generated and open the solution file in Visual Studio

- Build / Rebuild Solution, ensure the Oqtane.Server is set as the Startup Project, and hit F5 to run the solution

**Installing an official release:**

- all official releases of Oqtane are distributed on [GitHub](https://github.com/oqtane/oqtane.framework/releases). Releases include an Install.zip package for new installations and an Upgrade.zip for existing installations.
  
- A detailed set of instructions for installing Oqtane on Azure is located here: [Installing Oqtane on Azure](https://blazorhelpwebsite.com/ViewBlogPost/1)

- A detailed set of instructions for installing Oqtane on IIS is located here: [Installing Oqtane on IIS](https://www.oqtane.org/Resources/Blog/PostId/542/installing-oqtane-on-iis)
- Instructions for upgrading Oqtane are located here: [Upgrading Oqtane](https://www.oqtane.org/Resources/Blog/PostId/543/upgrading-oqtane)

**Additional Instructions**

- If you have already installed a previous version of Oqtane and you wish to do a clean database install, simply reset the DefaultConnection value in the Oqtane.Server\appsettings.json file to "". This will trigger a re-install when you run the application which will execute the database installation.
   
- If you want to submit pull requests make sure you install the [Github Extension For Visual Studio](https://visualstudio.github.com/). It is recommended you ignore any local changes you have made to the appsettings.json file before you submit a pull request. To automate this activity, open a command prompt and navigate to the /Oqtane.Server/ folder and enter the command "git update-index --skip-worktree appsettings.json" 

**Video Series**

- If you are getting started with Oqtane, a [series of videos](https://www.youtube.com/watch?v=JPfUZPlRRCE&list=PLYhXmd7yV0elLNLfQwZBUlM7ZSMYPTZ_f) are available which explain how to install the product, interact with the user interface, and develop custom modules.

# Oqtane Marketplace

Explore and enhance your Oqtane experience by visiting the Oqtane Marketplace. Discover a variety of modules, themes, and extensions contributed by the community. [Visit Oqtane Marketplace](https://www.oqtane.net)


# Documentation
There is a separate [Documentation repository](https://github.com/oqtane/oqtane.docs) which contains a variety of types of documentation for Oqtane, including API documentation that is auto generated using Docfx. The contents of the repository is published to Githib Pages and is available at [https://docs.oqtane.org](https://docs.oqtane.org/)

# Join the Community

Connect with other developers, get support, and share ideas by joining the Oqtane community on Discord!

[![Join our Discord](https://img.shields.io/badge/Join%20Discord-7289DA?style=for-the-badge&logo=discord&logoColor=white)](https://discord.gg/BnPny88avK)

# Roadmap
This project is open source, and therefore is a work in progress...

[6.1.3](https://github.com/oqtane/oqtane.framework/releases/tag/v6.1.3) (May 29, 2025)
- [x] Stabilization improvements 

[6.1.2](https://github.com/oqtane/oqtane.framework/releases/tag/v6.1.2) (Apr 10, 2025)
- [x] Stabilization improvements

[6.1.1](https://github.com/oqtane/oqtane.framework/releases/tag/v6.1.1) (Mar 12, 2025)
- [x] Stabilization improvements
- [x] Cookie Consent Banner & Privacy/Terms

[6.1.0](https://github.com/oqtane/oqtane.framework/releases/tag/v6.1.0) (Feb 11, 2025)
- [x] Static Asset / Folder Asset Caching
- [x] JavaScript improvements in Blazor Static Server Rendering (SSR)
- [x] User Impersonation

[6.0.1](https://github.com/oqtane/oqtane.framework/releases/tag/v6.0.1) (Dec 20, 2024)
- [x] Stabilization improvements

[6.0.0](https://github.com/oqtane/oqtane.framework/releases/tag/v6.0.0) (Nov 14, 2024)
- [x] Migration to .NET 9

[5.2.4](https://github.com/oqtane/oqtane.framework/releases/tag/v5.2.4) (Oct 17, 2024)
- [x] Stabilization improvements

[5.2.3](https://github.com/oqtane/oqtane.framework/releases/tag/v5.2.3) (Sep 23, 2024)
- [x] Stabilization improvements

[5.2.2](https://github.com/oqtane/oqtane.framework/releases/tag/v5.2.2) (Sep 23, 2024)
- [x] Stabilization improvements
- [x] Support for Security Stamp to faciliate Logout Everywhere
- [x] Role synchronization from External Login identity providers

[5.2.1](https://github.com/oqtane/oqtane.framework/releases/tag/v5.2.1) (Aug 22, 2024)
- [x] Stabilization improvements
- [x] Unzip support in File Management

[5.2.0](https://github.com/oqtane/oqtane.framework/releases/tag/v5.2.0) (Jul 25, 2024)
- [x] Site Content Search
- [x] RichTextEditor extensibility
- [x] Scalability and performance improvements

[5.1.2](https://github.com/oqtane/oqtane.framework/releases/tag/v5.1.2) (May 28, 2024)
- [x] Stabilization improvements

[5.1.1](https://github.com/oqtane/oqtane.framework/releases/tag/v5.1.1) (Apr 16, 2024)
- [x] Stabilization improvements

[5.1.0](https://github.com/oqtane/oqtane.framework/releases/tag/v5.1.0) (Mar 27, 2024)
- [x] Migration to the new unified Blazor approach in .NET 8 (ie. blazor.web.js)
- [x] Static Server Rendering (SSR) support

[5.0.2](https://github.com/oqtane/oqtane.framework/releases/tag/v5.0.2) (Jan 25, 2024)
- [x] Stabilization improvements

[5.0.1](https://github.com/oqtane/oqtane.framework/releases/tag/v5.0.1) (Dec 21, 2023)
- [x] Stabilization improvements

[5.0.0](https://github.com/oqtane/oqtane.framework/releases/tag/v5.0.0) (Nov 16, 2023)
- [x] Migration to .NET 8

➡️ Full list and older versions can be found in the [docs roadmap](https://docs.oqtane.org/guides/roadmap/index.html)

# Background
Oqtane was created by [Shaun Walker](https://www.linkedin.com/in/shaunbrucewalker/) and is inspired by the DotNetNuke web application framework. Oqtane is a native Blazor application written from the ground up using modern .NET Core technology and a Single Page Application (SPA) architecture. It is a modular application framework offering a fully dynamic page compositing model, multi-site support, designer friendly themes, and extensibility via third party modules.

# Reference Implementations

[Built On Blazor!](https://builtonblazor.net) - a showcase of sites built on Blazor

[.NET Foundation Project Trends](https://www.dnfprojects.com) - tracks the most active .NET Foundation open source projects based on GitHub activity

# Architecture

The following diagram visualizes the client and server components in the Oqtane architecture.

![Architecture](https://github.com/oqtane/framework/blob/master/screenshots/Architecture.png?raw=true "Oqtane Architecture")

# Databases

Oqtane supports multiple relational database providers - SQL Server, SQLite, MySQL, PostgreSQL

![Databases](https://github.com/oqtane/framework/blob/dev/screenshots/databases.png?raw=true "Oqtane Databases")

# Example Screenshots

Install Wizard:

![Installer](https://github.com/oqtane/framework/blob/master/screenshots/Installer.png?raw=true "Installer")

Default view after installation:

![Home](https://github.com/oqtane/framework/blob/master/screenshots/screenshot0.png?raw=true "Home")

A seamless login flow utilizing .NET Core Identity services:

![Login](https://github.com/oqtane/framework/blob/master/screenshots/screenshot1.png?raw=true "Login")

Main view for authorized users, allowing full management of modules and content:

![Admin View](https://github.com/oqtane/framework/blob/master/screenshots/screenshot2.png?raw=true "Admin View")

Content editing user experience using modal dialog:

![Edit Content](https://github.com/oqtane/framework/blob/master/screenshots/screenshot3.png?raw=true "Edit Content")

Context menu for managing specific module on page:

![Manage Module](https://github.com/oqtane/framework/blob/master/screenshots/screenshot4.png?raw=true "Manage Module")

Control panel for adding, editing, and deleting pages as well as adding new modules to a page:

![Manage Page](https://github.com/oqtane/framework/blob/master/screenshots/screenshot5.png?raw=true "Manage Page")

Admin dashboard for accessing the various administrative features of the framework:

![Admin Dashboard](https://github.com/oqtane/framework/blob/master/screenshots/screenshot6.png?raw=true "Admin Dashboard")

Responsive design mobile view:

![Mobile View](https://github.com/oqtane/framework/blob/master/screenshots/screenshot7.png?raw=true "Mobile View")
