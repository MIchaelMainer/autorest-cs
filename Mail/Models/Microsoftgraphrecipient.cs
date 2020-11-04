// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Graph.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// recipient
    /// </summary>
    public partial class Microsoftgraphrecipient
    {
        /// <summary>
        /// Initializes a new instance of the Microsoftgraphrecipient class.
        /// </summary>
        public Microsoftgraphrecipient()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Microsoftgraphrecipient class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        public Microsoftgraphrecipient(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), MicrosoftgraphemailAddress emailAddress = default(MicrosoftgraphemailAddress))
        {
            AdditionalProperties = additionalProperties;
            EmailAddress = emailAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "emailAddress")]
        public MicrosoftgraphemailAddress EmailAddress { get; set; }

    }
}
