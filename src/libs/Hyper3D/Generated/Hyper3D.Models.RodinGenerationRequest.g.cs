
#nullable enable

namespace Hyper3D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RodinGenerationRequest
    {
        /// <summary>
        /// Generation tier, such as Gen-2, Regular, Detail, Smooth, or Sketch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        public string? Tier { get; set; }

        /// <summary>
        /// Image input. Repeat this multipart field for multi-view input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public byte[]? Images { get; set; }

        /// <summary>
        /// Image input. Repeat this multipart field for multi-view input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagesname")]
        public string? Imagesname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_original_alpha")]
        public bool? UseOriginalAlpha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hyper3D.JsonConverters.RodinGenerationRequestConditionModeJsonConverter))]
        public global::Hyper3D.RodinGenerationRequestConditionMode? ConditionMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hyper3D.JsonConverters.RodinGenerationRequestMaterialJsonConverter))]
        public global::Hyper3D.RodinGenerationRequestMaterial? Material { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hyper3D.JsonConverters.RodinGenerationRequestQualityJsonConverter))]
        public global::Hyper3D.RodinGenerationRequestQuality? Quality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality_override")]
        public int? QualityOverride { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TAPose")]
        public bool? TAPose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox_condition")]
        public global::System.Collections.Generic.IList<int>? BboxCondition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mesh_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hyper3D.JsonConverters.RodinGenerationRequestMeshModeJsonConverter))]
        public global::Hyper3D.RodinGenerationRequestMeshMode? MeshMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mesh_simplify")]
        public bool? MeshSimplify { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mesh_smooth")]
        public bool? MeshSmooth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addons")]
        public global::System.Collections.Generic.IList<string>? Addons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_render")]
        public bool? PreviewRender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hd_texture")]
        public bool? HdTexture { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RodinGenerationRequest" /> class.
        /// </summary>
        /// <param name="tier">
        /// Generation tier, such as Gen-2, Regular, Detail, Smooth, or Sketch.
        /// </param>
        /// <param name="images">
        /// Image input. Repeat this multipart field for multi-view input.
        /// </param>
        /// <param name="imagesname">
        /// Image input. Repeat this multipart field for multi-view input.
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="useOriginalAlpha"></param>
        /// <param name="conditionMode"></param>
        /// <param name="seed"></param>
        /// <param name="geometryFileFormat"></param>
        /// <param name="material"></param>
        /// <param name="quality"></param>
        /// <param name="qualityOverride"></param>
        /// <param name="tAPose"></param>
        /// <param name="bboxCondition"></param>
        /// <param name="meshMode"></param>
        /// <param name="meshSimplify"></param>
        /// <param name="meshSmooth"></param>
        /// <param name="addons"></param>
        /// <param name="previewRender"></param>
        /// <param name="hdTexture"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RodinGenerationRequest(
            string? tier,
            byte[]? images,
            string? imagesname,
            string? prompt,
            bool? useOriginalAlpha,
            global::Hyper3D.RodinGenerationRequestConditionMode? conditionMode,
            int? seed,
            global::Hyper3D.GeometryFileFormat? geometryFileFormat,
            global::Hyper3D.RodinGenerationRequestMaterial? material,
            global::Hyper3D.RodinGenerationRequestQuality? quality,
            int? qualityOverride,
            bool? tAPose,
            global::System.Collections.Generic.IList<int>? bboxCondition,
            global::Hyper3D.RodinGenerationRequestMeshMode? meshMode,
            bool? meshSimplify,
            bool? meshSmooth,
            global::System.Collections.Generic.IList<string>? addons,
            bool? previewRender,
            bool? hdTexture)
        {
            this.Tier = tier;
            this.Images = images;
            this.Imagesname = imagesname;
            this.Prompt = prompt;
            this.UseOriginalAlpha = useOriginalAlpha;
            this.ConditionMode = conditionMode;
            this.Seed = seed;
            this.GeometryFileFormat = geometryFileFormat;
            this.Material = material;
            this.Quality = quality;
            this.QualityOverride = qualityOverride;
            this.TAPose = tAPose;
            this.BboxCondition = bboxCondition;
            this.MeshMode = meshMode;
            this.MeshSimplify = meshSimplify;
            this.MeshSmooth = meshSmooth;
            this.Addons = addons;
            this.PreviewRender = previewRender;
            this.HdTexture = hdTexture;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RodinGenerationRequest" /> class.
        /// </summary>
        public RodinGenerationRequest()
        {
        }
    }
}