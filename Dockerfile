FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the project file from the subfolder
COPY SkinCareTips/*.csproj ./ 
RUN dotnet restore

# Copy everything else from the project folder
COPY SkinCareTips/. ./ 
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out ./

# Listen on Railway port
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "SkinCareTips.dll"]
