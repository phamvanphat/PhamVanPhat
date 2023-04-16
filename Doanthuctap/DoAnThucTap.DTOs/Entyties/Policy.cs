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
    [Table(NameTable.Policy)]
    public class Policy:BaseData
    {
        public string NamePolicy { get; set; }
        public string DescriptionPolicy { get; set; }
    }
}
