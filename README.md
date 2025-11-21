# .NET 8 Devcontainer Pilot

**Dev Environment as a Product** pilot: `git clone` → `Reopen in Container` → `dotnet run` → running Web API.

## Prerequisites

- Docker Desktop
- Visual Studio Code with `Dev Containers` extension (ms-vscode-remote.remote-containers)

## Quick Start

1. **Clone and open**
   ```bash
   git clone https://github.com/hariscats/dotnet-devcontainer-pilot
   cd dotnet-devcontainer-pilot
   code .
   ```

2. **Reopen in container**
   - Click "Reopen in Container" when prompted, or
   - Press `F1` → "Dev Containers: Reopen in Container"
   
   This automatically builds the container, installs extensions, and restores dependencies.

3. **Run the API**
   ```bash
   dotnet run --project src/WebApi/WebApi.csproj
   ```
   Port 8080 auto-forwards and opens in your browser.

4. **Test endpoints**
   - `http://localhost:8080/` - Welcome message
   - `http://localhost:8080/health` - Health check JSON

## What's Included

**Devcontainer** (`.devcontainer/`)
- .NET 8 SDK with Git and Azure CLI
- Pre-configured VS Code extensions (C# Dev Kit, GitLens, EditorConfig)
- Automatic dependency restoration on container creation

**Web API** (`src/WebApi/`)
- Minimal .NET 8 Web API with two endpoints
- Ready for extension (Swagger, more endpoints, etc.)

**CI Pipeline** (`.github/workflows/ci.yml`)
- Runs on every push/PR to `main`
- Uses same Docker image as devcontainer for environment parity
- Build validation (tests can be added later)

## Troubleshooting

| Issue | Solution |
|-------|----------|
| Container won't build | Ensure Docker Desktop is running and Dev Containers extension is installed |
| Port 8080 in use | Stop conflicting service or change port in `devcontainer.json` and `Program.cs` |
| Extensions not loading | Reload window: `F1` → "Developer: Reload Window" |

## Next Steps

- Add xUnit tests in `tests/` and integrate with CI
- Enable code formatting (`dotnet format`) and Roslyn analyzers
- Use as template for other .NET services
