  #FROM mcr.microsoft.com/dotnet/core/aspnet:5.0
  #COPY bin/Release/net5.0/publish/ App/
  #WORKDIR /App
  #ENTRYPOINT ["dotnet", "spletnaSPIV.dll"]
  #-----------------------------------------------------------------------------------
#FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS build-env
#WORKDIR /app
#
#COPY *.csproj ./
#RUN dotnet restore
#
#COPY . ./
#RUN dotnet publish -c Release -o out
#
#FROM mcr.microsoft.com/dotnet/aspnet:5.0
#WORKDIR /app
#COPY --from=build-env /app/out .
#ENTRYPOINT ["dotnet", "spletnaSPIV.dll"]
#-----------------------------------------------------------------------------------
COPY bin/Release/net5.0/publish/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "spletnaSPIV.dll"]
#-----------------------------------------------------------------------------------

## FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS build
## This code will download and use the last ASP.NET 5 Docker
#
## image based on Mono at
#
## https://github.com/aspnet/aspnet-docker/blob/master/1.0.0-
#
## rc1-update1/Dockerfile
#
#FROM Microsoft/aspnet:latest
#
## This code copies the project into the folder and restores
#
## the packages using dotnet CLICOPY . /app
#
#WORKDIR /app
#
#RUN [“dotnet”,”restore”]
#
## Open this port in the container
#
#EXPOSE 5001
#
## Start application using DNX and the command from
#
## project.json to call kestrel
#
#ENTRYPOINT [“dotnet”,”run”]