using ContactLister.Data;
using Microsoft.EntityFrameworkCore;

namespace ContactLister.Helpers;

public static class DataHelper
{
    public static async Task ManageDataAsync(IServiceProvider svcProvider)
    {
        var dbContextsvc = svcProvider.GetRequiredService<ApplicationDbContext>();
        await dbContextsvc.Database.MigrateAsync();
    }
}
