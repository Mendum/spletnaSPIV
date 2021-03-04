# FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS build
# This code will download and use the last ASP.NET 5 Docker

# image based on Mono at

# https://github.com/aspnet/aspnet-docker/blob/master/1.0.0-

# rc1-update1/Dockerfile

FROM Microsoft/aspnet:latest

# This code copies the project into the folder and restores

# the packages using dotnet CLICOPY . /app

WORKDIR /app

RUN [“dotnet”,”restore”]

# Open this port in the container

EXPOSE 5001

# Start application using DNX and the command from

# project.json to call kestrel

ENTRYPOINT [“dotnet”,”run”]

Save and close Dockerfile.

Then, verify the existing containers:

$ sudo docker images

We can also check the running containers:

$ docker ps

You can build your application now:

$ docker build -t

Run it (port 5001 is the default port for Kestrel):

$ docker run-t -d -p 5001:5001