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
	public void PasswordValid()
	{
		Assert.That(ExampleCode.ValidatePassword("key_A12a3sd1fa5s3"), Is.True);
	}
	
	[Test]
	public void PasswordValid_2()
	{
		Assert.That(ExampleCode2.ValidatePassword("keyA12a3sd1fa5s3"), Is.True);
	}
	
	[Test]
	public void PasswordInvalid()
	{
		Assert.That(ExampleCode.ValidatePassword("a"), Is.False);
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
	public void PasswordDoesNotHaveUnderscore()
	{
		Assert.That(ExampleCode.ValidateContainsUnderscore("asdfASdf"), Is.False);
	}
	
	[Test]
	public void PasswordHasLowercase()
	{
		Assert.That(ExampleCode.ValidateContainsLowercase("asdfasdf"), Is.True);
	}
	
	[Test]
	public void PasswordDoesNotHaveLowercase()
	{
		Assert.That(ExampleCode.ValidateContainsLowercase("ASDAJGFSJDA"), Is.False);
	}
	
	[Test]
	public void PasswordHasUppercase()
	{
		Assert.That(ExampleCode.ValidateContainsUppercase("ASHDGFAGHF"), Is.True);
	}
	
	[Test]
	public void PasswordDoesNotHaveUppercase()
	{
		Assert.That(ExampleCode.ValidateContainsUppercase("asdfasdfa"), Is.False);
	}
	
	[Test]
	public void EmptyPasswordThatDoesNotHAveUppercase()
	{
		Assert.That(ExampleCode.ValidateContainsUppercase(""), Is.False);
	}
	
	/*
	 * password = "algo";
	 * reglas = "algunas";
	 *
	 * if(
	 * password.Lenght > 6 && 
	 * ValidateContainsUppercase(password)
	 * )
	 * {
	 *	ta bien
	 * }
	 * else
	 * {
	 *	ta mal
	 * }
	 */
}