#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Hyper3D.JsonConverters
{
    /// <inheritdoc />
    public class StatusResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Hyper3D.StatusResponse>
    {
        /// <inheritdoc />
        public override global::Hyper3D.StatusResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Hyper3D.CommonError? commonError = default;
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

            global::Hyper3D.StatusResponseVariant2? statusResponseVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hyper3D.StatusResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hyper3D.StatusResponseVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hyper3D.StatusResponseVariant2).Name}");
                statusResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::Hyper3D.StatusResponse(
                commonError,

                statusResponseVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Hyper3D.StatusResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsCommonError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hyper3D.CommonError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hyper3D.CommonError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hyper3D.CommonError).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.CommonError!, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsStatusResponseVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Hyper3D.StatusResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Hyper3D.StatusResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Hyper3D.StatusResponseVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.StatusResponseVariant2!, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}