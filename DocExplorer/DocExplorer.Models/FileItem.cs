using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocExplorer.Models {
  public class FileItem {

    public int Id { get; set; }

    [StringLength(255)]
    public string FileNameWithExtension { get; set; }
  
    [Required]
    public string ContentType { get; set; }
    public int ContentLength { get; set; }
    public byte[] Content { get; set; }
     

  }
}
