# Soenneker.Nubilus.Azure.Cosmos
[![](https://img.shields.io/nuget/v/soenneker.nubilus.azure.cosmos.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.nubilus.azure.cosmos/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.nubilus.azure.cosmos/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.nubilus.azure.cosmos/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.nubilus.azure.cosmos.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.nubilus.azure.cosmos/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.nubilus.azure.cosmos/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.nubilus.azure.cosmos/actions/workflows/codeql.yml)

Fetches existing Azure Cosmos DB accounts through Azure Resource Manager using a shared authenticated `ArmClient`.

## Installation

```bash
dotnet add package Soenneker.Nubilus.Azure.Cosmos
```

## Configuration

The underlying ARM client uses an application registration:

```json
{
  "Azure": {
    "TenantId": "tenant-id",
    "AppRegistration": {
      "Id": "client-id",
      "Secret": "client-secret"
    }
  }
}
```

Store the client secret in a secret provider rather than a committed settings file. Grant the application only the Azure role permissions needed to read the target Cosmos DB accounts.

## Registration

```csharp
using Soenneker.Nubilus.Azure.Cosmos.Registrars;

builder.Services.AddNubilusCosmosManagerAsScoped();
// or: builder.Services.AddNubilusCosmosManagerAsSingleton();
```

Both registrations keep the authenticated ARM client utility singleton. The scoped option only scopes the lightweight manager wrapper.

## Fetch an account

```csharp
using Azure.Core;
using Azure.ResourceManager.CosmosDB;
using Soenneker.Nubilus.Azure.Cosmos.Abstract;

var resourceId = new ResourceIdentifier(
    "/subscriptions/00000000-0000-0000-0000-000000000000" +
    "/resourceGroups/data-production" +
    "/providers/Microsoft.DocumentDB/databaseAccounts/orders-cosmos");

CosmosDBAccountResource account = await cosmos.GetAccount(resourceId, cancellationToken);
```

The method performs an ARM GET request and returns the current resource, not merely a local handle. Authentication failures, authorization failures, malformed or wrong resource identifiers, missing accounts, service errors, and cancellation are surfaced through the Azure SDK.

This package does not create, update, delete, or enumerate accounts, and it does not provide data-plane access to databases or containers.
