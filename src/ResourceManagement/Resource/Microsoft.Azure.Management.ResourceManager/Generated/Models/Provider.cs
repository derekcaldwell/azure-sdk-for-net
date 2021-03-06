// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System.Linq;

    /// <summary>
    /// Resource provider information.
    /// </summary>
    public partial class Provider
    {
        /// <summary>
        /// Initializes a new instance of the Provider class.
        /// </summary>
        public Provider() { }

        /// <summary>
        /// Initializes a new instance of the Provider class.
        /// </summary>
        /// <param name="id">The provider id.</param>
        /// <param name="namespaceProperty">The namespace of the
        /// provider.</param>
        /// <param name="registrationState">The registration state of the
        /// provider.</param>
        /// <param name="resourceTypes">The collection of provider resource
        /// types.</param>
        public Provider(string id = default(string), string namespaceProperty = default(string), string registrationState = default(string), System.Collections.Generic.IList<ProviderResourceType> resourceTypes = default(System.Collections.Generic.IList<ProviderResourceType>))
        {
            Id = id;
            NamespaceProperty = namespaceProperty;
            RegistrationState = registrationState;
            ResourceTypes = resourceTypes;
        }

        /// <summary>
        /// Gets the provider id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets the namespace of the provider.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "namespace")]
        public string NamespaceProperty { get; set; }

        /// <summary>
        /// Gets the registration state of the provider.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "registrationState")]
        public string RegistrationState { get; private set; }

        /// <summary>
        /// Gets the collection of provider resource types.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceTypes")]
        public System.Collections.Generic.IList<ProviderResourceType> ResourceTypes { get; private set; }

    }
}
