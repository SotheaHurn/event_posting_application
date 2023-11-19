namespace EventLib;
public class User
{
    public int UserId { get; set; } = default!;
	public string Username { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string? Name	{get; set; } = default;
    public string? ProfilePicture { get; set; } = default;
    public string? PhoneNumber { get; set; } = default;
    public string? Address { get; set; } = default;
}
