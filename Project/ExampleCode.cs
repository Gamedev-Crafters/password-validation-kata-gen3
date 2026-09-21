namespace Project;


public static class Validator1
{
    public static bool ValidatePassword(Password password, Printer printer)
    {
        List<bool> condiciones = new List<bool>
        {
            password.LengthGreaterThan(8),
            password.ContainsUpperCase(),
            password.ContainsLowerCase(),
            password.ContainsNumbers(printer),
            password.ContainsUnderscore(printer),
        };
        
        return condiciones.All(c => c.Equals(true));
    }    
}

public static class Validator2 
{
    public static bool ValidatePassword(Password password, Printer printer)
    {
        return
            password.LengthGreaterThan(6) &&
            password.ContainsUpperCase() &&
            password.ContainsLowerCase() &&
            password.ContainsNumbers(printer);
    }
}

public static class Validator3
{
    public static bool ValidatePassword(Password password, Printer printer)
    {
        return
            password.LengthGreaterThan(16) &&
            password.ContainsUpperCase() &&
            password.ContainsLowerCase() &&
            password.ContainsUnderscore(printer);
    }    
}