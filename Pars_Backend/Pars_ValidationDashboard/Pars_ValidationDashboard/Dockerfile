#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Pars_ValidationDashboard/Pars_ValidationDashboard.csproj", "Pars_ValidationDashboard/"]
RUN dotnet restore "Pars_ValidationDashboard/Pars_ValidationDashboard.csproj"
COPY ["Pars_ValidationDashboard/Pars_ValidationDashboard.csproj", "Pars_ValidationDashboard/"]
WORKDIR "/src/Pars_ValidationDashboard"
RUN dotnet build "Pars_ValidationDashboard.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Pars_ValidationDashboard.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Pars_ValidationDashboard.dll"]