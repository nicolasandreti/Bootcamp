namespace CodeFirstDatabase;

public class Category
{
	public int CategoryId { get; set; }
	public string CategoryName { get; set; } = null!;
	public string? Description { get; set; }
	public string? Picture { get; set; }
	public ICollection<Product> Prodcts { get; set; }
	public Category()
	{
		Prodcts = new HashSet<Product>();
	}
}
