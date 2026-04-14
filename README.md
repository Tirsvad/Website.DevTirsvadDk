[![Contributors][contributors-shield]][contributors-url]
[![License][license-shield]][license-url]
[![Forks][forks-shield]][forks-url]
[![Stars][stars-shield]][stars-url]
[![Repo Size][repo-size-shield]][repo-size-url]
[![.NET 10][dotnet-shield]][dotnet-url]
[![Issues][issues-shield]][issues-url]

# Project Status Portfolio Website
<img  style="float: left; margin: 5px 10px 0 0;" src="https://raw.githubusercontent.com/TirsvadCLI/Logo/refs/heads/main/images/logo/64x64/logo.png">
Website is a .NET 10 solution for `dev.tirsvad.dk` that presents project status information in our portfolio to stakeholders through a Blazor frontend and a WebAPI backend. The solution is intended to improve transparency, communication, and decision-making by exposing project goals, milestones, risks, quality criteria, README content, code coverage, code documentation, and related status artifacts in one place.

## 📚 Table of Contents

- [Overview](#overview)
- [Solution Goals](#solution-goals)
- [Architecture](#architecture)
- [Repository Structure](#repository-structure)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Documentation](#documentation)
- [Roadmap](#roadmap)
- [License](#license)
- [Contact](#contact)

## 🚀 Overview

The solution follows Clean Architecture principles and is organized around `Domain`, `Application`, `Infrastructure`, `Web`, and `WebApi` projects. It includes a Blazor-based web experience for stakeholders and a WebAPI service for backend access and integration scenarios.


Current repository highlights:

- 🟣 `.NET 10` solution with a root `Tirsvad.Website.DevTirsvadDk.slnx`
- 🖥️ Blazor web application in `src/Web/`
- 🛠️ WebAPI project in `src/WebApi/`
- 🏗️ Layered application projects in `src/Application/`, `src/Domain/`, and `src/Infrastructure/`
- 🧪 Matching test projects in `tests/`
- 📄 Architecture and use case documentation in `docs/`

## 🎯 Solution Goals


According to `docs/bc.md`, the solution is being built to:

- 🎯 show project goals and stakeholder contact information
- 📅 show milestones and timelines
- 🔒 protect private project information through authentication and authorization
- ⚠️ show risks and mitigation strategies
- 🏆 show quality criteria and explain how they are used
- 🤖 show Copilot agents, instructions, and prompts
- 📖 expose README, code coverage, and code documentation when available
- 📝 support blog posts, comments, likes, and feedback-driven UX improvements

## 🏗️ Architecture


The repository is structured around Clean Architecture concerns:

- 🧩 `src/Domain` - Domain entities, value objects, and core business concepts
- 🧩 `src/Application` - Application services, DTOs, interfaces, and use case orchestration. This layer should be independent of frameworks
- 🧩 `src/Infrastructure` - Manager implementations, e.g. for authentication, authorization, and other cross-cutting concerns
- 🗄️ `src/Infrastructure.Data` - data access implementations, e.g. Entity Framework Core
- 🌐 `src/WebApi` - backend HTTP API endpoints and OpenAPI support
- 🖥️ `src/Web` - Blazor frontend for the project status website
- 🧪 `tests/*` - mirrored automated test projects for the main layers


The current implementation targets `net10.0` in both the web and API applications.

## 🗂️ Repository Structure

```text
.
├─ 📁src/
│  ├─ 🧩Application/
│  ├─ 🧩Domain/
│  ├─ 🧩Infrastructure/
│  ├─ 🗄️Infrastructure.Data/
│  ├─ 🖥️Web/
│  └─ 🌐WebApi/
├─ 📁tests/
│  ├─ 🧪Application.Tests/
│  ├─ 🧪Domain.Tests/
│  ├─ 🧪Infrastructure.Data.Tests/
│  └─ 🧪Infrastructure.Tests/
├─ 🗃️docs/
├─ 📁.github/
├─ 📄global.json
└─ Tirsvad.Website.DevTirsvadDk.slnx
```

## 🛠️ Prerequisites


Before running the solution locally, install or prepare the following:

- 💿 .NET 10 SDK
- 🖥️ Visual Studio 2026 or a compatible editor with .NET support
- 🔐 HTTPS development certificate for ASP.NET Core
- 🐘 PostgreSQL for the planned data storage requirements

## 📦 Installation

### 📥 Clone the repository

```powershell
git clone https://github.com/Tirsvad/Website.DevTirsvadDk.git
cd Website.DevTirsvadDk
```

### 📦 Restore dependencies

```powershell
dotnet restore .\Tirsvad.Website.DevTirsvadDk.slnx
```

### 🏗️ Build the solution

```powershell
dotnet build .\Tirsvad.Website.DevTirsvadDk.slnx
```

### 🧪 Run automated tests

```powershell
dotnet test .\Tirsvad.Website.DevTirsvadDk.slnx
```

## ▶️ Usage

### 🖥️ Run the Blazor web application

```powershell
dotnet run --project .\src\Web\Tirsvad.Website.DevTirsvadDk.Web\Tirsvad.Website.DevTirsvadDk.Web.csproj
```


Default local URLs from `launchSettings.json`:

- `https://localhost:7140`
- `http://localhost:5281`

### 🌐 Run the WebAPI

```powershell
dotnet run --project .\src\WebApi\Tirsvad.Website.DevTirsvadDk.WebApi.csproj
```


Default local URLs from `launchSettings.json`:

- `https://localhost:7208`
- `http://localhost:5065`


The API currently exposes a sample endpoint:

- `GET /weatherforecast`


In development, OpenAPI is enabled for the API project.

## 📝 Documentation


Project documentation is stored in `docs/` and related instruction files are in `.github/`.


Relevant starting points:

- 📄 `docs/bc.md` - business case and project objectives
- 🗓️ `docs/milestones-gateways.md` - milestone and gateway planning
- 🧾 `docs/use-cases/` - generated use case documentation
- 🤖 `.github/copilot-instructions.md` - repository-wide development guidance

## 🗺️ Roadmap


The business case defines the current high-level delivery plan:

1. 🏗️ Set up the project structure, environment, CI/CD, authentication, authorization, quality criteria, and project guidance.
2. 🌐 Build the WebAPI endpoints and Blazor frontend for project status information.
3. 📝 Add blog functionality, integration, user testing, and UX refinements.

## 📄 License


This repository is licensed under the GNU Affero General Public License v3.0. See `LICENSE` for details.

## 📬 Contact

Jens Tirsvad Nielsen  
[LinkedIn][linkedin-url]

<!-- Links -->
[contributors-shield]: https://img.shields.io/github/contributors/Tirsvad/Website.DevTirsvadDk?style=for-the-badge
[contributors-url]: https://github.com/Tirsvad/Website.DevTirsvadDk/graphs/contributors
[issues-shield]: https://img.shields.io/github/issues/Tirsvad/Website.DevTirsvadDk?style=for-the-badge
[issues-url]: https://github.com/Tirsvad/Website.DevTirsvadDk/issues
[forks-shield]: https://img.shields.io/github/forks/Tirsvad/Website.DevTirsvadDk?style=for-the-badge
[forks-url]: https://github.com/Tirsvad/Website.DevTirsvadDk/network/members
[stars-shield]: https://img.shields.io/github/stars/Tirsvad/Website.DevTirsvadDk?style=for-the-badge
[stars-url]: https://github.com/Tirsvad/Website.DevTirsvadDk/stargazers
[license-shield]: https://img.shields.io/github/license/Tirsvad/Website.DevTirsvadDk?style=for-the-badge
[license-url]: https://github.com/Tirsvad/Website.DevTirsvadDk/blob/main/LICENSE
[repo-size-shield]: https://img.shields.io/github/repo-size/Tirsvad/Website.DevTirsvadDk?style=for-the-badge
[repo-size-url]: https://github.com/Tirsvad/Website.DevTirsvadDk
[dotnet-shield]: https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet
[dotnet-url]: https://dotnet.microsoft.com/
[linkedin-url]: https://www.linkedin.com/in/jens-tirsvad-nielsen-13b795b9/

<!-- Build Status -->
[build-shield]: https://img.shields.io/github/workflow/status/[InsertOwner]/[InsertRepo]/[InsertWorkflowName]?style=for-the-badge
