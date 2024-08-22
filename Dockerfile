# См. статью по ссылке https://aka.ms/customizecontainer, чтобы узнать как настроить контейнер отладки и как Visual Studio использует этот Dockerfile для создания образов для ускорения отладки.

# Этот этап используется при запуске из VS в быстром режиме (по умолчанию для конфигурации отладки)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 80
EXPOSE 5016
EXPOSE 5432


# Этот этап используется для сборки проекта службы
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/Practice9_EntityFrameworkCore/Practice9_EFCore/Practice9_EFCore.csproj", "src/Practice9_EntityFrameworkCore/Practice9_EFCore/"]
RUN dotnet restore "./src/Practice9_EntityFrameworkCore/Practice9_EFCore/Practice9_EFCore.csproj"
COPY . .
WORKDIR "/src/src/Practice9_EntityFrameworkCore/Practice9_EFCore"
RUN dotnet build "./Practice9_EFCore.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Этот этап используется для публикации проекта службы, который будет скопирован на последний этап
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Practice9_EFCore.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Этот этап используется в рабочей среде или при запуске из VS в обычном режиме (по умолчанию, когда конфигурация отладки не используется)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Practice9_EFCore.dll"]