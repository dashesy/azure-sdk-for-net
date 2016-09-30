// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information. 

namespace Microsoft.Azure.Management.Fluent.Resource.ResourceGroup.Update
{

    using Microsoft.Azure.Management.Fluent.Resource.Core.ResourceActions;
    using Microsoft.Azure.Management.Fluent.Resource;
    using Microsoft.Azure.Management.Fluent.Resource.Core.Resource.Update;

    /// <summary>
    /// The template for a resource group update operation, containing all the settings that can be modified.
    /// <p>
    /// Call {@link Update#apply()} to apply the changes to the resource group in Azure.
    /// </summary>
    public interface IUpdate  :
        IAppliable<IResourceGroup>,
        IUpdateWithTags<IUpdate>
    {
    }
}