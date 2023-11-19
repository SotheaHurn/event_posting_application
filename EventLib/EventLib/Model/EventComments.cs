namespace EventLib;
public class EventComments
{
    public int CommentId { get; set; } = default!;
	public int EventId { get; set; } = default!;
    public int UserId { get; set; } = default!;
    public string Text { get; set; } = default!;
}
