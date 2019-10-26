FROM mcr.microsoft.com/dotnet/core/sdk:3.0
WORKDIR /app
COPY . ./
RUN dotnet publish  PokeApp.WebApp -c Release  -o publish
CMD ["dotnet", "PokeApp.WebApp.dll"]