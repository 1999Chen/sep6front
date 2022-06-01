FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /WebApplication1

# copy csproj and restore as distinct layers
COPY . ./
COPY WebApplication1/WebApplication1.csproj ./WebApplication1/
RUN dotnet restore

# copy everything else and build app
COPY WebApplication1/. ./WebApplication1/
WORKDIR /WebApplication1
RUN dotnet publish -c release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /WebApplication1
COPY --from=build /WebApplication1 ./
ENTRYPOINT ["dotnet", "aspnetapp.dll"]

FROM mcr.microsoft.com/dotnet/aspnet:6.0
ARG BUILD_CONFIGURATION=Debug
ENV ASPNETCORE_ENVIRONMENT=Development
ENV DOTNET_USE_POLLING_FILE_WATCHER=true  
ENV ASPNETCORE_URLS=http://+:80 
EXPOSE 80


