namespace Project;

public static class Validator1
{
    public static bool ValidatePassword(Password password)
    {
        return
            password.LengthGreaterThan(8) &&
            password.ContainsUpperCase() &&
            password.ContainsLowerCase() &&
            password.ContainsNumbers() &&
            password.ContainsUnderscore();
    }    
}

public static class Validator2 
{
    public static bool ValidatePassword(Password password)
    {
        return
            password.LengthGreaterThan(6) &&
            password.ContainsUpperCase() &&
            password.ContainsLowerCase() &&
            password.ContainsNumbers();
    }
}

public static class Validator3
{
    public static bool ValidatePassword(Password password)
    {
        return
            password.LengthGreaterThan(16) &&
            password.ContainsUpperCase() &&
            password.ContainsLowerCase() &&
            password.ContainsUnderscore();
    }    
}