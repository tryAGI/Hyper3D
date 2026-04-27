#nullable enable

namespace Hyper3D.JsonConverters
{
    /// <inheritdoc />
    public sealed class StatusResponseVariant2JobStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Hyper3D.StatusResponseVariant2JobStatus?>
    {
        /// <inheritdoc />
        public override global::Hyper3D.StatusResponseVariant2JobStatus? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Hyper3D.StatusResponseVariant2JobStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Hyper3D.StatusResponseVariant2JobStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Hyper3D.StatusResponseVariant2JobStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Hyper3D.StatusResponseVariant2JobStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Hyper3D.StatusResponseVariant2JobStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
