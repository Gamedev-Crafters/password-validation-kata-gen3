namespace Project;

public class PasswordChecker {

    public static bool IsValidForRulesetOne(string password)
    {
        return HasMoreThanNumberCharacters(password, 8, new Printer()) && 
               HasUppercase(password) && 
               HasLowercase(password) &&
               HasNumber(password) &&
               HasUnderscore(password);
    }

    public static bool IsValidForRulesetTwo(string password)
    {
        return HasMoreThanNumberCharacters(password, 6, new Printer()) &&
               HasUppercase(password) &&
               HasLowercase(password) &&
               HasNumber(password);
    }

    public static bool IsValidForRulesetThree(string password)
    {
        return HasMoreThanNumberCharacters(password, 16, new Printer()) &&
               HasUppercase(password) &&
               HasLowercase(password) &&
               HasUnderscore(password);
    }
    
    public static bool HasMoreThanNumberCharacters(string password, int charCount, Printer printer)
    {
        string errorMessage = "";
        if (password.Length > charCount)
        {
            return true;
        }
        errorMessage = $"The password needs at least {charCount} long";
        printer.PrintLine(errorMessage);
        return false;
    }

    public static bool HasUppercase(string password)
    {
        return password.ToLower() != password;
    }
    
    public static bool HasLowercase(string password)
    {
        return password.ToUpper() != password;
    }
    
    public static bool HasNumber(string password)
    {
        return password.Any(char.IsNumber);
    }
    
    public static bool HasUnderscore(string password)
    {
        return password.Contains('_');
    }
}

public class Printer
{
    public string lastPrintedLine;

    public void PrintLine(string line)
    {
        lastPrintedLine = line;
        Console.WriteLine(line);
    }
}