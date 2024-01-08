using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GenHTTP.Api.Content;

using GenHTTP.Modules.Layouting;
using GenHTTP.Modules.Security;
using GenHTTP.Modules.Webservices;

using $safeprojectname$.Services;

namespace $safeprojectname$
{
    
    public static class Project
    {

        public static IHandlerBuilder Setup()
        {
            return Layout.Create()
                         .AddService<BookService>("books")
                         .Add(CorsPolicy.Permissive());
        }

    }

}
