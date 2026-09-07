namespace Project;

public static class Validator1
{
    public static bool ValidatePassword(string password)
    {
        return
            StringValidate.Length(password, 8) &&
            StringValidate.ContainsUppercase(password) &&
            StringValidate.ContainsLowercase(password) &&
            StringValidate.ContainsNumbers(password) &&
            StringValidate.ContainsUnderscore(password);
    }    
}

public static class Validator2 
{
    public static bool ValidatePassword(string password)
    {
        return
            StringValidate.Length(password, 6) &&
            StringValidate.ContainsUppercase(password) &&
            StringValidate.ContainsLowercase(password) &&
            StringValidate.ContainsNumbers(password);
    }
}

public static class Validator3
{
    public static bool ValidatePassword(string password)
    {
        return
            StringValidate.Length(password, 16) &&
            StringValidate.ContainsUppercase(password) &&
            StringValidate.ContainsLowercase(password) &&
            StringValidate.ContainsUnderscore(password);
    }    
}

public static class StringValidate 
{
    public static bool Length(string password, int biggerThan)
    {
        return password.Length > biggerThan;
    }
    
    public static bool ContainsNumbers(string password)
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

    public static bool ContainsUnderscore(string password)
    {
        return password.Contains('_');
    }

    public static bool ContainsLowercase(string password)
    {
        return password != password.ToUpper();
    }
    
    public static bool ContainsUppercase(string password)
    {
        return password != password.ToLower();
    }
}