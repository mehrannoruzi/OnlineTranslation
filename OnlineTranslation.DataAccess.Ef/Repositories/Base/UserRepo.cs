using Elk.EntityFrameworkCore;
using OnlineTranslation.Domain;

namespace OnlineTranslation.DataAccess.Ef
{
    public class UserRepo : EfGenericRepo<User>, IUserRepo
    {
        readonly AppDbContext _appContext;
        public UserRepo(AppDbContext appContext) : base(appContext)
        {
            _appContext = appContext;
        }
    }
}