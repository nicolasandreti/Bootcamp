using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQLiteTutorial;

public class Products
{
	[Key]
	public int ProductId { get; set; }
	[Required, StringLength(40)]
	public string ProductName { get; set; } = null!;
	[ForeignKey("Category")]
	public int CategoryId { get; set; }
	public int SupplierId { get; set; }
	public Supplier Supplier { get; set; } = null!;
	public Category Category { get; set; } = null!;
	public double UnitPrice { get; set; }
	[Column("UnitsInStock", TypeName = "smallint")]
	public short Stock { get; set; }
}
