# -- Stage 1 - Build process
FROM microsoft/dotnet:2.2-sdk as build

WORKDIR /api

COPY . ./api/

RUN dotnet restore ./api/StarwarsDocker.API.sln

RUN dotnet publish ./api/StarwarsDocker.API/StarwarsDocker.API.csproj --output /api/out/ --configuration Release --no-restore

# -- Stage 2 - Run app
FROM microsoft/dotnet:2.2-aspnetcore-runtime as api

ENV ASPNETCORE_ENVIRONMENT=Development

WORKDIR /app
EXPOSE 80

COPY --from=build ./api/out ./app

ENTRYPOINT ["dotnet", "./app/StarwarsDocker.API.dll"]