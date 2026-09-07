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
	public void Passwordxyz()
	{
		string password = "key";

		Assert.That(ExampleCode.ValidatePassword(password), Is.True);
	}
	
	/*
	[Test]
	public void Passwordqwe()
	{
		Password password = new Password();

		Assert.That(ValidatePassword(password), Is.False);
	}
	*/
}