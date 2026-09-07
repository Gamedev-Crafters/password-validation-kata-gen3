namespace Project;

public static class Validator1
{
    public static bool ValidatePassword(string password)
    {
        return 
            StringUtils.ValidateLength(password) &&
            StringUtils.ValidateContainsNumbers(password) &&
            StringUtils.ValidateContainsUnderscore(password) && 
            StringUtils.ValidateContainsLowercase(password) &&
            StringUtils.ValidateContainsUppercase(password);
    }    
}

public static class Validator2 
{
    public static bool ValidatePassword(string password)
    {
        return 
            StringUtils.ValidateLength(password) &&
            StringUtils.ValidateContainsNumbers(password) &&
            StringUtils.ValidateContainsLowercase(password) &&
            StringUtils.ValidateContainsUppercase(password);
    }
}

public static class StringUtils 
{
    public static bool ValidateLength(string password)
    {
        return password.Length >= 8;
    }
    
    public static bool ValidateContainsNumbers(string password)
    {
        // TODO algun valiente que haga regex
        return 
            password.Contains('0') || 
            password.Contains('1') || 
            password.Contains('2') ||
            password.Contains('3') ||
            password.Contains('4') ||
            password.Contains('5') ||
            password.Contains('6') ||
            password.Contains('7') ||
            password.Contains('8') ||
            password.Contains('9');
    }

    public static bool ValidateContainsUnderscore(string password)
    {
        return password.Contains('_');
    }

    public static bool ValidateContainsLowercase(string password)
    {
        return password != password.ToUpper();
    }
    
    public static bool ValidateContainsUppercase(string password)
    {
        return password != password.ToLower();
    }
}