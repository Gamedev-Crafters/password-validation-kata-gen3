using Project;

namespace Tests;

public class PasswordTests {
	// [X] Generalizar HasMoreEightCharacters
	// [X] Hacer funciones de otras validaciones
	[SetUp]
	public void Setup() { }

	[Test]
	public void PasswordValidationOne()
	{
		string password = "aA_12345678";
		bool isPasswordValid = PasswordChecker.IsValidForRulesetOne(password);
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordValidationTwo()
	{
		string password = "aZaaa3a";
		bool isPasswordValid = PasswordChecker.IsValidForRulesetTwo(password);
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordValidationThree()
	{
		string password = "aZaaaaa_aaaaaaaaa";
		bool isPasswordValid = PasswordChecker.IsValidForRulesetThree(password);
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordInvalidBecauseTooShort()
	{
		string password = "aA_12";
		bool isPasswordValid = PasswordChecker.IsValidForRulesetOne(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordInvalidBecauseNoUppercase()
	{
		string password = "aa_12345678";
		bool isPasswordValid = PasswordChecker.IsValidForRulesetOne(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordInvalidBecauseNoLowercase()
	{
		string password = "AA_12345678";
		bool isPasswordValid = PasswordChecker.IsValidForRulesetOne(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordInvalidBecauseNoNumber()
	{
		string password = "aa_HDSJKHDjdhsh";
		bool isPasswordValid = PasswordChecker.IsValidForRulesetOne(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordInvalidBecauseNoUnderscore()
	{
		string password = "aaA12345678";
		bool isPasswordValid = PasswordChecker.IsValidForRulesetOne(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordLengthIsMoreThanEight()
	{
		string password = "sgashjdgahjgas";
		bool isPasswordValid = PasswordChecker.HasMoreThanNumberCharacters(password, 8, new Printer());
		Assert.That(isPasswordValid, Is.True);
	}
	
	[Test]
	public void PasswordLengthMoreThanSix()
	{
		string password = "sgashjdgahj";
		bool isPasswordValid = PasswordChecker.HasMoreThanNumberCharacters(password, 6, new Printer());
		Assert.That(isPasswordValid, Is.True);
	}
	
	[Test]
	public void PasswordLengthMoreThanSixteen()
	{
		string password = "sgashjdgahdhsjdsgsdjgasddahjdjgas";
		bool isPasswordValid = PasswordChecker.HasMoreThanNumberCharacters(password, 16, new Printer());
		Assert.That(isPasswordValid, Is.True);
	}
	
	[Test]
	public void PasswordLengthIsInvalid()
	{
		string password = "12345678";
		bool isPasswordValid = PasswordChecker.HasMoreThanNumberCharacters(password, 8, new Printer());
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordLengthIsInvalidSixteen()
	{
		string password = "1234567890123456";
		bool isPasswordValid = PasswordChecker.HasMoreThanNumberCharacters(password, 16, new Printer());
		Assert.That(isPasswordValid, Is.False);
	}

	[Test]
	public void PasswordHasUppercase()
	{
		string password = "sadkhAjhfkjs";
		bool isPasswordValid = PasswordChecker.HasUppercase(password, new Printer());
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordDoesntHaveUppercase()
	{
		string password = "sadkhajhfkjs";
		bool isPasswordValid = PasswordChecker.HasUppercase(password, new Printer());
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordHasLowercase()
	{
		string password = "sadkhjhHHH";
		bool isPasswordValid = PasswordChecker.HasLowercase(password, new Printer());
		Assert.That(isPasswordValid, Is.True);
	}
	
	[Test]
	public void PasswordHasNoLowercaseOnlyNumbers()
	{
		string password = "123456789";
		bool isPasswordValid = PasswordChecker.HasLowercase(password, new Printer());
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordDoesntHaveLowercase()
	{
		string password = "GHSDGHJSADGASHJ";
		bool isPasswordValid = PasswordChecker.HasLowercase(password, new Printer());
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordHasNumber()
	{
		string password = "sadkhjhHHH1";
		bool isPasswordValid = PasswordChecker.HasNumber(password, new Printer());
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordDoesntHaveNumber()
	{
		string password = "GHSDGHJSADGASHJ";
		bool isPasswordValid = PasswordChecker.HasNumber(password, new Printer());
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordHasUnderscore()
	{
		string password = "sadkhjhHHH1_";
		bool isPasswordValid = PasswordChecker.HasUnderscore(password, new Printer());
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordDoesntHaveUnderscore()
	{
		string password = "GHSDGHJSADGASHJ";
		bool isPasswordValid = PasswordChecker.HasUnderscore(password, new Printer());
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordLengthIsInvalidWithError()
	{
		string password = "12345678";
		var printer = new Printer();
		bool isPasswordValid = PasswordChecker.HasMoreThanNumberCharacters(password, 8, printer);
		Assert.That(isPasswordValid, Is.False);
		Assert.AreEqual(printer.LastPrintedLine, "The password needs at least 8 characters.");
	}
	
	[Test]
	public void PasswordMultipleErrorMessage()
	{
		string password = "1";
		var printer = new Printer();
		bool isPasswordValid = PasswordChecker.IsValidForRulesetOne(password, printer);
		Assert.That(isPasswordValid, Is.False);
		// Array, múltiples errores.
		Assert.AreEqual(printer.LastPrintedLine, "The password needs at least 8 characters.");
	}
}