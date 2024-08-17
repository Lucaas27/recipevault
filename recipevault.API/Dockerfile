FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app


USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
# Copy the csproj and restore as distinct layers
COPY ["recipevault.API/recipevault.API.csproj", "recipevault.API/"]
RUN dotnet restore "recipevault.API/recipevault.API.csproj"
# Copy the remaining files and build the application
COPY . .
WORKDIR "/src/recipevault.API"
RUN dotnet build "recipevault.API.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "recipevault.API.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "recipevault.API.dll"]
