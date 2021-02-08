FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY /home/github/_work/kitty-management-service/kitty-management-service/KittyManagementService/KittyManagementService/bin/Release/netcoreapp3.1/ .
ENTRYPOINT ["dotnet", "KittyManagementService.dll"]