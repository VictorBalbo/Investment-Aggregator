using InvestmentHub.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InvestmentHub.Providers
{
    public interface IProvider
    {
        Task<bool> LoginAsync(string userName, string userPassword, string code, CancellationToken cancellationToken);

        Task<IEnumerable<Asset>> GetAssetsAsync(CancellationToken cancellationToken);
    }
}
