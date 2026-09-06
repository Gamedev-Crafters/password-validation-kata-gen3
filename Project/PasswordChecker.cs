namespace Project;

public class PasswordChecker {

    public static bool IsValid(string password)
    {
        return HasMoreThanEightCharacters(password) && 
               HasUppercase(password) && 
               HasLowercase(password) &&
               HasNumber(password) &&
               HasUnderscore(password);
    }
    
    public static bool HasMoreThanEightCharacters(string password)
    {
        return password.Length > 8;
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