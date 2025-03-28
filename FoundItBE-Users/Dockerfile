FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app
ARG PASSWORD_ENV_SEEDED

RUN mkdir /https
RUN dotnet dev-certs https -ep /https/aspnetapp.pfx -p jadlljames

# Copy project files and restore dependencies
COPY FoundItBE-Users.csproj .
RUN dotnet restore

# Copy the entire source code and build the application
COPY . .
RUN dotnet build "FoundItBE-Users.csproj" -c Release -o /out

# Publish the application
RUN dotnet publish "FoundItBE-Users.csproj" -c Release -o /publish

# Use the ASP.NET runtime for running the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /root/.dotnet/corefx/cryptography/x509stores/my/* /root/.dotnet/corefx/cryptography/x509stores/my/
COPY --chmod=0755 --from=build /https/* /https/

COPY --from=build /publish .
ENTRYPOINT ["dotnet", "FoundItBE-Users.dll"]