using Elk.EntityFrameworkCore;
using OnlineTranslation.Domain;

namespace OnlineTranslation.DataAccess.Ef
{
    public class ActionRepo : EfGenericRepo<Action>
    {
        public ActionRepo(AuthDbContext authContext) : base(authContext)
        { }
    }
}