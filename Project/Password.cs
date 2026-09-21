namespace Project;
public class Printer
{
    public List<string> UltimasLineas =  new List<string>();
    public void WriteLine(string text)
    {
        UltimasLineas.Add(text);
        Console.WriteLine(text);
    }
}

public static class ERROR_MESSAGES
{
    public static string UNDERSCORE = "Le falta un underscore";
    public static string NUMBER = "Le falta un número";
    public static string UPPERCASE = "Le falta una mayúscula";
    public static string LOWERCASE = "Le falta una minúscula";
    public static string LENGTH = "Le falta longitud";
    
    
    
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
            printer.WriteLine(ERROR_MESSAGES.UNDERSCORE);
            return false;
        }
    }
    
    public bool ContainsNumbers(Printer printer)
    {
        // TODO algun valiente que haga regex
        bool result =  password.Contains('0') || 
                       password.Contains('1') || 
                       password.Contains('2') ||
                       password.Contains('3') ||
                       password.Contains('4') ||
                       password.Contains('5') ||
                       password.Contains('6') ||
                       password.Contains('7') ||
                       password.Contains('8') ||
                       password.Contains('9');
        if (result)
        {
            return true;
        }
        else
        {
            printer.WriteLine(ERROR_MESSAGES.NUMBER);
            return false;
        }

           
    }
    
    public bool LengthGreaterThan(int min)
    {
        return password.Length > min;
    }
}