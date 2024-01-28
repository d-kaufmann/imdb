# Imdb
 
Make sure to add `appsettings.json` in the folder `View`. This file is not on GitHub because of security reasons.

It should look something like this:
```json
{
 "Logging": {
   "LogLevel": {
     "Default": "Information",
     "Microsoft": "Warning",
     "Microsoft.Hosting.Lifetime": "Information"
   }
 },
 "AllowedHosts": "*",
 "ConnectionStrings": {
   "DefaultConnection": "server=<server_address>; port=<exposed_port>; database=<database>; user=<user>; password=<password>; Persist Security Info=False; Connect Timeout=300"
 }
}
```
