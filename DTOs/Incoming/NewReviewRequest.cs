using System.ComponentModel.DataAnnotations;

namespace Dtos.Incoming;

public class NewReviewRequest
{
    public int Score { get; set; }
    public string Comment { get; set; } = null!;
    public int ProductId {get;set;}
}