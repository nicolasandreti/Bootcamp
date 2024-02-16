using System.ComponentModel.DataAnnotations;
using SQLiteTutorial;

namespace SQLiteTutorial;

public class Supplier
{
	[Key]
	public int SupplierId { get; set; }
	[Required]
	public string CompanyName { get; set; } = null!;
	public ICollection<Products> Products { get; set; }
	public Supplier() 
	{
		Products = new HashSet<Products>();
	}
}
