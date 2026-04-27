
#nullable enable

namespace Hyper3D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskSubmissionResponseVariant2Jobs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuids")]
        public global::System.Collections.Generic.IList<string>? Uuids { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription_key")]
        public string? SubscriptionKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskSubmissionResponseVariant2Jobs" /> class.
        /// </summary>
        /// <param name="uuids"></param>
        /// <param name="subscriptionKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskSubmissionResponseVariant2Jobs(
            global::System.Collections.Generic.IList<string>? uuids,
            string? subscriptionKey)
        {
            this.Uuids = uuids;
            this.SubscriptionKey = subscriptionKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskSubmissionResponseVariant2Jobs" /> class.
        /// </summary>
        public TaskSubmissionResponseVariant2Jobs()
        {
        }
    }
}