using GenHTTP.Engine.Internal;

using GenHTTP.Modules.Practices;

using $safeprojectname$;

//
// GenHTTP Server Sent Events Template
//
// URLs:
//   http://localhost:8080/
//
// Handler documentation:
//   https://genhttp.org/documentation/content/handlers/server-sent-events/
//
// Additional features:
//   https://genhttp.org/documentation/content/
//

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
