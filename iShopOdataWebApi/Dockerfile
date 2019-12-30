FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY iShopOdataWebApi/iShopOdataWebApi.csproj iShopOdataWebApi/
RUN dotnet restore iShopOdataWebApi/iShopOdataWebApi.csproj
COPY . .
WORKDIR /src/iShopOdataWebApi
RUN dotnet build iShopOdataWebApi.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish iShopOdataWebApi.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "iShopOdataWebApi.dll"]
