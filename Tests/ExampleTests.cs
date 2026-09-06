using Project;

namespace Tests;

public class Tests {
	// [ ] Una función que compruebe si la contraseña tiene más de 8 caracteres.
	// [ ] Una función que compruebe si la contraseña contiene una mayúscula.
	
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
	public void PasswordLengthIsValid()
	{
		string password = "sgashjdgahjgas";
		bool isPasswordValid = ExampleCode.IsPasswordValid(password);
		Assert.That(isPasswordValid, Is.True);
	}
	
	[Test]
	public void PasswordLengthIsInvalid()
	{
		string password = "a";
		bool isPasswordValid = ExampleCode.IsPasswordValid(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
}