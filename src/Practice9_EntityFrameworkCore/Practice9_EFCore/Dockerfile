# См. статью по ссылке https://aka.ms/customizecontainer, чтобы узнать как настроить контейнер отладки и как Visual Studio использует этот Dockerfile для создания образов для ускорения отладки.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Practice9_EntityFrameworkCore/Practice9_EFCore/Practice9_EFCore.csproj", "src/Practice9_EntityFrameworkCore/Practice9_EFCore/"]
COPY ["src/Practice9_EntityFrameworkCore/Domain/Practice9_EFCore.Domain/Practice9_EFCore.Domain.csproj", "src/Practice9_EntityFrameworkCore/Domain/Practice9_EFCore.Domain/"]
COPY ["src/Practice9_EntityFrameworkCore/Infrastructure/Practice9_EFCore.Infrastructure/Practice9_EFCore.Infrastructure.csproj", "src/Practice9_EntityFrameworkCore/Infrastructure/Practice9_EFCore.Infrastructure/"]
COPY ["src/Practice9_EntityFrameworkCore/Services/Practice9_EFCore.Services/Practice9_EFCore.Services.csproj", "src/Practice9_EntityFrameworkCore/Services/Practice9_EFCore.Services/"]
RUN dotnet restore "./src/Practice9_EntityFrameworkCore/Practice9_EFCore/Practice9_EFCore.csproj"
COPY . .
WORKDIR "/src/src/Practice9_EntityFrameworkCore/Practice9_EFCore"
RUN dotnet build "./Practice9_EFCore.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Practice9_EFCore.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Practice9_EFCore.dll", "database", "update"]