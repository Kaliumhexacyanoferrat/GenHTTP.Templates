# GenHTTP Templates

Templates to be used with `dotnet new` to quickly create projects based on
the [GenHTTP webserver](https://genhttp.org/).

## Installation

To install the template pack, run the following command in your terminal.

```
dotnet new -i GenHTTP.Templates
```

## Included Templates

To use one of the templates below, create a new folder and run `dotnet new <template>`.

| Template      | Description  | 
| ------------- |------------- | 
| `genhttp-webservice` | Creates a project that will host a new [REST web service](https://genhttp.org/documentation/content/webservices). |
| `genhttp-website-mvc-scriban` | Creates a dynamic website using the [MVC pattern](https://genhttp.org/documentation/content/controllers) and [Scriban](https://github.com/scriban/scriban/) as a templating engine. |
