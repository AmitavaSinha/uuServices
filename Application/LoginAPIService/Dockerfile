FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app


FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY LoginAPIService.csproj LoginAPIService/
RUN dotnet restore LoginAPIService.csproj
COPY . .
WORKDIR /src/LoginAPIService
RUN dotnet build LoginAPIService.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish LoginAPIService.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "LoginAPIService.dll"]
EXPOSE 6001/tcp
ENV ASPNETCORE_URLS http://*:6001
