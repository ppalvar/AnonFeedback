namespace Dtos.Outgoing;

public class ReviewInfo
{
    public string Comment { get; set; } = null!;
    public int Rating { get; set; }
    public DateTime Date { get; set; }
}