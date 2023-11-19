namespace EventLib;
public class Event
{
	public int EventId { get; set; } = default!;
	public int UserId { get; set; } = default!;
	public string EventName { get; set; } = default!;
	public string? EventLogo { get; set; } = default;
	public DateTime StartDate { get; set; } = default!;
	public DateTime EndDate { get; set; } = default!;
	public string Location { get; set; } = default!;
	public Category CategoryNum { get; set; } = Category.None;
	public int LikedCount { get; set; } = 0;
	public List<EventComments> Comments { get; set; } = default!;
	public DateTime CreateOn { get; set; } = default!;
	public DateTime? UpdateOn { get; set; } = default;
}
