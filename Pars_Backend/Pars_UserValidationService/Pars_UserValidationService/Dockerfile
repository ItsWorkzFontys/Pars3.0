#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Pars_UserValidationService/Pars_UserValidation.API.csproj", "Pars_UserValidationService/"]
COPY ["Pars_UserValidation.Core.API/Pars_UserValidation.Core.API.csproj", "Pars_UserValidation.Core.API/"]
COPY ["Pars_UserValidation.DAL/Pars_UserValidation.DAL.csproj", "Pars_UserValidation.DAL/"]
RUN dotnet restore "Pars_UserValidationService/Pars_UserValidation.API.csproj"
COPY . .
WORKDIR "/src/Pars_UserValidationService"
RUN dotnet build "Pars_UserValidation.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Pars_UserValidation.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Pars_UserValidation.API.dll"]
