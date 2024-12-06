namespace PasswordManager.Models
{
    public class PasswordEntry
    {
        public int Id { get; set; }
        public string Service { get; set; }
        public string Username { get; set; }
        public string EncryptedPassword { get; set; }
    }
} 