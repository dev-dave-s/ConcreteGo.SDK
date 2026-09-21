# DeliverGo.Api.Client

A small .NET library for talking to the DeliverGo / iSTRADA.net API. It handles the
OAuth 2.0 client-credentials flow against Sysdyne ID (token caching and refresh) and
exposes typed read access to snail trails, tickets and trucks.

## Configuration

```json
{
  "DeliverGo": {
	"ClientId": "<client id>",
	"ClientSecret": "<client secret>",
	"Scopes": [ "snailtrail:read", "ticket:read", "truck:read" ],
	"BaseAddress": "https://api.istrada.net/api/",
	"TokenEndpoint": "https://id.sysdyne.cloud/token",
	"DefaultLimit": 100
  }
}
```

`Resource` defaults to `BaseAddress` without its trailing slash, which matches the
`resource=https://api.istrada.net/api` value expected by Sysdyne ID.

## Registration

```csharp
builder.Services.AddDeliverGoApiClient(
	builder.Configuration.GetSection(DeliverGoOptions.SectionName));
```

Or configure in code:

```csharp
builder.Services.AddDeliverGoApiClient(options =>
{
	options.ClientId = "...";
	options.ClientSecret = "...";
	options.Scopes = ["ticket:read", "truck:read"];
});
```

## Usage

```csharp
public sealed class DispatchService(IDeliverGoApiClient client)
{
	public async Task<IReadOnlyList<Ticket>> GetTodaysTicketsAsync(string plantNumber, CancellationToken ct)
	{
		var filter = new DeliverGoFilter()
			.WithWhere("plantNumber", plantNumber)
			.WithWhere("ticketDate", new Dictionary<string, object?>
			{
				["gte"] = DateTimeOffset.UtcNow.Date
			})
			.WithOrder("ticketDate DESC")
			.WithLimit(200);

		return await client.GetTicketsAsync(filter, ct);
	}
}
```

Single records are fetched by id and return `null` when not found:

```csharp
Truck? truck = await client.GetTruckAsync(truckId, cancellationToken: ct);
```

## Notes

- Several endpoints reject unfiltered queries, so supply a `DeliverGoFilter`.
  When no `limit` is provided, `DefaultLimit` from the options is applied.
- The API has no rate limiting; large queries degrade the iSTRADA site, so keep
  result sets bounded.
- Non-success responses throw `DeliverGoApiException` with the status code,
  request URI and raw response body.
- A `401` triggers one automatic token refresh and retry.
