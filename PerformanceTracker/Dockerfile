FROM mcr.microsoft.com/dotnet/sdk:6.0  AS base

WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish "PerformanceTrackerAPI.csproj" -c Release -o out


FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base2

WORKDIR /app
EXPOSE 80
ENV ConnectionStrings__DefaultConnection="Data source=/app/performancetracker.db"                                                                                                      

copy --from=base /app/out ./app/
copy --from=base "./app/performancetracker.db" ./

ENTRYPOINT ["dotnet", "./app/PerformanceTrackerAPI.dll"]

