namespace PasswordValidator;

public static class PasswordValidator
{
    public static bool IsValid(string password)
    {
        if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
            return false;

        bool hasDigit = false;
        bool hasLatin = false;

        foreach (var c in password)
        {
            if (char.IsDigit(c))
                hasDigit = true;
            else if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                hasLatin = true;

        }

        return hasDigit && hasLatin;
    }
}
