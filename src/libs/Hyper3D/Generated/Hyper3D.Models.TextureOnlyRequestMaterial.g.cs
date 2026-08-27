
#nullable enable

namespace Hyper3D
{
    /// <summary>
    ///
    /// </summary>
    public enum TextureOnlyRequestMaterial
    {
        /// <summary>
        ///
        /// </summary>
        Pbr,
        /// <summary>
        ///
        /// </summary>
        Shaded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextureOnlyRequestMaterialExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextureOnlyRequestMaterial value)
        {
            return value switch
            {
                TextureOnlyRequestMaterial.Pbr => "PBR",
                TextureOnlyRequestMaterial.Shaded => "Shaded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextureOnlyRequestMaterial? ToEnum(string value)
        {
            return value switch
            {
                "PBR" => TextureOnlyRequestMaterial.Pbr,
                "Shaded" => TextureOnlyRequestMaterial.Shaded,
                _ => null,
            };
        }
    }
}