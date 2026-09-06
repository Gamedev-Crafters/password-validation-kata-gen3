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
	public void PasswordTest()
	{
		string password = "sgashjdgahjgas";
		bool isPasswordValid = ExampleCode.IsPasswordValid(password);
		Assert.That(isPasswordValid, Is.True);
	}
}