FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DubberwangWeb/DubberwangWeb.csproj", "DubberwangWeb/"]
RUN dotnet restore "DubberwangWeb/DubberwangWeb.csproj"
COPY . .
WORKDIR "/src/DubberwangWeb"
RUN dotnet build "DubberwangWeb.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DubberwangWeb.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DubberwangWeb.dll"]
