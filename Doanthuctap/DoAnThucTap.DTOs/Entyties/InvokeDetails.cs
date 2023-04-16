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
    [Table(NameTable.InvokeDetails)]
    public class InvokeDetails:BaseData
    {
        public string NameBook { get; set; }
        public int Amount { get; set; }
        public int IdInvoke { get; set; }
        public Invoke invoke { get; set; }
    }
}
