
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Hyper3D
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Hyper3D.JsonConverters.RodinGenerationRequestConditionModeJsonConverter),

            typeof(global::Hyper3D.JsonConverters.RodinGenerationRequestConditionModeNullableJsonConverter),

            typeof(global::Hyper3D.JsonConverters.RodinGenerationRequestMaterialJsonConverter),

            typeof(global::Hyper3D.JsonConverters.RodinGenerationRequestMaterialNullableJsonConverter),

            typeof(global::Hyper3D.JsonConverters.RodinGenerationRequestQualityJsonConverter),

            typeof(global::Hyper3D.JsonConverters.RodinGenerationRequestQualityNullableJsonConverter),

            typeof(global::Hyper3D.JsonConverters.RodinGenerationRequestMeshModeJsonConverter),

            typeof(global::Hyper3D.JsonConverters.RodinGenerationRequestMeshModeNullableJsonConverter),

            typeof(global::Hyper3D.JsonConverters.TextureOnlyRequestMaterialJsonConverter),

            typeof(global::Hyper3D.JsonConverters.TextureOnlyRequestMaterialNullableJsonConverter),

            typeof(global::Hyper3D.JsonConverters.TextureOnlyRequestResolutionJsonConverter),

            typeof(global::Hyper3D.JsonConverters.TextureOnlyRequestResolutionNullableJsonConverter),

            typeof(global::Hyper3D.JsonConverters.GeometryFileFormatJsonConverter),

            typeof(global::Hyper3D.JsonConverters.GeometryFileFormatNullableJsonConverter),

            typeof(global::Hyper3D.JsonConverters.StatusResponseVariant2JobStatusJsonConverter),

            typeof(global::Hyper3D.JsonConverters.StatusResponseVariant2JobStatusNullableJsonConverter),

            typeof(global::Hyper3D.JsonConverters.TaskSubmissionResponseJsonConverter),

            typeof(global::Hyper3D.JsonConverters.StatusResponseJsonConverter),

            typeof(global::Hyper3D.JsonConverters.DownloadResponseJsonConverter),

            typeof(global::Hyper3D.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.CommonError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.RodinGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.RodinGenerationRequestConditionMode), TypeInfoPropertyName = "RodinGenerationRequestConditionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.GeometryFileFormat), TypeInfoPropertyName = "GeometryFileFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.RodinGenerationRequestMaterial), TypeInfoPropertyName = "RodinGenerationRequestMaterial2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.RodinGenerationRequestQuality), TypeInfoPropertyName = "RodinGenerationRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.RodinGenerationRequestMeshMode), TypeInfoPropertyName = "RodinGenerationRequestMeshMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.TextureOnlyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.TextureOnlyRequestMaterial), TypeInfoPropertyName = "TextureOnlyRequestMaterial2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.TextureOnlyRequestResolution), TypeInfoPropertyName = "TextureOnlyRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.TaskSubmissionResponse), TypeInfoPropertyName = "TaskSubmissionResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.TaskSubmissionResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.TaskSubmissionResponseVariant2Jobs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.StatusRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.StatusResponse), TypeInfoPropertyName = "StatusResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.StatusResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Hyper3D.StatusResponseVariant2Job>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.StatusResponseVariant2Job))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.StatusResponseVariant2JobStatus), TypeInfoPropertyName = "StatusResponseVariant2JobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.DownloadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.DownloadResponse), TypeInfoPropertyName = "DownloadResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.DownloadResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Hyper3D.DownloadResponseVariant2ListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.DownloadResponseVariant2ListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Hyper3D.BalanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Hyper3D.StatusResponseVariant2Job>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Hyper3D.DownloadResponseVariant2ListItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}