[![](https://img.shields.io/nuget/v/soenneker.nubilus.azure.cosmos.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.nubilus.azure.cosmos/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.nubilus.azure.cosmos/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.nubilus.azure.cosmos/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.nubilus.azure.cosmos.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.nubilus.azure.cosmos/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.nubilus.azure.cosmos/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.nubilus.azure.cosmos/actions/workflows/codeql.yml)

# Soenneker.Nubilus.Azure.Cosmos

An Azure Resource Manager for Azure Cosmos DB instances.

## Install

```bash
dotnet add package Soenneker.Nubilus.Azure.Cosmos
```

## Quick start

```csharp
using Soenneker.Nubilus.Azure.Cosmos.Registrars;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
var result = services.AddNubilusCosmosManagerAsSingleton();
```

Adds `INubilusCosmosManager` as a singleton service.

## What you get

- `INubilusCosmosManager` — An Azure Resource Manager for Azure Cosmos DB instances.
- `NubilusCosmosManagerRegistrar` — An Azure Resource Manager for Azure Cosmos DB instances.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `NubilusCosmosManagerRegistrar.AddNubilusCosmosManagerAsSingleton(services)` | Adds `INubilusCosmosManager` as a singleton service. | The same service collection, so additional registrations can be chained. |
| `NubilusCosmosManagerRegistrar.AddNubilusCosmosManagerAsScoped(services)` | Adds `INubilusCosmosManager` as a scoped service. | The same service collection, so additional registrations can be chained. |
