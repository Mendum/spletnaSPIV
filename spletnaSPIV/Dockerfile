FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY bin/Release/net5.0/publish/ /app
ENV ASPNETCORE_URLS http://*:8000
EXPOSE 8000
ENTRYPOINT ["dotnet","spletnaSPIV.dll"]
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
#FROM mcr.microsoft.com/dotnet/aspnet:5.0
#COPY bin/Release/net5.0/publish/ App/
#WORKDIR /App
#ENTRYPOINT ["dotnet", "spletnaSPIV.dll"]
#-----------------------------------------------------------------------------------