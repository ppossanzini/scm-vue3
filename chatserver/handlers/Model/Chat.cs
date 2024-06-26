using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace handlers.Model;

public class Chat
{
  [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int Id { get; set; }
  [StringLength(200)]
  public string Name { get; set; }
  public DateTime CreationDate { get; set; }
}