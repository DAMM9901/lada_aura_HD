using PasswordManager.Models;

namespace PasswordManager.Services
{
    public interface IPasswordService
    {
        void AddPassword(PasswordEntry entry);
        List<PasswordEntry> GetAllPasswords();
        void DeletePassword(int id);
    }
} 