using Project;

namespace Tests;

public class PasswordTests {
	// 
	[SetUp]
	public void Setup() { }

	[Test]
	public void PasswordValid()
	{
		string password = "aA_12345678";
		bool isPasswordValid = PasswordChecker.IsValid(password);
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordInvalidBecauseTooShort()
	{
		string password = "aA_12";
		bool isPasswordValid = PasswordChecker.IsValid(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordInvalidBecauseNoUppercase()
	{
		string password = "aa_12345678";
		bool isPasswordValid = PasswordChecker.IsValid(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordInvalidBecauseNoLowercase()
	{
		string password = "AA_12345678";
		bool isPasswordValid = PasswordChecker.IsValid(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordInvalidBecauseNoNumber()
	{
		string password = "aa_HDSJKHDjdhsh";
		bool isPasswordValid = PasswordChecker.IsValid(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordInvalidBecauseNoUnderscore()
	{
		string password = "aaA12345678";
		bool isPasswordValid = PasswordChecker.IsValid(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordLengthIsValid()
	{
		string password = "sgashjdgahjgas";
		bool isPasswordValid = PasswordChecker.HasMoreThanEightCharacters(password);
		Assert.That(isPasswordValid, Is.True);
	}
	
	[Test]
	public void PasswordLengthIsInvalid()
	{
		string password = "12345678";
		bool isPasswordValid = PasswordChecker.HasMoreThanEightCharacters(password);
		Assert.That(isPasswordValid, Is.False);
	}

	[Test]
	public void PasswordHasUppercase()
	{
		string password = "sadkhAjhfkjs";
		bool isPasswordValid = PasswordChecker.HasUppercase(password);
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordDoesntHaveUppercase()
	{
		string password = "sadkhajhfkjs";
		bool isPasswordValid = PasswordChecker.HasUppercase(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordHasLowercase()
	{
		string password = "sadkhjhHHH";
		bool isPasswordValid = PasswordChecker.HasLowercase(password);
		Assert.That(isPasswordValid, Is.True);
	}
	
	[Test]
	public void PasswordHasNoLowercaseOnlyNumbers()
	{
		string password = "123456789";
		bool isPasswordValid = PasswordChecker.HasLowercase(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordDoesntHaveLowercase()
	{
		string password = "GHSDGHJSADGASHJ";
		bool isPasswordValid = PasswordChecker.HasLowercase(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordHasNumber()
	{
		string password = "sadkhjhHHH1";
		bool isPasswordValid = PasswordChecker.HasNumber(password);
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordDoesntHaveNumber()
	{
		string password = "GHSDGHJSADGASHJ";
		bool isPasswordValid = PasswordChecker.HasNumber(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordHasUnderscore()
	{
		string password = "sadkhjhHHH1_";
		bool isPasswordValid = PasswordChecker.HasUnderscore(password);
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordDoesntHaveUnderscore()
	{
		string password = "GHSDGHJSADGASHJ";
		bool isPasswordValid = PasswordChecker.HasUnderscore(password);
		Assert.That(isPasswordValid, Is.False);
	}
}