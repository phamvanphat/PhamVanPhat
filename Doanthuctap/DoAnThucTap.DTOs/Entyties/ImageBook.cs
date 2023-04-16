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
    [Table(NameTable.ImageBook)]
    public class ImageBook :BaseData
    {
        public string pathImage { get; set; }
        public int IdBook { get; set; }
        public Book books { get; set; }
    }
}
