using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lab15.Models
{
  public class Emploeyy
  {
    [Key]
    [Column("EmploeyyID")]
    public int EmploeyyId { get; set; }

    [Column("RoleID")]    
    public int RoleId { get; set; }

    [Column("DepartmentID")]    
    public int DepartmentId { get; set; }

    [DataMember]
    [Column(TypeName = "varchar")]
    [Required]
    [MaxLength(100)]
    public string? FirstName { get; set; }

    [DataMember]
    [Column(TypeName = "varchar")]
    [Required]
    [MaxLength(100)]
    public string? SecondName { get; set; }

    [DataMember]
    [Required]
    public int Age { get; set; }    
    public virtual Role Role { get; set; }    
    public virtual Department Department { get; set; }
  }
}
