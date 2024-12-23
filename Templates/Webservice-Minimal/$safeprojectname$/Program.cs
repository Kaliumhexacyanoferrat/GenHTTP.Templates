using GenHTTP.Engine.Internal;

using GenHTTP.Modules.Practices;

using $safeprojectname$;

//
// GenHTTP Functional Framework Template
//
// URLs:
//   http://localhost:8080/devices/
//   http://localhost:8080/docs/
//   http://localhost:8080/openapi.json
//
// Framework documentation:
//   https://genhttp.org/documentation/content/frameworks/functional/
//
// Method definitions:
//   https://genhttp.org/documentation/content/concepts/definitions/
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
