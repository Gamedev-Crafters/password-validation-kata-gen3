namespace Tests;

using Project;

[TestFixture]
public class StringValidateTest
{
    [Test]
    public void PasswordLenghtNotEnough() {
        Assert.That(new Password("key").LengthGreaterThan(8, new TestPrinter()), Is.False);
    }
	
    [Test]
    public void PasswordLenghtEnough()
    {
        Assert.That(new Password("123456789").LengthGreaterThan(8, new TestPrinter()), Is.True);
    }

    [Test]
    public void PasswordHasNumbers()
    {
        Assert.That(new Password("1a32s1df3sa").ContainsNumbers(new TestPrinter()), Is.True);
    }
	
    [Test]
    public void PasswordDoesNotHaveNumbers()
    {
        Assert.That(new Password("alkjshdflas").ContainsNumbers(new TestPrinter()), Is.False);
    }
	
    [Test]
    public void PasswordHasUnderscore()
    {
        Assert.That(new Password("asdf_ASdf").ContainsUnderscore(new TestPrinter()), Is.True);
    }
	
    [Test]
    public void PasswordDoesNotHaveUnderscore()
    {
        Assert.That(new Password("asdfASdf").ContainsUnderscore(new TestPrinter()), Is.False);
    }
	
    [Test]
    public void PasswordHasLowercase()
    {
        Assert.That(new Password("asdfasdf").ContainsLowerCase(new TestPrinter()), Is.True);
    }
	
    [Test]
    public void PasswordDoesNotHaveLowercase()
    {
        Assert.That(new Password("ASDAJGFSJDA").ContainsLowerCase(new TestPrinter()), Is.False);
    }
	
    [Test]
    public void PasswordHasUppercase()
    {
        Assert.That(new Password("ASHDGFAGHF").ContainsUpperCase(new TestPrinter()), Is.True);
    }
	
    [Test]
    public void PasswordDoesNotHaveUppercase()
    {
        Assert.That(new Password("asdfasdfa").ContainsUpperCase(new TestPrinter()), Is.False);
    }
	
    [Test]
    public void EmptyPasswordThatDoesNotHaveUppercase()
    {
        Assert.That(new Password("").ContainsUpperCase(new TestPrinter()), Is.False);
    }
}