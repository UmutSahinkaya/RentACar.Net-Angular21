using RentCarServer.Domain.Abstractions;
using RentCarServer.Domain.Users.ValueObjects;

namespace RentCarServer.Domain.Users;

public sealed class User : Entity
{
    public User(FirstName firstName, LastName lastName, Email email, UserName userName, Password password)
    {
        SetFirstName(firstName);
        SetLastName(lastName);
        SetEmail(email);
        SetFullName();
        SetUserName(userName);
        SetPassword(password);
        SetIsForgotPasswordCompleted(new(true));
        setTFAStatus(new(false));
    }

    private User() { }
    public FirstName FirstName { get; private set; } = default!;
    public LastName LastName { get; private set; } = default!;
    public FullName FullName { get; private set; } = default!;
    public Email Email { get; private set; } = default!;
    public UserName UserName { get; private set; } = default!;
    public Password Password { get; private set; } = default!;
    public ForgotPasswordCode? ForgotPasswordCode { get; private set; }
    public ForgotPasswordDate? ForgotPasswordDate { get; private set; }
    public IsForgotPasswordCompleted IsForgotPasswordCompleted { get; private set; } = default!;
    public TFAStatus TFAStatus { get; private set; } = default!;
    public TFACode? TFACode { get; private set; } = default!;
    public TFAConfirmCode? TFAConfirmCode { get; private set; } = default!;
    public TFAExpiresDate? TFAExpiresDate { get; private set; } = default!;
    public TFAIsCompleted? TFAIsCompleted { get; private set; } = default!;

    #region Behaviors
    public bool VerifyPasswordHash(string password)
    {
        using var hmac = new System.Security.Cryptography.HMACSHA512(Password.PasswordSalt);
        var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        return computedHash.SequenceEqual(Password.PasswordHash);
    }
    public void CreateForgotPasswordId()
    {
        ForgotPasswordCode = new(Guid.CreateVersion7());
        ForgotPasswordDate = new(DateTimeOffset.UtcNow);
        IsForgotPasswordCompleted = new(false);
    }
    public void ReSetPassword(string newPassword)
    {
        Password = new(newPassword);
        //IsForgotPasswordCompleted = new(true);
    }
    public void SetFirstName(FirstName firstName)
    {
        FirstName = firstName;
    }
    public void SetLastName(LastName lastName)
    {
        LastName = lastName;
    }
    public void SetEmail(Email email)
    {
        Email = email;
    }
    public void SetFullName()
    {
        FullName = new(FirstName.Value + " " + LastName.Value + " (" + Email.Value + ")");
    }
    public void SetUserName(UserName userName)
    {
        UserName = userName;
    }
    public void SetPassword(Password password)
    {
        Password = password;
    }
    public void SetIsForgotPasswordCompleted(IsForgotPasswordCompleted isForgotPasswordCompleted)
    {
        IsForgotPasswordCompleted = isForgotPasswordCompleted;
    }

    public void setTFAStatus(TFAStatus tfaStatus)
    {
        TFAStatus = tfaStatus;
    }
    public void CreateTFACode()
    {
        TFACode = new(Guid.CreateVersion7().ToString());
        TFAExpiresDate = new(DateTimeOffset.Now.AddMinutes(5));
        TFAIsCompleted = new(false);
        TFAConfirmCode = new(Guid.CreateVersion7().ToString());
    }

    public void SetTFACompleted()
    {
        TFAIsCompleted = new(true);
    }
    #endregion

}
