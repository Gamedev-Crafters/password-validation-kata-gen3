using Project;

namespace Tests;

public class PasswordTests {
	// [X] Una función que compruebe si la contraseña tiene más de 8 caracteres.
	// [X] Una función que compruebe si la contraseña contiene una mayúscula.
	// [X] Una función que compruebe que la contraseña contenga una minúscula.
	// [X] Una función que compruebe que la contraseña contenga un número.
	// [X] Una función que compruebe que la contraseña contenga una barra baja.
	
	[SetUp]
	public void Setup() { }

	// hay rulesets cerrados o van cambiando?
	// un solo ruleset se usa en varios sitios, o en uno solo?
	// para añadir una nueva regla, donde queremos que viva?

	[Test]
	public void Approach_MultipleMethods()
	{
		string password = "aA12345678";
		Assert.That(PasswordChecker.IsValidForRuleset1(password), Is.False);
		Assert.That(PasswordChecker.IsValidForRuleset2(password), Is.True);
	}

	[Test]
	public void Approach_Parameter()
	{
		string password = "aA12345678";
		Assert.That(PasswordChecker.IsValid(password, "ruleset_1"), Is.False);
		Assert.That(PasswordChecker.IsValid(password, "ruleset_2"), Is.True);
	}

	[Test]
	public void Approach_ParameterInVariable()
	{
		string password = "aA12345678";
		PasswordChecker checker_ruleset_1 = new PasswordChecker("ruleset_1");
		PasswordChecker checker_ruleset_2 = new PasswordChecker("ruleset_2");
		Assert.That(checker_ruleset_1.IsValid(password), Is.False);
		Assert.That(checker_ruleset_2.IsValid(password), Is.True);
	}

	[Test]
	public void Approach_FactoryMethod()
	{
		string password = "aA12345678";
		PasswordChecker checker_ruleset_1 = PasswordCheckerFactory.buildRuleset1();
		PasswordChecker checker_ruleset_2 = PasswordCheckerFactory.buildRuleset2();
		Assert.That(checker_ruleset_1.IsValid(password), Is.False);
		Assert.That(checker_ruleset_2.IsValid(password), Is.True);
	}

	[Test]
	public void Approach_RulesetConfig()
	{
		string password = "aA12345678";
		PasswordChecker checker_ruleset_1 = new PasswordChecker(
			min_length = 8,
			must_have_uppercase = true,
			must_have_lowercase = true,
			must_have_number = true,
			must_have_underscore = true,
		);
		PasswordChecker checker_ruleset_2 = new PasswordChecker(
			min_length = 6,
			must_have_uppercase = true,
			must_have_lowercase = true,
			must_have_number = true,
			must_have_underscore = false,
		);
		Assert.That(checker_ruleset_1.IsValid(password), Is.False);
		Assert.That(checker_ruleset_2.IsValid(password), Is.True);
	}

	[Test]
	public void Approach_Polymorphism()
	{
		string password = "aA12345678";
 		// heredan de PasswordChecker
		PasswordChecker checker_ruleset_1 = new PasswordCheckerForRuleset1();
		PasswordChecker checker_ruleset_2 = new PasswordCheckerForRuleset2();
		Assert.That(checker_ruleset_1.IsValid(password), Is.False);
		Assert.That(checker_ruleset_2.IsValid(password), Is.True);
	}

	[Test]
	public void Approach_OOP_PasswordObject()
	{
		Password password = new Password("aA12345678");
		Assert.That(password.HasMoreThanEightCharacters(password), Is.True);
	}

	[Test]
	public void Approach_Composition()
	{
		string password = "aA12345678";
		// PasswordChecker tiene una lista de Rule
		PasswordChecker checker_ruleset_1 = new PasswordChecker();
		// todos heredan de Rule
		checker_ruleset_1.addRule(new Rule_MinimumLength(9)); 
		checker_ruleset_1.addRule(new Rule_HasNumber()); 
		checker_ruleset_1.addRule(new Rule_HasUnderscore()); 
		PasswordChecker checker_ruleset_2 = new PasswordChecker();
		checker_ruleset_2.addRule(new Rule_MinimumLength(7)); 
		checker_ruleset_2.addRule(new Rule_HasNumber()); 
		Assert.That(checker_ruleset_1.IsValid(password), Is.False);
		Assert.That(checker_ruleset_2.IsValid(password), Is.True);
	}

	[Test]
	public void Approach_Lambda()
	{
		string password = "aA12345678";
		PasswordChecker checker_ruleset_1 = new PasswordChecker();
		checker_ruleset_1.addRule((password) => password.ToLower() == password); 
		checker_ruleset_1.addRule((password) => password.Contains('_')); 
		PasswordChecker checker_ruleset_2 = new PasswordChecker();
		checker_ruleset_1.addRule((password) => password.Length > 6); 
		Assert.That(checker_ruleset_1.IsValid(password), Is.False);
		Assert.That(checker_ruleset_2.IsValid(password), Is.True);
	}

	[Test]
	public void PasswordValid()
	{
		string password = "aA_12345678";
		bool isPasswordValid = PasswordChecker.IsValid(password);
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordInvalidBecauseTooShort()
	{
		string password = "aA_12";
		bool isPasswordValid = PasswordChecker.IsValid(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordInvalidBecauseNoUppercase()
	{
		string password = "aa_12345678";
		bool isPasswordValid = PasswordChecker.IsValid(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordInvalidBecauseNoLowercase()
	{
		string password = "AA_12345678";
		bool isPasswordValid = PasswordChecker.IsValid(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordInvalidBecauseNoNumber()
	{
		string password = "aa_HDSJKHDjdhsh";
		bool isPasswordValid = PasswordChecker.IsValid(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordInvalidBecauseNoUnderscore()
	{
		string password = "aaA12345678";
		bool isPasswordValid = PasswordChecker.IsValid(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordLengthIsValid()
	{
		string password = "sgashjdgahjgas";
		bool isPasswordValid = PasswordChecker.HasMoreThanEightCharacters(password);
		Assert.That(isPasswordValid, Is.True);
	}
	
	[Test]
	public void PasswordLengthIsInvalid()
	{
		string password = "12345678";
		bool isPasswordValid = PasswordChecker.HasMoreThanEightCharacters(password);
		Assert.That(isPasswordValid, Is.False);
	}

	[Test]
	public void PasswordHasUppercase()
	{
		string password = "sadkhAjhfkjs";
		bool isPasswordValid = PasswordChecker.HasUppercase(password);
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordDoesntHaveUppercase()
	{
		string password = "sadkhajhfkjs";
		bool isPasswordValid = PasswordChecker.HasUppercase(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordHasLowercase()
	{
		string password = "sadkhjhHHH";
		bool isPasswordValid = PasswordChecker.HasLowercase(password);
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordDoesntHaveLowercase()
	{
		string password = "GHSDGHJSADGASHJ";
		bool isPasswordValid = PasswordChecker.HasLowercase(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordHasNumber()
	{
		string password = "sadkhjhHHH1";
		bool isPasswordValid = PasswordChecker.HasNumber(password);
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordDoesntHaveNumber()
	{
		string password = "GHSDGHJSADGASHJ";
		bool isPasswordValid = PasswordChecker.HasNumber(password);
		Assert.That(isPasswordValid, Is.False);
	}
	
	[Test]
	public void PasswordHasUnderscore()
	{
		string password = "sadkhjhHHH1_";
		bool isPasswordValid = PasswordChecker.HasUnderscore(password);
		Assert.That(isPasswordValid, Is.True);
	}

	[Test]
	public void PasswordDoesntHaveUnderscore()
	{
		string password = "GHSDGHJSADGASHJ";
		bool isPasswordValid = PasswordChecker.HasUnderscore(password);
		Assert.That(isPasswordValid, Is.False);
	}
}