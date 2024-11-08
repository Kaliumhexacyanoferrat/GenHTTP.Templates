using GenHTTP.Engine;

using GenHTTP.Modules.Practices;

using $safeprojectname$;

var project = Project.Setup();

// hosts your app on http://localhost:8080
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
