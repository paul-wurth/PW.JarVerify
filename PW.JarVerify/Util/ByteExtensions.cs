﻿namespace JarVerify.Util
{
    public static class ByteExtensions
    {
        public static string ToBase64(this byte[] @this)
        {
            return Convert.ToBase64String(@this);
        }
    }
}
