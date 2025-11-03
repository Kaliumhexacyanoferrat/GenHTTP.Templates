# GenHTTP Templates

Templates to be used with `dotnet new` to quickly create projects based on
the [GenHTTP webserver](https://genhttp.org/).

[![Build](https://github.com/Kaliumhexacyanoferrat/GenHTTP.Templates/actions/workflows/build.yml/badge.svg)](https://github.com/Kaliumhexacyanoferrat/GenHTTP.Templates/actions/workflows/build.yml) [![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=Kaliumhexacyanoferrat_GenHTTP.Templates&metric=ncloc)](https://sonarcloud.io/dashboard?id=Kaliumhexacyanoferrat_GenHTTP.Templates) [![nuget Package](https://img.shields.io/nuget/v/GenHTTP.Templates.svg)](https://www.nuget.org/packages/GenHTTP.Templates/)

## Installation

To install the template pack, run the following command in your terminal.

```
dotnet new install GenHTTP.Templates
```

## Included Templates

To use one of the templates below, create a new folder and run `dotnet new <template>` in your terminal.

| Template                         | Description                                                                                                                                             | 
|----------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------| 
| `genhttp-webservice`             | A project that will host a new [REST web service](https://genhttp.org/documentation/content/frameworks/webservices/).                                   |
| `genhttp-webservice-minimal`     | A project that will host a new [REST web service](https://genhttp.org/documentation/content/frameworks/functional/) in a single file.                   |
| `genhttp-webservice-controllers` | A project that will host a new REST web service using [controllers](https://genhttp.org/documentation/content/frameworks/controllers/).                 |
| `genhttp-websocket`              | A project providing a web socket endpoint using the [websocket](https://genhttp.org/documentation/content/frameworks/websockets/) framework.            |
| `genhttp-sse`                    | A project providing a SSE event source using the [Server Sent Events](https://genhttp.org/documentation/content/handlers/server-sent-events/) handler.  |
| `genhttp-website-static`         | Project to serve a [static website](https://genhttp.org/documentation/content/frameworks/static-websites/) from the file system.                        |
| `genhttp-spa`                    | Project to serve the distribution files of a [Single Page Application](https://genhttp.org/documentation/content/frameworks/single-page-applications/). |

## Template Development

To start development of the templates itself, clone the repository and run the following command
in the new directory:

```
dotnet new install .
```
