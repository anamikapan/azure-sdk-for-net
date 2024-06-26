// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement
{
    internal class ApiManagementPrivateEndpointConnectionOperationSource : IOperationSource<ApiManagementPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal ApiManagementPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        ApiManagementPrivateEndpointConnectionResource IOperationSource<ApiManagementPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ApiManagementPrivateEndpointConnectionData.DeserializeApiManagementPrivateEndpointConnectionData(document.RootElement);
            return new ApiManagementPrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<ApiManagementPrivateEndpointConnectionResource> IOperationSource<ApiManagementPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ApiManagementPrivateEndpointConnectionData.DeserializeApiManagementPrivateEndpointConnectionData(document.RootElement);
            return new ApiManagementPrivateEndpointConnectionResource(_client, data);
        }
    }
}
