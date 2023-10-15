namespace Models;

public class Review
{
    public int Id { get; set; }
    public int Score { get; set; }
    public DateTime Date { get; set; }
    public string Comment { get; set; } = null!;
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
}