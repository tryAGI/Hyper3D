
#nullable enable

namespace Hyper3D
{
    /// <summary>
    ///
    /// </summary>
    public enum RodinGenerationRequestMaterial
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        None,
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
    public static class RodinGenerationRequestMaterialExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RodinGenerationRequestMaterial value)
        {
            return value switch
            {
                RodinGenerationRequestMaterial.All => "All",
                RodinGenerationRequestMaterial.None => "None",
                RodinGenerationRequestMaterial.Pbr => "PBR",
                RodinGenerationRequestMaterial.Shaded => "Shaded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RodinGenerationRequestMaterial? ToEnum(string value)
        {
            return value switch
            {
                "All" => RodinGenerationRequestMaterial.All,
                "None" => RodinGenerationRequestMaterial.None,
                "PBR" => RodinGenerationRequestMaterial.Pbr,
                "Shaded" => RodinGenerationRequestMaterial.Shaded,
                _ => null,
            };
        }
    }
}