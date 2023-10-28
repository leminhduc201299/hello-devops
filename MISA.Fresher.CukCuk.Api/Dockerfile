FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY ./app .
COPY ./appsettings.json appsettings.json
EXPOSE 8012
ENTRYPOINT ["dotnet", "MISA.Fresher.CukCuk.Api.dll"]