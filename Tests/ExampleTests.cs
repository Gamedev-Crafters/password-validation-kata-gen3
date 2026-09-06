using Project;

namespace Tests;

public class Tests {
	// [X] Una función que compruebe si la contraseña tiene más de 8 caracteres.
	// [X] Una función que compruebe si la contraseña contiene una mayúscula.
	// [X] Una función que compruebe que la contraseña contenga una minúscula.
	// [X] Una función que compruebe que la contraseña contenga un número.
	// [ ] Una función que compruebe que la contraseña contenga una barra baja.
	
	[SetUp]
	public void Setup() { }

	[Test]
	public void Test1() {
		Assert.Pass();
	}

	[Test]
	public void ExampleTest()
	{
		ExampleCode example_code = new ExampleCode();
		Assert.That(example_code.ExampleMethod(1, 2), Is.EqualTo(3));
	}

	[Test]
	public void PasswordValid()
	{
		string password = "aA_12345678";
		bool isPasswordValid = ExampleCode.IsPasswordValid(password);
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordInvalid()
	{
		string password = "*";
		bool isPasswordValid = ExampleCode.IsPasswordValid(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordLengthIsValid()
	{
		string password = "sgashjdgahjgas";
		bool isPasswordValid = ExampleCode.IsPasswordLengthValid(password);
		Assert.That(isPasswordValid, Is.True);
	}
	
	[Test]
	public void PasswordLengthIsInvalid()
	{
		string password = "12345678";
		bool isPasswordValid = ExampleCode.IsPasswordLengthValid(password);
		Assert.That(isPasswordValid, Is.False);
	}

	[Test]
	public void PasswordHasUppercase()
	{
		string password = "sadkhAjhfkjs";
		bool isPasswordValid = ExampleCode.HasPasswordUppercase(password);
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordDoesntHaveUppercase()
	{
		string password = "sadkhajhfkjs";
		bool isPasswordValid = ExampleCode.HasPasswordUppercase(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordHasLowercase()
	{
		string password = "sadkhjhHHH";
		bool isPasswordValid = ExampleCode.HasPasswordLowercase(password);
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordDoesntHaveLowercase()
	{
		string password = "GHSDGHJSADGASHJ";
		bool isPasswordValid = ExampleCode.HasPasswordLowercase(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordHasNumber()
	{
		string password = "sadkhjhHHH1";
		bool isPasswordValid = ExampleCode.HasPasswordNumber(password);
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordDoesntHaveNumber()
	{
		string password = "GHSDGHJSADGASHJ";
		bool isPasswordValid = ExampleCode.HasPasswordNumber(password);
		Assert.That(isPasswordValid, Is.False);
	}

}