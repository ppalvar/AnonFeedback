namespace Dtos.Outgoing;

public class ReviewInfo
{
    public string Comment { get; set; } = null!;
    public int Score { get; set; }
    public DateTime Date { get; set; }
}