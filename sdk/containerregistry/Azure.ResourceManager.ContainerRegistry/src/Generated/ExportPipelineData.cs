// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary> A class representing the ExportPipeline data model. </summary>
    public partial class ExportPipelineData : ResourceData
    {
        /// <summary> Initializes a new instance of ExportPipelineData. </summary>
        public ExportPipelineData()
        {
            Options = new ChangeTrackingList<PipelineOption>();
        }

        /// <summary> Initializes a new instance of ExportPipelineData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The location of the export pipeline. </param>
        /// <param name="identity"> The identity of the export pipeline. </param>
        /// <param name="target"> The target properties of the export pipeline. </param>
        /// <param name="options"> The list of all options configured for the pipeline. </param>
        /// <param name="provisioningState"> The provisioning state of the pipeline at the time the operation was called. </param>
        internal ExportPipelineData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, ManagedServiceIdentity identity, ExportPipelineTargetProperties target, IList<PipelineOption> options, ContainerRegistryProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Identity = identity;
            Target = target;
            Options = options;
            ProvisioningState = provisioningState;
        }

        /// <summary> The location of the export pipeline. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> The identity of the export pipeline. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The target properties of the export pipeline. </summary>
        public ExportPipelineTargetProperties Target { get; set; }
        /// <summary> The list of all options configured for the pipeline. </summary>
        public IList<PipelineOption> Options { get; }
        /// <summary> The provisioning state of the pipeline at the time the operation was called. </summary>
        public ContainerRegistryProvisioningState? ProvisioningState { get; }
    }
}
