using Elk.EntityFrameworkCore;
using OnlineTranslation.Domain;

namespace OnlineTranslation.DataAccess.Ef
{
    public class ActionInRoleRepo : EfGenericRepo<ActionInRole>
    {
        public ActionInRoleRepo(AuthDbContext authContext) : base(authContext)
        { }
    }
}