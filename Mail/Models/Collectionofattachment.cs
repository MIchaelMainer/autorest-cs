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
    /// Collection of attachment
    /// </summary>
    public partial class Collectionofattachment
    {
        /// <summary>
        /// Initializes a new instance of the Collectionofattachment class.
        /// </summary>
        public Collectionofattachment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Collectionofattachment class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        public Collectionofattachment(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IList<Microsoftgraphattachment> value = default(IList<Microsoftgraphattachment>), string odatanextLink = default(string))
        {
            AdditionalProperties = additionalProperties;
            Value = value;
            OdatanextLink = odatanextLink;
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
        [JsonProperty(PropertyName = "value")]
        public IList<Microsoftgraphattachment> Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "@odata.nextLink")]
        public string OdatanextLink { get; set; }

    }
}
