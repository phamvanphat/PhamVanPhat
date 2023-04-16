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
    [Table(NameTable.Rules)]
    public class Rules : BaseData
    {
        public string RuleName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
    }
}
