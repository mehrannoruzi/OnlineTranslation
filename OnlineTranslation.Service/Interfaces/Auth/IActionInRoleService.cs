using Elk.Core;
using System.Threading.Tasks;
using OnlineTranslation.Domain;
using System.Collections.Generic;

namespace OnlineTranslation.Service
{
    public interface IActionInRoleService : IScopedInjection
    {
        Task<IResponse<ActionInRole>> AddAsync(ActionInRole model);
        Task<IResponse<bool>> DeleteAsync(int id);
        IEnumerable<ActionInRole> GetRoles(int actionId);
        IEnumerable<ActionInRole> GetActions(int roleId);
    }
}