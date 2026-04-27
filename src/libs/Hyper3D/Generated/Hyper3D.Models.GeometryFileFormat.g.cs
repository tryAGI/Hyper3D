
#nullable enable

namespace Hyper3D
{
    /// <summary>
    /// 
    /// </summary>
    public enum GeometryFileFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Fbx,
        /// <summary>
        /// 
        /// </summary>
        Glb,
        /// <summary>
        /// 
        /// </summary>
        Obj,
        /// <summary>
        /// 
        /// </summary>
        Stl,
        /// <summary>
        /// 
        /// </summary>
        Usdz,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeometryFileFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeometryFileFormat value)
        {
            return value switch
            {
                GeometryFileFormat.Fbx => "fbx",
                GeometryFileFormat.Glb => "glb",
                GeometryFileFormat.Obj => "obj",
                GeometryFileFormat.Stl => "stl",
                GeometryFileFormat.Usdz => "usdz",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeometryFileFormat? ToEnum(string value)
        {
            return value switch
            {
                "fbx" => GeometryFileFormat.Fbx,
                "glb" => GeometryFileFormat.Glb,
                "obj" => GeometryFileFormat.Obj,
                "stl" => GeometryFileFormat.Stl,
                "usdz" => GeometryFileFormat.Usdz,
                _ => null,
            };
        }
    }
}