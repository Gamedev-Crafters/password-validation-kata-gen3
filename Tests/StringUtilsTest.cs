namespace Tests;

using Project;

[TestFixture]
public class StringValidateTest
{
    [Test]
    public void PasswordLenghtNotEnough() {
        Assert.That(StringValidate.Length("key", 8), Is.False);
    }
	
    [Test]
    public void PasswordLenghtEnough()
    {
        Assert.That(StringValidate.Length("123456789", 8), Is.True);
    }

    [Test]
    public void PasswordHasNumbers()
    {
        Assert.That(StringValidate.ContainsNumbers("1a32s1df3sa"), Is.True);
    }
	
    [Test]
    public void PasswordDoesNotHaveNumbers()
    {
        Assert.That(StringValidate.ContainsNumbers("alkjshdflas"), Is.False);
    }
	
    [Test]
    public void PasswordHasUnderscore()
    {
        Assert.That(StringValidate.ContainsUnderscore("asdf_ASdf"), Is.True);
    }
	
    [Test]
    public void PasswordDoesNotHaveUnderscore()
    {
        Assert.That(StringValidate.ContainsUnderscore("asdfASdf"), Is.False);
    }
	
    [Test]
    public void PasswordHasLowercase()
    {
        Assert.That(StringValidate.ContainsLowercase("asdfasdf"), Is.True);
    }
	
    [Test]
    public void PasswordDoesNotHaveLowercase()
    {
        Assert.That(StringValidate.ContainsLowercase("ASDAJGFSJDA"), Is.False);
    }
	
    [Test]
    public void PasswordHasUppercase()
    {
        Assert.That(StringValidate.ContainsUppercase("ASHDGFAGHF"), Is.True);
    }
	
    [Test]
    public void PasswordDoesNotHaveUppercase()
    {
        Assert.That(StringValidate.ContainsUppercase("asdfasdfa"), Is.False);
    }
	
    [Test]
    public void EmptyPasswordThatDoesNotHaveUppercase()
    {
        Assert.That(StringValidate.ContainsUppercase(""), Is.False);
    }
}