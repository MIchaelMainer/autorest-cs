// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Graph.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// sizeRange
    /// </summary>
    public partial class MicrosoftgraphsizeRange
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphsizeRange class.
        /// </summary>
        public MicrosoftgraphsizeRange()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphsizeRange class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="maximumSize">The maximum size (in kilobytes) that an
        /// incoming message must have in order for a condition or exception to
        /// apply.</param>
        /// <param name="minimumSize">The minimum size (in kilobytes) that an
        /// incoming message must have in order for a condition or exception to
        /// apply.</param>
        public MicrosoftgraphsizeRange(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), int? maximumSize = default(int?), int? minimumSize = default(int?))
        {
            AdditionalProperties = additionalProperties;
            MaximumSize = maximumSize;
            MinimumSize = minimumSize;
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
        /// Gets or sets the maximum size (in kilobytes) that an incoming
        /// message must have in order for a condition or exception to apply.
        /// </summary>
        [JsonProperty(PropertyName = "maximumSize")]
        public int? MaximumSize { get; set; }

        /// <summary>
        /// Gets or sets the minimum size (in kilobytes) that an incoming
        /// message must have in order for a condition or exception to apply.
        /// </summary>
        [JsonProperty(PropertyName = "minimumSize")]
        public int? MinimumSize { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MaximumSize != null)
            {
                if (MaximumSize > 2147483647)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "MaximumSize", 2147483647);
                }
                if (MaximumSize < -2147483648)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "MaximumSize", -2147483648);
                }
            }
            if (MinimumSize != null)
            {
                if (MinimumSize > 2147483647)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "MinimumSize", 2147483647);
                }
                if (MinimumSize < -2147483648)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "MinimumSize", -2147483648);
                }
            }
        }
    }
}