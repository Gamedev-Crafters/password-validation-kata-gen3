namespace Project;

public class ExampleCode {
    public int ExampleMethod(int a, int b)
    {
        return a + b;
    }

    public static bool IsPasswordValid(string password)
    {
        return IsPasswordLengthValid(password);
    }
    
    public static bool IsPasswordLengthValid(string password)
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
}