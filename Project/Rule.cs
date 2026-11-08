namespace Project;

public interface Rule
{
    bool validate(Password password, Printer printer);
}

public class LengthGreaterThan : Rule
{
    private int length;

    public LengthGreaterThan(int lenght)
    {
        this.length = lenght;
    }

    public bool validate(Password password, Printer printer)
    {
        return password.LengthGreaterThan(length, printer);
    }
}

public class ContainsUpperCase : Rule
{
    public bool validate(Password password, Printer printer)
    {
        return password.ContainsUpperCase(printer);
    }
}
public class ContainsLowerCase : Rule
{
    public bool validate(Password password, Printer printer)
    {
        return password.ContainsLowerCase(printer);
    }
}
public class ContainsNumbers : Rule
{
    public bool validate(Password password, Printer printer)
    {
        return password.ContainsNumbers(printer);
    }
}
public class ContainsUnderscore : Rule
{
    public bool validate(Password password, Printer printer)
    {
        return password.ContainsUnderscore(printer);
    }
}