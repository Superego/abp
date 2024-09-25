// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;
using Volo.CmsKit.Public.MarkedItems;

// ReSharper disable once CheckNamespace
namespace Volo.CmsKit.Public.MarkedItems;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IMarkedItemPublicAppService), typeof(MarkedItemPublicClientProxy))]
public partial class MarkedItemPublicClientProxy : ClientProxyBase<IMarkedItemPublicAppService>, IMarkedItemPublicAppService
{
    public virtual async Task<MarkedItemWithToggleDto> GetForUserAsync(string entityType, string entityId)
    {
        return await RequestAsync<MarkedItemWithToggleDto>(nameof(GetForUserAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), entityType },
            { typeof(string), entityId }
        });
    }

    public virtual async Task<bool> ToggleAsync(string entityType, string entityId)
    {
        return await RequestAsync<bool>(nameof(ToggleAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), entityType },
            { typeof(string), entityId }
        });
    }
}
