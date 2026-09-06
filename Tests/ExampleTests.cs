using Project;

namespace Tests;

public class Tests {
	// [X] Una función que compruebe si la contraseña tiene más de 8 caracteres.
	// [ ] Una función que compruebe si la contraseña contiene una mayúscula.
	// [ ] Una función que compruebe que la contraseña contenga una minúscula.
	
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
		string password = "a";
		bool isPasswordValid = ExampleCode.IsPasswordLengthValid(password);
		Assert.That(isPasswordValid, Is.False);
	}

	[Test]
	public void PasswordHasUppercase()
	{
		string password = "sadkhAjhfkjs";
		bool isPasswordValid = ExampleCode.IsPasswordValid(password);
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordDoesntHaveUppercase()
	{
		string password = "sadkhajhfkjs";
		bool isPasswordValid = ExampleCode.IsPasswordValid(password);
		Assert.That(isPasswordValid, Is.False);
	}
}