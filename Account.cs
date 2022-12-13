namespace demo;

public class Account : BaseEntity
{
    public string AccountNumber { get; set; }

    public decimal Balance { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<Transaction> FromTransactions { get; set; }

    public virtual ICollection<Transaction> ToTransactions { get; set; }
}