FROM mcr.microsoft.com/dotnet/core/sdk:3.0
WORKDIR /app
COPY . ./
RUN dotnet build

RUN dotnet publish -c Release -o -publish
WORKDIR /app/publish
CMD ["dotnet", "ContainerDemo2.dll"]