# $safeprojectname$

*Add your project description here.*

## Development

To build this project from source, checkout this repository and execute
the following commands in your terminal. This requires the
[.NET SDK](https://dotnet.microsoft.com/download) to be installed.

```
cd $safeprojectname$
dotnet run
```

This will make the website available at http://localhost:8080/.

## Deployment

To run this project with [Docker](https://www.docker.com/), run the 
following commands in your terminal (and adjust the first line
depending on your platform).

```
docker build -f Dockerfile.linux-x64 -t $safeprojectname$ .

docker run -p 8080:8080 $safeprojectname$
```

## About

This project uses the [GenHTTP webserver](https://genhttp.org/) to
implement it's functionality.