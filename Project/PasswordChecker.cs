namespace Project;

public class PasswordChecker {

    public static bool IsValidForRulesetOne(string password)
    {
        Printer printer = new();
        
        return HasMoreThanNumberCharacters(password, 8, printer) && 
               HasUppercase(password, printer) && 
               HasLowercase(password, printer) &&
               HasNumber(password, printer) &&
               HasUnderscore(password, printer);
    }

    public static bool IsValidForRulesetTwo(string password)
    {
        Printer printer = new();
        return HasMoreThanNumberCharacters(password, 6, printer) &&
               HasUppercase(password, printer) &&
               HasLowercase(password, printer) &&
               HasNumber(password, printer);
    }

    public static bool IsValidForRulesetThree(string password)
    {
        Printer printer = new();
        return HasMoreThanNumberCharacters(password, 16, printer) &&
               HasUppercase(password, printer) &&
               HasLowercase(password, printer) &&
               HasUnderscore(password, printer);
    }
    
    public static bool MaybeError(bool isCorrect, string errorMessage, Printer printer){
        if (!isCorrect)
        {
            printer.PrintLine(errorMessage);
        }

        return isCorrect;
    }
    
    public static bool HasMoreThanNumberCharacters(string password, int charCount, Printer printer)
    {
        return MaybeError(password.Length > charCount, $"The password needs at least {charCount} characters.", printer);
    }

    public static bool HasUppercase(string password, Printer printer)
    {
        return MaybeError(password.ToLower() != password, "The password must have uppercase.", printer);
    }
    
    public static bool HasLowercase(string password, Printer printer)
    {
        return MaybeError(password.ToUpper() != password,  "The password must have lowercase.", printer);
    }
    
    public static bool HasNumber(string password, Printer printer)
    {
        return MaybeError(password.Any(char.IsNumber),  "The password must have numbers.", printer);
    }
    
    public static bool HasUnderscore(string password, Printer printer)
    {
        return MaybeError(password.Contains('_'),   "The password must have underscore.", printer);
    }
}

public class Printer
{
    public string LastPrintedLine = "";

    public void PrintLine(string line)
    {
        LastPrintedLine = line;
        Console.WriteLine(line);
    }
}