using System;

namespace $safeprojectname$.Model
{
   
    public record DeviceSummary(Guid ID, string Name);

    public record DeviceDetails(Guid ID, string Name, string Address);

}
