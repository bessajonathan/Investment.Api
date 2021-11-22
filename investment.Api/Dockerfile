FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Investment.Api.csproj", "Investment.Api/"]
RUN dotnet restore "Investment.Api/Investment.Api.csproj"
COPY . .
WORKDIR "/src/investment.Api"
RUN dotnet build "Investment.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Investment.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Investment.Api.dll"]