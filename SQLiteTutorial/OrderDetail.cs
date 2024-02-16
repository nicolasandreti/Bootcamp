namespace SQLiteTutorial;

public class OrderDetail
{
	public int OrderId { get; set; }
	public int ProductId { get; set; }
	public Products Product { get; set; } = null!;
	public Order Order { get; set; } = null!;
}
