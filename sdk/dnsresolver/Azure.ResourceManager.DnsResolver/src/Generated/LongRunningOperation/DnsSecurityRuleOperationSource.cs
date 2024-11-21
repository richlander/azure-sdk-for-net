// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DnsResolver
{
    internal class DnsSecurityRuleOperationSource : IOperationSource<DnsSecurityRuleResource>
    {
        private readonly ArmClient _client;

        internal DnsSecurityRuleOperationSource(ArmClient client)
        {
            _client = client;
        }

        DnsSecurityRuleResource IOperationSource<DnsSecurityRuleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DnsSecurityRuleData.DeserializeDnsSecurityRuleData(document.RootElement);
            return new DnsSecurityRuleResource(_client, data);
        }

        async ValueTask<DnsSecurityRuleResource> IOperationSource<DnsSecurityRuleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DnsSecurityRuleData.DeserializeDnsSecurityRuleData(document.RootElement);
            return new DnsSecurityRuleResource(_client, data);
        }
    }
}
