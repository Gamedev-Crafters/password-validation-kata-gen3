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
		Assert.That(Validator1.ValidatePassword("key_A12a3sd1fa5s3"), Is.True);
	}
	
	[Test]
	public void PasswordInvalid()
	{
		Assert.That(Validator1.ValidatePassword("a"), Is.False);
	}
	
	[Test]
	public void PasswordValid_2()
	{
		Assert.That(Validator2.ValidatePassword("keyA12a"), Is.True);
	}
	
	[Test]
	public void PasswordInvalid_2()
	{
		Assert.That(Validator2.ValidatePassword("a"), Is.False);
	}
	
	[Test]
	public void PasswordValid_3()
	{
		Assert.That(Validator3.ValidatePassword("0123456789asdfA_b"), Is.True);
	}
	
	[Test]
	public void PasswordInvalid_3()
	{
		Assert.That(Validator3.ValidatePassword("keyA12a"), Is.False);
	}
}