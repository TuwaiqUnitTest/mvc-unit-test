FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MoviesApp/MoviesApp.csproj", "MoviesApp/"]
RUN dotnet restore "MoviesApp/MoviesApp.csproj"
COPY . .
WORKDIR "/src/MoviesApp"
RUN dotnet build "MoviesApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MoviesApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MoviesApp.dll"]
