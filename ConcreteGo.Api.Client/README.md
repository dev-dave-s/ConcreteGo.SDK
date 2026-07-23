# ConcreteGo API Client

A .NET client library for the Sysdyne ConcreteGo API. This package provides a typed wrapper around the ConcreteGo/Webcrete SOAP API with dependency injection support.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![GitHub](https://img.shields.io/badge/GitHub-Repository-blue.svg)](https://github.com/dev-dave-s/ConcreteGo.SDK)

## Source Code

The source code is available on GitHub: [https://github.com/dev-dave-s/ConcreteGo.SDK](https://github.com/dev-dave-s/ConcreteGo.SDK)

## Requirements

- .NET 10.0 or later
- A valid ConcreteGo account with API credentials (Username, Password, AppId, AppKey)

## Installation

Install the NuGet package:

```
dotnet add package ConcreteGo.Api.Client
```

## Configuration

### 1. Add settings to `appsettings.json`

```json
{
  "ConcreteGoApi": {
	"Username": "user@domain.com.au",
	"Password": "password",
	"AppId": "your-app-id",
	"AppKey": "your-app-key",
	"Slug": "your-slug"
  }
}
```

| Property   | Required | Description                                      |
|------------|----------|--------------------------------------------------|
| `Username` | Yes      | Your ConcreteGo account email                    |
| `Password` | Yes      | Your ConcreteGo account password                 |
| `AppId`    | Yes      | Application ID provided by Sysdyne               |
| `AppKey`   | Yes      | Application key provided by Sysdyne              |
| `Slug`     | No       | Tenant slug (required for multi-tenant setups)   |

### 2. Register the client in `Program.cs`

```csharp
builder.Services.AddConcreteGoApiClient(builder.Configuration);
```

#### Alternative registration methods

**Explicit parameters (no configuration file needed):**

```csharp
builder.Services.AddConcreteGoApiClient(
	username: "user@domain.com.au",
	password: "password",
	appId: "your-app-id",
	appKey: "your-app-key",
	slug: "your-slug");
```

**Action-based configuration:**

```csharp
builder.Services.AddConcreteGoApiClient(options =>
{
	options.Username = "user@domain.com.au";
	options.Password = "password";
	options.AppId = "your-app-id";
	options.AppKey = "your-app-key";
	options.Slug = "your-slug";
});
```

**Singleton lifetime (for background services):**

```csharp
builder.Services.AddConcreteGoApiClientSingleton(builder.Configuration);
```

## Usage

Inject `ConcreteGoApiClient` into your services via constructor injection:

```csharp
public class MyService
{
	private readonly ConcreteGoApiClient _client;

	public MyService(ConcreteGoApiClient client)
	{
		_client = client;
	}

	public async Task SomeMethodAsync()
	{
		var tickets = await _client.GetTicketsAsync(options =>
		{
			options.FromOrderDate = DateTime.Today.AddDays(-7);
			options.ToOrderDate = DateTime.Today;
			options.IncludeRemovedTicket = true;
		});
	}
}
```

All query methods accept an optional `Action<TOptions>` parameter to configure filtering. If no options are provided, the API returns all available records.

## Available Methods

### Tickets

| Method | Description |
|--------|-------------|
| `GetTicketsAsync(Action<TicketRequestOptions>?)` | Query tickets with date ranges, customer/plant/project filters |
| `AddOrUpdateTicketAsync(TicketAddOrUpdateRequest)` | Create or update a ticket |

**TicketRequestOptions filter properties:**
- `FromOrderDate` / `ToOrderDate` — Filter by order date range
- `FromTicketTime` / `ToTicketTime` — Filter by ticket time range
- `FromUpdateTime` / `ToUpdateTime` — Filter by last update time
- `FromLoadTime` / `ToLoadTime` — Filter by load time
- `FromCreatedDate` / `ToCreatedDate` — Filter by creation date
- `OrderID` — Filter by specific order IDs
- `TicketID` — Filter by specific ticket IDs
- `TicketCode` — Filter by ticket codes
- `PlantCode` — Filter by plant codes
- `CustomerCode` — Filter by customer codes
- `ProjectCode` — Filter by project codes
- `MixCode` — Filter by mix codes
- `ListOnly` — Return summary data only
- `IncludeRemovedTicket` — Include removed tickets
- `IncludeSuspendedTicket` — Include suspended tickets
- `IncludeInvoicedTicket` — Include invoiced tickets
- `WithBatchWeightsOnly` — Only return tickets with batch weights
- `MarkOrderAsInvoiced` / `MarkTicketAsInvoiced` — Mark as invoiced on retrieval
- `IncludeRetElement` — Specify additional return elements (e.g., `USERDEFINEDFIELD`, `ORDERUSERDEFINEDFIELD`, `CUSTOMERUSERDEFINEDFIELD`)

### Orders

| Method | Description |
|--------|-------------|
| `GetOrdersAsync(Action<OrderRequestOptions>?)` | Query orders |
| `AddOrUpdateOrderAsync(OrderAddOrUpdateRequest)` | Create or update an order |

### Customers

| Method | Description |
|--------|-------------|
| `GetCustomersAsync(Action<CustomerOptions>?)` | Query customers with filters for codes, names, dates, and more |
| `AddOrUpdateCustomer(CustomerAddOrUpdateRequest)` | Create or update a customer |

**CustomerOptions filter properties:**
- `IDs` — Filter by customer IDs
- `Codes` — Filter by customer codes
- `Names` — Filter by customer names
- `MaxReturned` — Limit number of results
- `ListOnly` — Return summary data only
- `InActive` — Include inactive customers
- `FromSetupDate` / `ToSetupDate` — Filter by setup date range
- `FromUpdateDate` / `ToUpdateDate` — Filter by update date range
- `SalesAnalysisCodes`, `SalesmanCodes`, `PriceCategoryCodes`, `ZoneCodes`, etc.

### Invoices

| Method | Description |
|--------|-------------|
| `GetInvoicesAsync(Action<InvoiceRequestOptions>?)` | Query invoices |

### Items

| Method | Description |
|--------|-------------|
| `GetItemsAsync(Action<ItemRequestOptions>?)` | Query items (products/mixes) |
| `AddOrUpdateItem(ItemAddOrUpdateRequest)` | Create or update an item |
| `AddOrUpdateItemWithResponse(ItemAddOrUpdateRequest)` | Create or update an item and return full response |

### Projects

| Method | Description |
|--------|-------------|
| `GetProjectsAsync(Action<ProjectRequestOptions>?)` | Query projects |
| `AddOrUpdateProject(ProjectAddOrUpdateRequest)` | Create or update a project |

### Plants

| Method | Description |
|--------|-------------|
| `GetPlantsAsync(Action<PlantOptions>?)` | Query plants |
| `AddOrUpdatePlant(PlantAddOrUpdateRequest)` | Create or update a plant |

### Locations

| Method | Description |
|--------|-------------|
| `GetLocationsAsync(Action<LocationOptions>?)` | Query locations |
| `AddOrUpdateLocation(LocationAddOrUpdateRequest)` | Create or update a location |

### Trucks

| Method | Description |
|--------|-------------|
| `GetTrucksAsync(Action<TruckRequestOptions>?)` | Query trucks |
| `AddOrUpdateTruck(TruckAddOrUpdateRequest)` | Create or update a truck |

### Quotes

| Method | Description |
|--------|-------------|
| `GetQuotesAsync(Action<QuoteRequestOptions>?)` | Query quotes |

### Jobs

| Method | Description |
|--------|-------------|
| `GetJobsAsync(Action<JobRequestOptions>?)` | Query jobs |

### Employees

| Method | Description |
|--------|-------------|
| `GetEmployeesAsync(Action<EmployeeOptions>?)` | Query employees |

### Reference Data

| Method | Description |
|--------|-------------|
| `GetCompanyAsync(Action<CompanyOptions>?)` | Query company information |
| `GetDivisionsAsync(Action<DivisionRequestOptions>?)` | Query divisions |
| `GetAccountingCategories(Action<AccountingCategoryOptions>?)` | Query accounting categories |
| `GetCreditCodesAsync(Action<CreditCodeOptions>?)` | Query credit codes |
| `GetItemCategoriesAsync(Action<ItemCategoryOptions>?)` | Query item categories |
| `GetItemTypesAsync(Action<ItemTypeOptions>?)` | Query item types |
| `GetPriceCategories(Action<PriceCategoryOptions>?)` | Query price categories |
| `GetReasonCodesAsync(Action<ReasonCodeOptions>?)` | Query reason codes |
| `GetUOMsAsync(Action<UOMRequestOptions>?)` | Query units of measure |

### Tax

| Method | Description |
|--------|-------------|
| `GetTaxAuthoritiesAsync(Action<TaxAuthorityOptions>?)` | Query tax authorities |
| `GetTaxCodesAsync(Action<TaxCodeOptions>?)` | Query tax codes |
| `GetTaxLocationsAsync(Action<TaxLocationOptions>?)` | Query tax locations |

### Inventory

| Method | Description |
|--------|-------------|
| `GetInventoryTransactionsAsync(Action<InventoryTransactionOptions>?)` | Query inventory transactions |
| `GetCloudBatchInventoryAsync(Action<CloudBatchInventoryOptions>?)` | Query cloud batch inventory |

### System

| Method | Description |
|--------|-------------|
| `GetVersionAsync(Action<VersionOptions>?)` | Get ConcreteGo and Webcrete API version info |

## Examples

### Query tickets for a date range

```csharp
var tickets = await client.GetTicketsAsync(options =>
{
	options.FromOrderDate = new DateTime(2024, 1, 1);
	options.ToOrderDate = new DateTime(2024, 1, 31);
});
```

### Get customers by code

```csharp
var customers = await client.GetCustomersAsync(options =>
{
	options.Codes = new List<string> { "CUST001", "CUST002" };
});
```

### Get all items (no filter)

```csharp
var items = await client.GetItemsAsync();
```

### Query invoices

```csharp
var invoices = await client.GetInvoicesAsync(options =>
{
	// Configure invoice-specific filters
});
```

### Get tickets with user-defined fields

```csharp
var tickets = await client.GetTicketsAsync(options =>
{
	options.FromOrderDate = DateTime.Today.AddDays(-30);
	options.ToOrderDate = DateTime.Today;
	options.IncludeRetElement = new List<string>
	{
		"USERDEFINEDFIELD",
		"ORDERUSERDEFINEDFIELD",
		"CUSTOMERUSERDEFINEDFIELD"
	};
});
```

## Authentication

The client handles authentication automatically. It logs in on the first API call and manages session renewal internally. No manual login step is required.

## License

MIT