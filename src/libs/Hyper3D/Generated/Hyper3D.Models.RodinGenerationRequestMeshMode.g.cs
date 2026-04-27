
#nullable enable

namespace Hyper3D
{
    /// <summary>
    /// 
    /// </summary>
    public enum RodinGenerationRequestMeshMode
    {
        /// <summary>
        /// 
        /// </summary>
        Quad,
        /// <summary>
        /// 
        /// </summary>
        Raw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RodinGenerationRequestMeshModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RodinGenerationRequestMeshMode value)
        {
            return value switch
            {
                RodinGenerationRequestMeshMode.Quad => "Quad",
                RodinGenerationRequestMeshMode.Raw => "Raw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RodinGenerationRequestMeshMode? ToEnum(string value)
        {
            return value switch
            {
                "Quad" => RodinGenerationRequestMeshMode.Quad,
                "Raw" => RodinGenerationRequestMeshMode.Raw,
                _ => null,
            };
        }
    }
}