namespace PasswordValidator;

public static class PasswordValidator
{
    public static bool IsValid(string password)
    {
        if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
            return false;

        bool hasDigit = false;
        bool hasLatin = false;

        foreach (var ch in password)
        {
            if (char.IsDigit(ch))
                hasDigit = true;
            else if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
                hasLatin = true;

            if (hasDigit && hasLatin)
                return true;
        }

        return false;
    }
}