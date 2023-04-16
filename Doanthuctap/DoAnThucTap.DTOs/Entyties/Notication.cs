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
    [Table(NameTable.Notication)]
    public class Notication : BaseData
    {
        public string NameNoti { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
