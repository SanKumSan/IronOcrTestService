﻿FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

ENV SimpleProperty="hello-start-dockerfile"

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["IronOcrWebApi/IronOcrWebApi.csproj", "IronOcrWebApi/"]
RUN dotnet restore "IronOcrWebApi/IronOcrWebApi.csproj"
COPY . .
WORKDIR "/src/IronOcrWebApi"
RUN dotnet build "IronOcrWebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "IronOcrWebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV SimpleProperty="hello-end-dockerfile"

ENTRYPOINT ["dotnet", "IronOcrWebApi.dll"]
