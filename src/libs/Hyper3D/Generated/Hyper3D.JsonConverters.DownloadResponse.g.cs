#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Hyper3D.JsonConverters
{
    /// <inheritdoc />
    public class DownloadResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Hyper3D.DownloadResponse>
    {
        /// <inheritdoc />
        public override global::Hyper3D.DownloadResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("error")) __score0++;
            if (__jsonProps.Contains("message")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("list")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Hyper3D.CommonError? commonError = default;
            global::Hyper3D.DownloadResponseVariant2? downloadResponseVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hyper3D.CommonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hyper3D.CommonError> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hyper3D.CommonError).Name}");
                        commonError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hyper3D.DownloadResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hyper3D.DownloadResponseVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hyper3D.DownloadResponseVariant2).Name}");
                        downloadResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (commonError == null && downloadResponseVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hyper3D.CommonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hyper3D.CommonError> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hyper3D.CommonError).Name}");
                    commonError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (commonError == null && downloadResponseVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hyper3D.DownloadResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hyper3D.DownloadResponseVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hyper3D.DownloadResponseVariant2).Name}");
                    downloadResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Hyper3D.DownloadResponse(
                commonError,

                downloadResponseVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Hyper3D.DownloadResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCommonError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hyper3D.CommonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hyper3D.CommonError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hyper3D.CommonError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CommonError!, typeInfo);
            }
            else if (value.IsDownloadResponseVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hyper3D.DownloadResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hyper3D.DownloadResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hyper3D.DownloadResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DownloadResponseVariant2!, typeInfo);
            }
        }
    }
}