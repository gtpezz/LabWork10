namespace PasswordValidatorTests;

public class PasswordValidatorTests
{
    [Fact]
    public void Test_ValidPassword_ReturnsTrue()
    {
        Assert.True(PasswordValidator.PasswordValidator.IsValid("PrivetTy228"));
    }

    [Fact]
    public void Test_ShortPassword_ReturnsFalse()
    {
        Assert.False(PasswordValidator.PasswordValidator.IsValid("Priv1"));
    }

    [Fact]
    public void Test_NoDigit_ReturnsFalse()
    {
        Assert.False(PasswordValidator.PasswordValidator.IsValid("PrivetFromPassword"));
    }

    [Fact]
    public void Test_NoLatin_ReturnsFalse()
    {
        Assert.False(PasswordValidator.PasswordValidator.IsValid("2281337Привет"));
    }
}
