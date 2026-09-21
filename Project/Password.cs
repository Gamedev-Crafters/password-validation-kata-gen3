namespace Project;
public class Printer
{
    public string UltimaLinea;
    public void WriteLine(string text)
    {
        UltimaLinea = text;
        Console.WriteLine(text);
    }
}
public class Password
{
    private string password;

    public Password(string password)
    {
        this.password = password;
    }
    
    public bool ContainsUpperCase()
    {
        return password != password.ToLower();
    }

    public bool ContainsLowerCase()
    {
        return password != password.ToUpper();
    }
    
    public bool ContainsUnderscore(Printer printer)
    {
        if (password.Contains('_'))
        {
            return true;
        } else {
            printer.WriteLine("Le falta un underscore");
            return false;
        }
    }
    
    public bool ContainsNumbers()
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
    
    public bool LengthGreaterThan(int min)
    {
        return password.Length > min;
    }
}