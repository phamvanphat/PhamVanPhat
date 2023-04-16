using DoAnThucTap.DTOs.Base;
using DoAnThucTap.DTOs.Const;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DTOs.Entyties
{
    [Table(NameTable.ClassRoom)]
    public class ClassRoom: BaseData
    {
        public ClassRoom() {
            invokes = new HashSet<Invoke>();
        }
        public string NameClassRoom { get; set; }
        public ICollection<Invoke> invokes { get; set; }
    }
}
