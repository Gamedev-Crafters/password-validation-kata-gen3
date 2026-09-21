namespace Project;

class Program {
	static void Main(string[] args)
	{
		Password password = new Password(args[0]);
		if (Validator1.ValidatePassword(password))
		{
			Console.WriteLine("perfecto");
		}
		else
		{
			Console.WriteLine("mal");
		}

	}
}