using System.Diagnostics;
using Project;

namespace Tests;

public class Tests {
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
		string password = "key_A12a3sd1fa5s3";

		Assert.That(ExampleCode.ValidatePassword(password), Is.True);
	}
	
	[Test]
	public void PasswordLenghtNotEnough()
	{
		string password = "key";

		Assert.That(ExampleCode.ValidateLength(password), Is.False);
	}
	
	[Test]
	public void PasswordLenghtEnough()
	{
		string password = "12345678";

		Assert.That(ExampleCode.ValidateLength(password), Is.True);
	}

	[Test]
	public void PasswordHasNumbers()
	{
		string password = "1a32s1df3sa";
		
		Assert.That(ExampleCode.ValidateContainsNumbers(password), Is.True);
	}
	
	[Test]
	public void PasswordDoesNotHaveNumbers()
	{
		string password = "alkjshdflas";
		
		Assert.That(ExampleCode.ValidateContainsNumbers(password), Is.False);
	}
}