using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQLiteTutorial;

public class Category
{
	[Key]
	public int CategoryId { get; set; }
	[StringLength(15)]
	public string CategoryName { get; set; } = null!;
	[Column(TypeName = "ntext")]
	public string? Description { get; set; }
	public ICollection<Products> Products { get; set; }
	public Category()
	{
		Products = new HashSet<Products>();
	}
}
