FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY ./KittyManagementService/KittyManagementService/bin/Release/netcoreapp3.1 .
ENTRYPOINT ["dotnet", "KittyManagementService.dll"]