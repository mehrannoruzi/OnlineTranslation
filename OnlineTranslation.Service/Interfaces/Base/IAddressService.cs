using System;
using Elk.Core;
using System.Threading.Tasks;
using OnlineTranslation.Domain;

namespace OnlineTranslation.Service
{
    public interface IAddressService
    {
        IResponse<PagingListDetails<AddressDTO>> Get(Guid userId);
        Task<IResponse<Address>> FindAsync(int id);
    }
}