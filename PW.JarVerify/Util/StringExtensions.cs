namespace JarVerify.Util
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string @this)
        {
            return @this == null || @this == String.Empty;
        }

        public static string ToForwardSlashes(this string @this)
        {
            // Super dumb but effective
            return @this.Replace(@"\", "/");
        }

    }
}
