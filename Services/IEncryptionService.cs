namespace PasswordManager.Services
{
    public interface IEncryptionService
    {
        string Encrypt(string password);
        string Decrypt(string encryptedPassword);
    }
} 