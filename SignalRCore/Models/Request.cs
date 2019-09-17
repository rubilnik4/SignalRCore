using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRCore.Models
{
    public class Request
    {     
            public int Id { get; set; }
            public string Email { get; set; }
            [Required]
            public string Name { get; set; } 
    }
}
