FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["DomainUpdate/DomainUpdate.csproj", "DomainUpdate/"]
RUN dotnet restore "DomainUpdate/DomainUpdate.csproj"
COPY . .
WORKDIR "/src/DomainUpdate"
RUN dotnet build "DomainUpdate.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DomainUpdate.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DomainUpdate.dll"]
