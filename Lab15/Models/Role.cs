using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Lab15.Models
{
  public partial class Role
  {
    [Key]        
    [Column("RoleID")]
    public int RoleId { get; set; }

    [DataMember]    
    [Required]
    [Column(TypeName ="varchar")]
    [MaxLength(50)]    
    public string? RoleName { get; set; }
    
    [DataMember]   
    [Column(TypeName = "money")]
    [Required]    
    public decimal RoleSalary { get; set;}

    public ICollection<Emploeyy> Emploeyys { get; set; }

  }
}