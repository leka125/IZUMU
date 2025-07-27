# Etapa 1: build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar la solución y los proyectos
COPY IZUMU.Clientes.sln .
COPY IZUMU.Clientes.Infrastructure/ IZUMU.Clientes.Infrastructure/
COPY IZUMU.Clientes.UI/ IZUMU.Clientes.UI/
COPY IZUMU.Clientes.Tests/ IZUMU.Clientes.Tests/

# Restaurar dependencias
RUN dotnet restore

# Publicar solo el proyecto UI
RUN dotnet publish IZUMU.Clientes.UI/IZUMU.Clientes.UI.csproj -c Release -o /app/publish

# Etapa 2: runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Exponer el puerto
EXPOSE 8080

ENV ASPNETCORE_ENVIRONMENT=Development

ENTRYPOINT ["dotnet", "IZUMU.Clientes.UI.dll"]
