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
    [Table(NameTable.Invoke)]
    public class Invoke:BaseData
    {
        public Invoke() { 
            invokeDetails=new HashSet<InvokeDetails>();
        }
        public string NameStudent { get; set; }
        public int IdClassRoom { get; set; }
        public int AmountBook { get; set; }
        public DateTime borrowDate { get; set; }
        public DateTime GiveBackDate { get; set; }
        public string Numberphone { get; set; }
        public string Gmail { get; set; }
        public ClassRoom classRoom { get; set; }
        public ICollection<InvokeDetails> invokeDetails { get; set; }
    }
}
