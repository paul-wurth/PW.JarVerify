﻿using System.Runtime.Serialization;

namespace JarVerify.Exceptions
{
    /// <summary>
    /// Errors relating to certificate information being missing
    /// </summary>
    [Serializable]
    public class MissingCertificateException : Exception
    {
        public MissingCertificateException()
        {
        }

        public MissingCertificateException(string message)
            : base(message)
        {
        }

        public MissingCertificateException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected MissingCertificateException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }

            base.GetObjectData(info, context);
        }
    }
}
