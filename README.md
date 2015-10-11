syncthing-dotnet
========
Syncthing API Rest connector for .NET

### Usage ###

```csharp
RestClient client = new RestClient("http://localhost:8384", "{{your_api_key}}");

if (client.Ping())
{
    Console.WriteLine("Your client ID: " + client.GetSystemStatus().ClientID);
}
```
Note: All calls are synchronous
