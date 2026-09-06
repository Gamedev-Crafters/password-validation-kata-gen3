namespace Project;

public class ExampleCode {
    public int ExampleMethod(int a, int b)
    {
        return a + b;
    }

    public static bool IsPasswordValid(string password)
    {
        return HasPasswordEightCharacters(password) && 
               HasPasswordUppercase(password) && 
               HasPasswordLowercase(password) &&
               HasPasswordNumber(password) &&
               HasPasswordUnderscore(password);
    }
    
    public static bool HasPasswordEightCharacters(string password)
    {
        return password.Length > 8;
    }

    public static bool HasPasswordUppercase(string password)
    {
        return password.ToLower() != password;
    }
    
    public static bool HasPasswordLowercase(string password)
    {
        return password.ToUpper() != password;
    }
    
    public static bool HasPasswordNumber(string password)
    {
        return password.Any(char.IsNumber);
    }
    
    public static bool HasPasswordUnderscore(string password)
    {
        return password.Contains('_');
    }
}