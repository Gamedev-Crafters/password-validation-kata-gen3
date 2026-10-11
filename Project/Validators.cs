namespace Project;


public static class Validator1
{
    public static bool ValidatePassword(Password password, Printer printer)
    {
        List<bool> condiciones = new List<bool>
        {
            password.LengthGreaterThan(8, printer),
            password.ContainsUpperCase(printer),
            password.ContainsLowerCase(printer),
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
        List<bool> condiciones = new List<bool>
        {
            password.LengthGreaterThan(6, printer),
            password.ContainsUpperCase(printer),
            password.ContainsLowerCase(printer),
            password.ContainsNumbers(printer),
        };
        
        return condiciones.All(c => c.Equals(true));
        
    }
}

public static class Validator3
{
    public static bool ValidatePassword(Password password, Printer printer)
    {
        List<bool> condiciones = new List<bool>
        {
            password.LengthGreaterThan(16, printer),
            password.ContainsUpperCase(printer),
            password.ContainsLowerCase(printer),
            password.ContainsUnderscore(printer),
        };
        
        return condiciones.All(c => c.Equals(true));
        
    }    
}