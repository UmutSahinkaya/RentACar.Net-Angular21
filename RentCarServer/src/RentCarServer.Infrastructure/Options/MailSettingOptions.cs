namespace RentCarServer.Infrastructure.Options;

public sealed class MailSettingOptions
{
    public string Email { get; set; } = default!;
    public string SmtpServer { get; set; } = default!;
    public int Port { get; set; } = default!;
    public bool SSL { get; set; } = default!;
    public string Username { get; set; } = default!;
    public string Password { get; set; } = default!;
}
