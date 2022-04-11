namespace JarVerify.Cryptography
{
    public interface IVerificationCertificates
    {
        void Add(string baseName, byte[] certificate);

        bool Contains(string baseName);

        byte[] Get(string baseName);
    }
}
