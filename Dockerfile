FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY . .
RUN dotnet restore
RUN dotnet build -c Release -o /app/build

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENV ASPNETCORE_URLS="http://+:5678"
ENV Jwt:Key="secret"
ENV Postgres:ConnectionString="Host=postgres;Port=5432;Database=postgres;Username=secret;Password=secret;Pooling=true;Maximum Pool Size=100"
ENV ASPNETCORE_ENVIRONMENT="Development"

EXPOSE 5678

ENTRYPOINT ["dotnet", "Boussole.Web.dll"]