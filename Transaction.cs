namespace demo;

public class Transaction : BaseEntity
{
    public string TransactionNumber { get; set; }

    public int FromAccountId { get; set; }

    public int ToAccountId { get; set; }

    public decimal Amount { get; set; }

    public virtual Account FromAccount { get; set; }

    public virtual Account ToAccount { get; set; }
}
