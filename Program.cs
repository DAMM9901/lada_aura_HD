using PasswordManager.Services;
using PasswordManager.Models;

namespace PasswordManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Менеджер паролей v1.0");
            
            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Добавить пароль");
                Console.WriteLine("2. Показать все пароли");
                Console.WriteLine("3. Удалить пароль");
                Console.WriteLine("4. Выход");

                var choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        // Будет реализовано в ветке add-password
                        break;
                    case "2":
                        // Будет реализовано в ветке view-passwords
                        break;
                    case "3":
                        // Будет реализовано в ветке delete-password
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            }
        }
    }
}
