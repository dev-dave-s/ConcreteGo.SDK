# ConcreteGo.SDK

Please note - this is an unofficial SDK.

To connect to the concrete Go API, you will need to request an AppID / AppKey from Sysdyne.

Basic usage:

//Setup
var cgClient = new ConcreteGoClient("user@domain.com", "password", "AppId", "AppKey", "Slug");

//Get specific tickets based on ticket codes example:
```
var tickets = await cgClient.GetTicketsAsync(options =>
{
    options.TicketCodes.Add("12345");
    options.TicketCodes.Add("67891");
});
```
//Get Tickets between order dates example:
```
var tickets = await cgClient.GetTicketsAsync(options =>
{
    options.FromOrderDate = new DateTime(2024, 6, 1);
    options.ToOrderDate = new DateTime(2024, 6, 1);
});
```
