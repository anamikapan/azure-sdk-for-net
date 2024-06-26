// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Get Data Plane read only token request definition. </summary>
    public partial class DataFactoryDataPlaneUserAccessPolicy
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

        /// <summary> Initializes a new instance of <see cref="DataFactoryDataPlaneUserAccessPolicy"/>. </summary>
        public DataFactoryDataPlaneUserAccessPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataFactoryDataPlaneUserAccessPolicy"/>. </summary>
        /// <param name="permissions"> The string with permissions for Data Plane access. Currently only 'r' is supported which grants read only access. </param>
        /// <param name="accessResourcePath"> The resource path to get access relative to factory. Currently only empty string is supported which corresponds to the factory resource. </param>
        /// <param name="profileName"> The name of the profile. Currently only the default is supported. The default value is DefaultProfile. </param>
        /// <param name="startOn"> Start time for the token. If not specified the current time will be used. </param>
        /// <param name="expireOn"> Expiration time for the token. Maximum duration for the token is eight hours and by default the token will expire in eight hours. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataFactoryDataPlaneUserAccessPolicy(string permissions, string accessResourcePath, string profileName, DateTimeOffset? startOn, DateTimeOffset? expireOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Permissions = permissions;
            AccessResourcePath = accessResourcePath;
            ProfileName = profileName;
            StartOn = startOn;
            ExpireOn = expireOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The string with permissions for Data Plane access. Currently only 'r' is supported which grants read only access. </summary>
        public string Permissions { get; set; }
        /// <summary> The resource path to get access relative to factory. Currently only empty string is supported which corresponds to the factory resource. </summary>
        public string AccessResourcePath { get; set; }
        /// <summary> The name of the profile. Currently only the default is supported. The default value is DefaultProfile. </summary>
        public string ProfileName { get; set; }
        /// <summary> Start time for the token. If not specified the current time will be used. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> Expiration time for the token. Maximum duration for the token is eight hours and by default the token will expire in eight hours. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
    }
}
