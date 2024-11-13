using GenHTTP.Api.Protocol;

using GenHTTP.Modules.Controllers;

using $safeprojectname$.Model;

namespace $safeprojectname$.Controllers;

// For documentation, see: https://genhttp.org/documentation/content/frameworks/controllers/

public class DeviceController
{

    public List<DeviceSummary> Index()
    {
       // GET http://localhost:8080/devices/
       return [new(Guid.NewGuid(), "Some Device")];
    }

    public DeviceDetails? Index([FromPath] Guid id)
    {
        // GET http://localhost:8080/devices/:id/
        return new(id, "Some Device", "127.0.0.1");
    }

    [ControllerAction(RequestMethod.Put)]
    public Guid Add(DeviceDetails device)
    {
        // PUT http://localhost:8080/devices/add/
        throw new NotImplementedException();
    }

    [ControllerAction(RequestMethod.Post)]
    public Guid? Update(DeviceDetails book)
    {
        // POST http://localhost:8080/devices/update/
        throw new NotImplementedException();
    }

    [ControllerAction(RequestMethod.Delete)]
    public Guid? Remove([FromPath] Guid id)
    {
        // DELETE http://localhost:8080/devices/remove/:id/
        throw new NotImplementedException();
    }

}
