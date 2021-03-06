// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Policy.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Policy : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Policy class.
        /// </summary>
        public Policy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Policy class.
        /// </summary>
        /// <param name="id">The identifier of the resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="location">The location of the resource.</param>
        /// <param name="tags">The tags of the resource.</param>
        /// <param name="description">The description of the policy.</param>
        /// <param name="status">The status of the policy. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="factName">The fact name of the policy (e.g.
        /// LabVmCount, LabVmSize, MaxVmsAllowedPerLab, etc. Possible values
        /// include: 'UserOwnedLabVmCount', 'UserOwnedLabPremiumVmCount',
        /// 'LabVmCount', 'LabPremiumVmCount', 'LabVmSize', 'GalleryImage',
        /// 'UserOwnedLabVmCountInSubnet', 'LabTargetCost',
        /// 'EnvironmentTemplate', 'ScheduleEditPermission'</param>
        /// <param name="factData">The fact data of the policy.</param>
        /// <param name="threshold">The threshold of the policy (i.e. a number
        /// for MaxValuePolicy, and a JSON array of values for
        /// AllowedValuesPolicy).</param>
        /// <param name="evaluatorType">The evaluator type of the policy (i.e.
        /// AllowedValuesPolicy, MaxValuePolicy). Possible values include:
        /// 'AllowedValuesPolicy', 'MaxValuePolicy'</param>
        /// <param name="createdDate">The creation date of the policy.</param>
        /// <param name="provisioningState">The provisioning status of the
        /// resource.</param>
        /// <param name="uniqueIdentifier">The unique immutable identifier of a
        /// resource (Guid).</param>
        public Policy(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string description = default(string), string status = default(string), string factName = default(string), string factData = default(string), string threshold = default(string), string evaluatorType = default(string), System.DateTime? createdDate = default(System.DateTime?), string provisioningState = default(string), string uniqueIdentifier = default(string))
            : base(id, name, type, location, tags)
        {
            Description = description;
            Status = status;
            FactName = factName;
            FactData = factData;
            Threshold = threshold;
            EvaluatorType = evaluatorType;
            CreatedDate = createdDate;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the description of the policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the status of the policy. Possible values include:
        /// 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the fact name of the policy (e.g. LabVmCount,
        /// LabVmSize, MaxVmsAllowedPerLab, etc. Possible values include:
        /// 'UserOwnedLabVmCount', 'UserOwnedLabPremiumVmCount', 'LabVmCount',
        /// 'LabPremiumVmCount', 'LabVmSize', 'GalleryImage',
        /// 'UserOwnedLabVmCountInSubnet', 'LabTargetCost',
        /// 'EnvironmentTemplate', 'ScheduleEditPermission'
        /// </summary>
        [JsonProperty(PropertyName = "properties.factName")]
        public string FactName { get; set; }

        /// <summary>
        /// Gets or sets the fact data of the policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.factData")]
        public string FactData { get; set; }

        /// <summary>
        /// Gets or sets the threshold of the policy (i.e. a number for
        /// MaxValuePolicy, and a JSON array of values for
        /// AllowedValuesPolicy).
        /// </summary>
        [JsonProperty(PropertyName = "properties.threshold")]
        public string Threshold { get; set; }

        /// <summary>
        /// Gets or sets the evaluator type of the policy (i.e.
        /// AllowedValuesPolicy, MaxValuePolicy). Possible values include:
        /// 'AllowedValuesPolicy', 'MaxValuePolicy'
        /// </summary>
        [JsonProperty(PropertyName = "properties.evaluatorType")]
        public string EvaluatorType { get; set; }

        /// <summary>
        /// Gets the creation date of the policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDate")]
        public System.DateTime? CreatedDate { get; private set; }

        /// <summary>
        /// Gets the provisioning status of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the unique immutable identifier of a resource (Guid).
        /// </summary>
        [JsonProperty(PropertyName = "properties.uniqueIdentifier")]
        public string UniqueIdentifier { get; private set; }

    }
}
