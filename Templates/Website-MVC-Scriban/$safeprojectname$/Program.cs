using GenHTTP.Engine;

using GenHTTP.Modules.Practices;

using $safeprojectname$;

return Host.Create()
           .Handler(Project.Create())
           .Defaults()
           .Console()
//-:cnd:noEmit
#if DEBUG
           .Development()
#endif
//+:cnd:noEmit
           .Run();