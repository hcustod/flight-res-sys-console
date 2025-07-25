# Use the official .NET SDK image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set working directory inside container
WORKDIR /app

# Copy everything into the container
COPY . .

# Restore and build the project
RUN dotnet restore
RUN dotnet build --configuration Release

# Publish the app to a separate folder
RUN dotnet publish -c Release -o /app/publish

# Runtime image
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app/publish .

# Run the app
ENTRYPOINT ["dotnet", "FlightReservationSystemProject.dll"]
