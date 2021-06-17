ARG version
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

WORKDIR /install

RUN apt-get -y update
RUN apt-get -y install curl
RUN apt-get -y install unzip

WORKDIR /source

# copy csproj and restore as distinct layers
COPY jenuine-api/* ./jenuine-api/
COPY jenuine-api.sln .

RUN dotnet restore jenuine-api/jenuine-api.csproj
RUN dotnet publish jenuine-api/jenuine-api.csproj -c release -o /app --no-restore -p:PackageVersion=${version}

##### final stage/image
FROM mcr.microsoft.com/dotnet/runtime:5.0

RUN apt-get -y update
RUN apt-get -y install curl

WORKDIR /app
COPY --from=build /app .
COPY run.bash /app
RUN ls -lrt

ENTRYPOINT ["./run.bash"]