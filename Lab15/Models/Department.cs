using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Lab15.Models
{
  public class Department
  {
    [Key]
    [Column("DepartmentID")]
    public int DepartmentId { get; set; }

    [DataMember]
    [Required]
    [Column(TypeName ="varchar")]
    [MaxLength(100)]
    public string? DepartmentName { get; set;}

    [DataMember]
    [Required]
    [Column(TypeName ="varchar")]
    [MaxLength(100)]
    public string? DepartmentDescription { get; set;}

    public ICollection<Emploeyy> Emploeyys { get; set; }
  }
}
