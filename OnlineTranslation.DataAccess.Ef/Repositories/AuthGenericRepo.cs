using Elk.EntityFrameworkCore;

namespace OnlineTranslation.DataAccess.Ef
{
    public class AuthGenericRepo<T> : EfGenericRepo<T> where T : class
    {
        public AuthGenericRepo(AuthDbContext authDbContext) : base(authDbContext) { }
    }
}