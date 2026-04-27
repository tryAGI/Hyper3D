
#nullable enable

namespace Hyper3D
{
    /// <summary>
    /// 
    /// </summary>
    public enum RodinGenerationRequestConditionMode
    {
        /// <summary>
        /// 
        /// </summary>
        Concat,
        /// <summary>
        /// 
        /// </summary>
        Fuse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RodinGenerationRequestConditionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RodinGenerationRequestConditionMode value)
        {
            return value switch
            {
                RodinGenerationRequestConditionMode.Concat => "concat",
                RodinGenerationRequestConditionMode.Fuse => "fuse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RodinGenerationRequestConditionMode? ToEnum(string value)
        {
            return value switch
            {
                "concat" => RodinGenerationRequestConditionMode.Concat,
                "fuse" => RodinGenerationRequestConditionMode.Fuse,
                _ => null,
            };
        }
    }
}