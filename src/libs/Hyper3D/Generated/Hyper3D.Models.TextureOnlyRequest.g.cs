
#nullable enable

namespace Hyper3D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextureOnlyRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public byte[]? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelname")]
        public string? Modelname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_scale")]
        public double? ReferenceScale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geometry_file_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hyper3D.JsonConverters.GeometryFileFormatJsonConverter))]
        public global::Hyper3D.GeometryFileFormat? GeometryFileFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("material")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hyper3D.JsonConverters.TextureOnlyRequestMaterialJsonConverter))]
        public global::Hyper3D.TextureOnlyRequestMaterial? Material { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hyper3D.JsonConverters.TextureOnlyRequestResolutionJsonConverter))]
        public global::Hyper3D.TextureOnlyRequestResolution? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextureOnlyRequest" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="imagename"></param>
        /// <param name="model"></param>
        /// <param name="modelname"></param>
        /// <param name="prompt"></param>
        /// <param name="seed"></param>
        /// <param name="referenceScale"></param>
        /// <param name="geometryFileFormat"></param>
        /// <param name="material"></param>
        /// <param name="resolution"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextureOnlyRequest(
            byte[]? image,
            string? imagename,
            byte[]? model,
            string? modelname,
            string? prompt,
            int? seed,
            double? referenceScale,
            global::Hyper3D.GeometryFileFormat? geometryFileFormat,
            global::Hyper3D.TextureOnlyRequestMaterial? material,
            global::Hyper3D.TextureOnlyRequestResolution? resolution)
        {
            this.Image = image;
            this.Imagename = imagename;
            this.Model = model;
            this.Modelname = modelname;
            this.Prompt = prompt;
            this.Seed = seed;
            this.ReferenceScale = referenceScale;
            this.GeometryFileFormat = geometryFileFormat;
            this.Material = material;
            this.Resolution = resolution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextureOnlyRequest" /> class.
        /// </summary>
        public TextureOnlyRequest()
        {
        }

    }
}