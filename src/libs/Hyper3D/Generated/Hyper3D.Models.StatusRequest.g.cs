
#nullable enable

namespace Hyper3D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StatusRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriptionKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusRequest" /> class.
        /// </summary>
        /// <param name="subscriptionKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StatusRequest(
            string subscriptionKey)
        {
            this.SubscriptionKey = subscriptionKey ?? throw new global::System.ArgumentNullException(nameof(subscriptionKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusRequest" /> class.
        /// </summary>
        public StatusRequest()
        {
        }
    }
}