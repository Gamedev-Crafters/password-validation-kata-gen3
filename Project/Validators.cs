namespace Project;

public class Validator
{
    private List<Rule> condiciones = new List<Rule>();

    public Validator(List<Rule> condiciones)
    {
        this.condiciones = condiciones;
    }

    public bool ValidatePassword(Password password, Printer printer)
    {
        List<bool> resultCollection = new List<bool>();
        condiciones.ForEach(rule =>
        {
            resultCollection.Add(rule.validate(password, printer));
        });
        return resultCollection.All(result => result);

    }
    
}

public static class Validator1
{
    public static bool ValidatePassword(Password password, Printer printer)
    {
        Validator validator = new Validator(new List<Rule>
        {
            new LengthGreaterThan(8),
            new ContainsUpperCase(),
            new ContainsLowerCase(),
            new ContainsNumbers(),
            new ContainsUnderscore()
        });

        return validator.ValidatePassword(password, printer);
    }
}

public static class Validator2 
{
    public static bool ValidatePassword(Password password, Printer printer)
    {
        Validator validator = new Validator(new List<Rule>
        {
            new LengthGreaterThan(6),
            new ContainsUpperCase(),
            new ContainsLowerCase(),
            new ContainsNumbers()
        });

        return validator.ValidatePassword(password, printer);

    }
}

public static class Validator3
{

    public static bool ValidatePassword(Password password, Printer printer)
    {
        Validator validator = new Validator(new List<Rule>
        {
            new LengthGreaterThan(16),
            new ContainsUpperCase(),
            new ContainsLowerCase(),
            new ContainsUnderscore()
        });

        return validator.ValidatePassword(password, printer);
    }
}

public static class Validator4
{
    public static bool ValidatePassword(Password password, Printer printer)
    {
        List<bool> condiciones = new List<bool>
        {
            password.LengthGreaterThan(8, printer),
            password.ContainsUpperCase(printer),
            password.ContainsNumbers(printer),
            password.ContainsUnderscore(printer),
        };
        return condiciones.Count(c => c.Equals(true)) >= condiciones.Count - 1;
        
    }    
}