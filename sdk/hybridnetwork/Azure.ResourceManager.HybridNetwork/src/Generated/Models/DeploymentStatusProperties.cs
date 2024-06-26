// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The deployment status properties of the network function component. </summary>
    public partial class DeploymentStatusProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DeploymentStatusProperties"/>. </summary>
        internal DeploymentStatusProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeploymentStatusProperties"/>. </summary>
        /// <param name="status"> The status of the component resource. </param>
        /// <param name="resources"> The resource related to the component resource. </param>
        /// <param name="nextExpectedUpdateOn"> The next expected update of deployment status. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeploymentStatusProperties(ComponentStatus? status, ComponentKubernetesResources resources, DateTimeOffset? nextExpectedUpdateOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            Resources = resources;
            NextExpectedUpdateOn = nextExpectedUpdateOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The status of the component resource. </summary>
        public ComponentStatus? Status { get; }
        /// <summary> The resource related to the component resource. </summary>
        public ComponentKubernetesResources Resources { get; }
        /// <summary> The next expected update of deployment status. </summary>
        public DateTimeOffset? NextExpectedUpdateOn { get; }
    }
}
