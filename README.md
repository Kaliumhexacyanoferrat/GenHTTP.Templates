# GenHTTP Templates

Templates to be used with `dotnet new` to quickly create projects based on
the [GenHTTP webserver](https://genhttp.org/).

![CI](https://github.com/Kaliumhexacyanoferrat/GenHTTP.Website/workflows/CI/badge.svg) [![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=GenHTTP.Templates&metric=ncloc)](https://sonarcloud.io/dashboard?id=GenHTTP.Templates) [![nuget Package](https://img.shields.io/nuget/v/GenHTTP.Templates.svg)](https://www.nuget.org/packages/GenHTTP.Templates/)

## Installation

To install the template pack, run the following command in your terminal.

```
dotnet new -i GenHTTP.Templates
```

## Included Templates

To use one of the templates below, create a new folder and run `dotnet new <template>` in your terminal.

| Template      | Description  | 
| ------------- |------------- | 
| `genhttp-webservice` | A project that will host a new [REST web service](https://genhttp.org/documentation/content/webservices). |
| `genhttp-website` | A [website](https://genhttp.org/documentation/content/websites), mainly for static content such as a business website. |
| `genhttp-website-mvc-razor` | Dynamic website using the [MVC pattern](https://genhttp.org/documentation/content/controllers) and [Razor](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-5.0) as a templating engine. |
| `genhttp-website-mvc-scriban` | Dynamic website using the [MVC pattern](https://genhttp.org/documentation/content/controllers) and [Scriban](https://github.com/scriban/scriban/) as a templating engine. |
| `genhttp-website-static` | Project to serve a [static website](https://genhttp.org/documentation/content/static-websites) from the file system. |
