using Elk.EntityFrameworkCore;
using OnlineTranslation.Domain;

namespace OnlineTranslation.DataAccess.Ef
{
    public class UserInRoleRepo : EfGenericRepo<UserInRole>
    {
        public UserInRoleRepo(AuthDbContext authContext) : base(authContext)
        { }
    }
}