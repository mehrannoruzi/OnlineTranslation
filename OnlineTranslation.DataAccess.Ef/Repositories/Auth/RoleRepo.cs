using Elk.EntityFrameworkCore;
using OnlineTranslation.Domain;

namespace OnlineTranslation.DataAccess.Ef
{
    public class RoleRepo : EfGenericRepo<Role>
    {
        public RoleRepo(AuthDbContext authContext) : base(authContext)
        { }
    }
}