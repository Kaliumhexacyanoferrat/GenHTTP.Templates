using GenHTTP.Engine;

using GenHTTP.Modules.Practices;

using $safeprojectname$;

var project = Project.Create();

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
