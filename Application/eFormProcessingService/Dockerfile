FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app


FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY eFormProcessingService.csproj eFormProcessingService/
RUN dotnet restore eFormProcessingService.csproj
COPY . .
WORKDIR /src/eFormProcessingService
RUN dotnet build eFormProcessingService.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish eFormProcessingService.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "eFormProcessingService.dll"]
EXPOSE 2946/tcp
ENV ASPNETCORE_URLS http://*:2946
