
#nullable enable

namespace Hyper3D
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StatusResponseVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        public global::System.Collections.Generic.IList<global::Hyper3D.StatusResponseVariant2Job>? Jobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusResponseVariant2" /> class.
        /// </summary>
        /// <param name="jobs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StatusResponseVariant2(
            global::System.Collections.Generic.IList<global::Hyper3D.StatusResponseVariant2Job>? jobs)
        {
            this.Jobs = jobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusResponseVariant2" /> class.
        /// </summary>
        public StatusResponseVariant2()
        {
        }

    }
}