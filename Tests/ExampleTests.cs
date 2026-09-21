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
		Assert.That(Validator1.ValidatePassword(new Password("key_A12a3sd1fa5s3"), new Printer()), Is.True);
	}
	
	[Test]
	public void UnderscoreError()
	{
		Printer printer = new Printer();
		Assert.That(Validator1.ValidatePassword(new Password("keyA12a3sd1fa5s3"), printer), Is.False);
		string mensajeError = "Le falta un underscore";
		Assert.AreEqual(mensajeError, printer.UltimasLineas.Last());
			
	}
	
	[Test]
	public void UnderscoreAndNumberError()
	{
		Printer printer = new Printer();
		Assert.That(Validator1.ValidatePassword(new Password("keyAkjsdhfjksdSS"), printer), Is.False);
		string underscore = "Le falta un underscore";
		string numero = "Le falta un número";
		Assert.IsTrue(printer.UltimasLineas.Contains(underscore) && printer.UltimasLineas.Contains(numero));
			
	}
	
	
	[Test]
	public void PasswordInvalid()
	{
		Assert.That(Validator1.ValidatePassword(new Password("a"), new Printer()), Is.False);
	}
	
	[Test]
	public void PasswordValid_2()
	{
		Assert.That(Validator2.ValidatePassword(new Password("keyA12a"), new Printer()), Is.True);
	}
	
	[Test]
	public void PasswordInvalid_2()
	{
		Assert.That(Validator2.ValidatePassword(new Password("a"), new Printer()), Is.False);
	}
	
	[Test]
	public void PasswordValid_3()
	{
		Assert.That(Validator3.ValidatePassword(new Password("0123456789asdfA_b"), new Printer()), Is.True);
	}
	
	[Test]
	public void PasswordInvalid_3()
	{
		Assert.That(Validator3.ValidatePassword(new Password("keyA12a"), new Printer()), Is.False);
	}
}