using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVendorApplicationDLL.Domain.Models;

public class BaseModel
{
    [Key]
    public Guid Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public DateTime DateDeleted { get; set; }
    public bool IsDeleted { get; set; }
    public Guid UpdatedBy { get; set; }

    public void Initialize()
    { 
        this.DateCreated = DateTime.Now;
        this.DateUpdated = DateTime.Now;
        this.IsDeleted = false;
        this.Id = Guid.NewGuid();
    }
}
