# Build stage
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:10.0-alpine AS build
ARG TARGETARCH
WORKDIR /source

# Optional: enable full globalization support
# RUN apk add --no-cache icu-libs tzdata
# ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

COPY --link $safeprojectname$/*.csproj .
RUN dotnet restore -a "$TARGETARCH"

COPY --link $safeprojectname$/. .
RUN dotnet publish -c Release --no-restore -a "$TARGETARCH" -o /app

# Runtime stage
FROM mcr.microsoft.com/dotnet/runtime:10.0-alpine

# use this base image if you are using Kestrel as an engine
# FROM mcr.microsoft.com/dotnet/aspnet:10.0-alpine

ENV DOTNET_EnableDiagnostics=0 \
    DOTNET_gcServer=1 \
    DOTNET_TieredPGO=1 \
    DOTNET_ReadyToRun=1

WORKDIR /app
COPY --link --from=build /app .
USER $APP_UID

EXPOSE 8080
ENTRYPOINT ["dotnet", "$safeprojectname$.dll"]
