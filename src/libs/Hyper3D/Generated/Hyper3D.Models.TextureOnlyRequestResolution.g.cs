
#nullable enable

namespace Hyper3D
{
    /// <summary>
    ///
    /// </summary>
    public enum TextureOnlyRequestResolution
    {
        /// <summary>
        ///
        /// </summary>
        Basic,
        /// <summary>
        ///
        /// </summary>
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextureOnlyRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextureOnlyRequestResolution value)
        {
            return value switch
            {
                TextureOnlyRequestResolution.Basic => "Basic",
                TextureOnlyRequestResolution.High => "High",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextureOnlyRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "Basic" => TextureOnlyRequestResolution.Basic,
                "High" => TextureOnlyRequestResolution.High,
                _ => null,
            };
        }
    }
}