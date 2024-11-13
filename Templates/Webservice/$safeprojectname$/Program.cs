using GenHTTP.Engine.Internal;

using GenHTTP.Modules.Practices;

using $safeprojectname$;

// run this project and access the api at http://localhost:8080/books/
// service specification at http://localhost:8080/openapi.json

var project = Project.Setup();

return await Host.Create()
                 .Handler(project)
                 .Defaults()
                 .Console()
//-:cnd:noEmit
#if DEBUG
                 .Development()
#endif
//+:cnd:noEmit
                 .RunAsync();
