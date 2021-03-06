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
    /// inferenceClassificationOverride
    /// </summary>
    public partial class MicrosoftgraphinferenceClassificationOverride : Microsoftgraphentity
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphinferenceClassificationOverride class.
        /// </summary>
        public MicrosoftgraphinferenceClassificationOverride()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphinferenceClassificationOverride class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="id">Read-only.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="classifyAs">Possible values include: 'focused',
        /// 'other'</param>
        public MicrosoftgraphinferenceClassificationOverride(string id = default(string), IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string classifyAs = default(string), MicrosoftgraphemailAddress senderEmailAddress = default(MicrosoftgraphemailAddress))
            : base(additionalProperties, id)
        {
            // AdditionalProperties = additionalProperties;
            ClassifyAs = classifyAs;
            SenderEmailAddress = senderEmailAddress;
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
        /// Gets or sets possible values include: 'focused', 'other'
        /// </summary>
        [JsonProperty(PropertyName = "classifyAs")]
        public string ClassifyAs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "senderEmailAddress")]
        public MicrosoftgraphemailAddress SenderEmailAddress { get; set; }

    }
}
