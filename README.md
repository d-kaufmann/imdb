# imdb
 
Make sure to add `appsettings.json` in the folder `View`. This file is not on GitHub because of security reasons.

It should look like this:
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
   "DefaultConnection": "server=<server address>; port:<exposed port>; database=<databbase>; user=<user>; password=<password>; Persist Security Info=False; ConnectTimeout=300"
 }
}
```
