using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace PTStore.Models
{
    public partial class Subcriber
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string TrangThai { get; set; }
    }
}
