FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MyDevTools/MyDevTools.csproj", "MyDevTools/"]
RUN dotnet restore "MyDevTools/MyDevTools.csproj"
COPY . .
WORKDIR "/src/MyDevTools"
RUN dotnet build "MyDevTools.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyDevTools.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyDevTools.dll"]
