using System.Collections.Generic;

using GenHTTP.Modules.Webservices;

using Server.Model;

namespace Server.Services
{

    public class TaskResource
    {

        private readonly List<Task> _Tasks = new List<Task>()
        {
            new Task() { ID = 1, Title = "Compile and run project", Completed = true },
            new Task() { ID = 2, Title = "Deploy to Docker", Completed = false }
        };

        [Method]
        public List<Task> List() => _Tasks;

    }

}
