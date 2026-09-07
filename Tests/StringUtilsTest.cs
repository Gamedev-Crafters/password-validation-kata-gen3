namespace Tests;

using Project;

[TestFixture]
public class StringValidateTest
{
    [Test]
    public void PasswordLenghtNotEnough() {
        Assert.That(new Password("key").LengthGreaterThan(8), Is.False);
    }
	
    [Test]
    public void PasswordLenghtEnough()
    {
        Assert.That(new Password("123456789").LengthGreaterThan(8), Is.True);
    }

    [Test]
    public void PasswordHasNumbers()
    {
        Assert.That(new Password("1a32s1df3sa").ContainsNumbers(), Is.True);
    }
	
    [Test]
    public void PasswordDoesNotHaveNumbers()
    {
        Assert.That(new Password("alkjshdflas").ContainsNumbers(), Is.False);
    }
	
    [Test]
    public void PasswordHasUnderscore()
    {
        Assert.That(new Password("asdf_ASdf").ContainsUnderscore(), Is.True);
    }
	
    [Test]
    public void PasswordDoesNotHaveUnderscore()
    {
        Assert.That(new Password("asdfASdf").ContainsUnderscore(), Is.False);
    }
	
    [Test]
    public void PasswordHasLowercase()
    {
        Assert.That(new Password("asdfasdf").ContainsLowerCase(), Is.True);
    }
	
    [Test]
    public void PasswordDoesNotHaveLowercase()
    {
        Assert.That(new Password("ASDAJGFSJDA").ContainsLowerCase(), Is.False);
    }
	
    [Test]
    public void PasswordHasUppercase()
    {
        Assert.That(new Password("ASHDGFAGHF").ContainsUpperCase(), Is.True);
    }
	
    [Test]
    public void PasswordDoesNotHaveUppercase()
    {
        Assert.That(new Password("asdfasdfa").ContainsUpperCase(), Is.False);
    }
	
    [Test]
    public void EmptyPasswordThatDoesNotHaveUppercase()
    {
        Assert.That(new Password("").ContainsUpperCase(), Is.False);
    }
}