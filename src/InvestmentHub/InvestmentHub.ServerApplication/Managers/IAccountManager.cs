﻿using InvestmentHub.Models;
using System.Threading;
using System.Threading.Tasks;

namespace InvestmentHub.ServerApplication.Managers
{
    public interface IAccountManager
    {
        Task<Account> AuthenticateAsync(Account account, CancellationToken cancellationToken);

        Task<Account> CreateAccountAsync(Account account, CancellationToken cancellationToken);

        Task<bool> UpdateAccountAsync(Account account, CancellationToken cancellationToken);

        Task<Account> GetAcountAsync(string identity, CancellationToken cancellationToken);

        Task<bool> DeleteAcountAsync(string identity, CancellationToken cancellationToken);
    }
}