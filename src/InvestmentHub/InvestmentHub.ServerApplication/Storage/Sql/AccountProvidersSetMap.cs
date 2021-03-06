﻿using System;
using System.Reflection;
using InvestmentHub.Models;
using Take.Elephant.Sql;
using Take.Elephant.Sql.Mapping;

namespace InvestmentHub.ServerApplication.Storage.Sql
{
    internal class AccountProvidersSetMap : SqlSetMap<string, ProviderCredentials>, IAccountProvidersSetMap
    {
        public const string TABLE_NAME = "AccountProviders";

        private static readonly Func<PropertyInfo, bool> PropertyFilter = (p) => p.Name != nameof(ProviderCredentials.Password);

        public static ITable AccountProvidersTable = TableBuilder
            .WithName(TABLE_NAME)
            .WithColumnsFromTypeProperties<ProviderCredentials>(PropertyFilter)
            .WithKeyColumnsNames(nameof(ProviderCredentials.Email))
            .WithKeyColumnsNames(nameof(ProviderCredentials.ProviderName))
            .Build();

        public AccountProvidersSetMap(IConfigurations configurations)
            : base(configurations.SqlConnectionString, AccountProvidersTable, new ValueMapper<string>(nameof(ProviderCredentials.Email)), new TypeMapper<ProviderCredentials>(AccountProvidersTable, PropertyFilter))
        {
        }
    }
}
