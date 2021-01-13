﻿using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Zo.Store.Identity
{
    [DependsOn(
        typeof(IdentityHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class IdentityConsoleApiClientModule : AbpModule
    {
        
    }
}
