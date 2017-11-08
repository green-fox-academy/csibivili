using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityTest.Models
{
    public class Todo
    {
        int Id { get; set; }      
        string Description { get; set; }
        bool IsDone { get; set; }
        MyUser User { get; set; }
    }
}
