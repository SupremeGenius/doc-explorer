using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocExplorer.Models {
  public class Item {

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    
    [Required]
    [StringLength(255)]
    public string Title { get; set; }

    public virtual ICollection<FileItem> FileItems { get; set; }

    [Column(TypeName = "datetime2")]
    public DateTime DateCreated { get; set; }


    public Item() {
      FileItems = new HashSet<FileItem>();
    }
  }
}
