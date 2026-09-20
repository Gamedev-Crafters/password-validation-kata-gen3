namespace Project;

public class PasswordChecker {

    public static bool IsValidForRulesetOne(string password)
    {
        return HasMoreThanNumberCharacters(password, 8) && 
               HasUppercase(password) && 
               HasLowercase(password) &&
               HasNumber(password) &&
               HasUnderscore(password);
    }

    public static bool IsValidForRulesetTwo(string password)
    {
        return HasMoreThanNumberCharacters(password, 6) &&
               HasUppercase(password) &&
               HasLowercase(password) &&
               HasNumber(password);
    }

    public static bool IsValidForRulesetThree(string password)
    {
        return HasMoreThanNumberCharacters(password, 16) &&
               HasUppercase(password) &&
               HasLowercase(password) &&
               HasUnderscore(password);
    }
    
    public static bool HasMoreThanNumberCharacters(string password, int charCount)
    {
        return password.Length > charCount;
    }

    public static bool HasUppercase(string password)
    {
        return password.ToLower() != password;
    }
    
    public static bool HasLowercase(string password)
    {
        return password.ToUpper() != password;
    }
    
    public static bool HasNumber(string password)
    {
        return password.Any(char.IsNumber);
    }
    
    public static bool HasUnderscore(string password)
    {
        return password.Contains('_');
    }
}