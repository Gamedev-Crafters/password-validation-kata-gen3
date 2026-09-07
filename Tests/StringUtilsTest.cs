namespace Tests;

using Project;

[TestFixture]
public class StringUtilsTest
{
    [Test]
    public void PasswordLenghtNotEnough() {
        Assert.That(StringUtils.ValidateLengthBiggerThan7("key"), Is.False);
    }
	
    [Test]
    public void PasswordLenghtEnough()
    {
        Assert.That(StringUtils.ValidateLengthBiggerThan7("12345678"), Is.True);
    }

    [Test]
    public void PasswordHasNumbers()
    {
        Assert.That(StringUtils.ValidateContainsNumbers("1a32s1df3sa"), Is.True);
    }
	
    [Test]
    public void PasswordDoesNotHaveNumbers()
    {
        Assert.That(StringUtils.ValidateContainsNumbers("alkjshdflas"), Is.False);
    }
	
    [Test]
    public void PasswordHasUnderscore()
    {
        Assert.That(StringUtils.ValidateContainsUnderscore("asdf_ASdf"), Is.True);
    }
	
    [Test]
    public void PasswordDoesNotHaveUnderscore()
    {
        Assert.That(StringUtils.ValidateContainsUnderscore("asdfASdf"), Is.False);
    }
	
    [Test]
    public void PasswordHasLowercase()
    {
        Assert.That(StringUtils.ValidateContainsLowercase("asdfasdf"), Is.True);
    }
	
    [Test]
    public void PasswordDoesNotHaveLowercase()
    {
        Assert.That(StringUtils.ValidateContainsLowercase("ASDAJGFSJDA"), Is.False);
    }
	
    [Test]
    public void PasswordHasUppercase()
    {
        Assert.That(StringUtils.ValidateContainsUppercase("ASHDGFAGHF"), Is.True);
    }
	
    [Test]
    public void PasswordDoesNotHaveUppercase()
    {
        Assert.That(StringUtils.ValidateContainsUppercase("asdfasdfa"), Is.False);
    }
	
    [Test]
    public void EmptyPasswordThatDoesNotHaveUppercase()
    {
        Assert.That(StringUtils.ValidateContainsUppercase(""), Is.False);
    }
}