# GenHTTP Templates

Templates to be used with `dotnet new` to quickly create projects based on
the [GenHTTP webserver](https://genhttp.org/).

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
| `genhttp-website-mvc-razor` | Dynamic website using the [MVC pattern](https://genhttp.org/documentation/content/controllers) and [Razor](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-5.0) as a templating engine. |
| `genhttp-website-mvc-scriban` | Dynamic website using the [MVC pattern](https://genhttp.org/documentation/content/controllers) and [Scriban](https://github.com/scriban/scriban/) as a templating engine. |
