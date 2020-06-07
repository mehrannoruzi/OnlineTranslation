using Elk.Core;
using System.Threading.Tasks;

namespace OnlineTranslation.Domain
{
    public interface IUserRepo : IGenericRepo<User>, IScopedInjection
    {}
}
