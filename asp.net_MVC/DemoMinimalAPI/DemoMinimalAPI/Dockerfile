#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DemoMinimalAPI/DemoMinimalAPI.csproj", "DemoMinimalAPI/"]
RUN dotnet restore "DemoMinimalAPI/DemoMinimalAPI.csproj"
COPY . .
WORKDIR "/src/DemoMinimalAPI"
RUN dotnet build "DemoMinimalAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DemoMinimalAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DemoMinimalAPI.dll"]