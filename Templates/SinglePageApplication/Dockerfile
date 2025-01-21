FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:9.0-alpine AS build
ARG TARGETARCH
WORKDIR /source

COPY --link $safeprojectname$/*.csproj .
RUN dotnet restore -a "$TARGETARCH"

COPY --link $safeprojectname$/. .
RUN dotnet publish --no-restore -a "$TARGETARCH" -o /app

# Enable globalization and time zones:
# https://github.com/dotnet/dotnet-docker/blob/main/samples/enable-globalization.md

FROM mcr.microsoft.com/dotnet/aspnet:9.0-alpine
EXPOSE 8080
WORKDIR /app
COPY --link --from=build /app .
USER $APP_UID
ENTRYPOINT ["./$safeprojectname$"]
