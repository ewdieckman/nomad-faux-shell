using Microsoft.Win32;

namespace EosFauxShell
{
    internal static class RegistryHelper
    {
        public const string RegistryKey = @"SOFTWARE\ETCFauxShell";
        public const string PasswordValue = "AdminPassword";

        public static string? RetrievePassword()
        {
            string? password = null;

            var fauxShellKey = Registry.CurrentUser.OpenSubKey(RegistryKey);

            if (fauxShellKey != null)
            {
                password = (string?)fauxShellKey.GetValue(PasswordValue);
                fauxShellKey.Close();
            }

            return password;
        }

        public static void SetPassword(string password)
        {
            var fauxShellKey = Registry.CurrentUser.OpenSubKey(RegistryKey, true);

            if (fauxShellKey == null)
                fauxShellKey = Registry.CurrentUser.CreateSubKey(RegistryKey);

            var passwordHasher = new PasswordHasher();
            var hashedPassword = passwordHasher.HashPassword(password);

            fauxShellKey.SetValue(PasswordValue, hashedPassword);

            fauxShellKey.Close();

        }
    }
}
