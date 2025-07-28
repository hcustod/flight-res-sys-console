# Use the official .NET SDK image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

# Copy csproj and restore
COPY FlightReservationSystemProject/*.csproj ./FlightReservationSystemProject/
RUN dotnet restore ./FlightReservationSystemProject/FlightReservationSystemProject.csproj

# Copy everything else and build
COPY . .
WORKDIR /app/FlightReservationSystemProject
RUN dotnet build --configuration Release
RUN dotnet publish -c Release -o /app/publish

# Runtime image
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "FlightReservationSystemProject.dll"]
