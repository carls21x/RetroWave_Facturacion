# RetroWave_Facturacion

Compact invoicing application targeting .NET Framework 4.7.2.

## Overview

RetroWave_Facturacion is a .NET Framework 4.7.2 application for generating and managing invoices (facturación). This repository contains the solution, source code, and supporting files required to build and run the application in Visual Studio 2022.

## Key highlights

- Target framework: `.NET Framework 4.7.2`
- Recommended IDE: `Visual Studio 2022`
- Package management: `NuGet`
- Configuration files: `App.config` / `Web.config` (depending on project type)
- Coding standards: `.editorconfig` and `CONTRIBUTING.md` (project rules must be followed)

## Prerequisites

- Windows 10/11 or compatible
- `Visual Studio 2022` with `.NET desktop development` and/or `ASP.NET and web development` workloads installed
- `.NET Framework 4.7.2 Developer Pack` (if not included with VS)
- `SQL Server` (Express / LocalDB / Full) or another database engine supported by the project
- Internet connection to restore NuGet packages

## Quick start

1. Clone the repository:
   - `git clone https://github.com/carls21x/RetroWave_Facturacion.git`

2. Open the solution:
   - Open `RetroWave_Facturacion.sln` in `Visual Studio 2022`.

3. Restore NuGet packages:
   - Visual Studio will typically restore automatically. If not, right-click the solution and choose `Restore NuGet Packages`.

4. Configure the database connection:
   - Edit the appropriate configuration file (`App.config` or `Web.config`) and set your connection string. Example placeholder:

     ```xml
     <connectionStrings>
       <add name="DefaultConnection" connectionString="Server=.\SQLEXPRESS;Database=RetroWaveDB;Trusted_Connection=True;" providerName="System.Data.SqlClient" />
     </connectionStrings>
     ```

   - Replace the connection string values with your server, database name, credentials, and provider as required.

5. Build and run:
   - Select the startup project, build the solution (`Build > Build Solution`), then run (`Debug > Start Debugging` or `Ctrl+F5`).

## Database

- If the project uses migrations or an ORM (Entity Framework, Dapper, etc.), follow the repository-specific migration steps:
  - For Entity Framework Code First with migrations: use the `Package Manager Console`:
    - `Update-Database -ProjectName <ProjectContainingMigrations> -StartupProjectName <StartupProject>`
  - If there are SQL scripts, run them against your database to create the schema and seed data.

## Tests

- Unit tests (if present) can be run using `Test Explorer` in Visual Studio.
- From command line (if supported): use `vstest.console.exe` or an appropriate test runner.

## Configuration & Secrets

- Do not commit production credentials or secrets.
- Use environment variables, user secrets (for development), or secure configuration stores for sensitive values.
- Keep configuration changes documented in `CONTRIBUTING.md` if required by the project.

## Contributing

- Follow the repository's `CONTRIBUTING.md` and `.editorconfig` for code style and commit conventions.
- Create feature branches from `master`, add tests for changes, and open pull requests for review.

## Troubleshooting

- NuGet package restore fails: ensure NuGet feed access and clear the local package cache (`nuget locals all -clear`).
- Build errors referencing missing targets or SDKs: ensure `.NET Framework 4.7.2 Developer Pack` and required Visual Studio workloads are installed.
- Database connection issues: verify the connection string, database server accessibility, and that the database exists.

## License & Notices

- Check repository root for a `LICENSE` file. If none exists, contact the project owner to confirm licensing terms before reusing code.

## Contact / Support

- For repository-specific questions, open an issue on GitHub or contact the repository owner.

---

If you want, I can generate a Spanish version of this README or adapt it to include specific details from your solution (project names, connection strings, migration commands). What would you prefer?
