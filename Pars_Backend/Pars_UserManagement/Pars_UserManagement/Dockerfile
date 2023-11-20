#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Pars_UserManagement/Pars_UserManagement.csproj", "Pars_UserManagement/"]
RUN dotnet restore "Pars_UserManagement/Pars_UserManagement.csproj"
COPY ["Pars_UserManagement/Pars_UserManagement.csproj", "Pars_UserManagement/"]
WORKDIR "/src/Pars_UserManagement"
RUN dotnet build "Pars_UserManagement.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Pars_UserManagement.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Pars_UserManagement.dll"]