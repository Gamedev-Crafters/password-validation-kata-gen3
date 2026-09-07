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
		Assert.That(ExampleCode.ValidatePassword("key_A12a3sd1fa5s3"), Is.True);
	}
	
	[Test]
	public void PasswordLenghtNotEnough() {
		Assert.That(ExampleCode.ValidateLength("key"), Is.False);
	}
	
	[Test]
	public void PasswordLenghtEnough()
	{
		Assert.That(ExampleCode.ValidateLength("12345678"), Is.True);
	}

	[Test]
	public void PasswordHasNumbers()
	{
		Assert.That(ExampleCode.ValidateContainsNumbers("1a32s1df3sa"), Is.True);
	}
	
	[Test]
	public void PasswordDoesNotHaveNumbers()
	{
		Assert.That(ExampleCode.ValidateContainsNumbers("alkjshdflas"), Is.False);
	}
	
	[Test]
	public void PasswordHasUnderscore()
	{
		Assert.That(ExampleCode.ValidateContainsUnderscore("asdf_ASdf"), Is.True);
	}
	
	[Test]
	public void PasswordDoesnotHaveUnderscore()
	{
		Assert.That(ExampleCode.ValidateContainsUnderscore("asdfASdf"), Is.False);
	}
	
	[Test]
	public void PasswordHasLowercase()
	{
		Assert.That(ExampleCode.ValidateContainsLowercase("asdfasdf"), Is.True);
	}
	
	[Test]
	public void PasswordDoesnotHaveLowercase()
	{
		Assert.That(ExampleCode.ValidateContainsLowercase("ASDAJGFSJDA"), Is.False);
	}
	
	[Test]
	public void PasswordHasUppercase()
	{
		Assert.That(ExampleCode.ValidateContainsUppercase("ASHDGFAGHF"), Is.True);
	}
	
	[Test]
	public void PasswordDoesnotHaveUppercase()
	{
		Assert.That(ExampleCode.ValidateContainsUppercase("asdfasdfa"), Is.False);
	}
}