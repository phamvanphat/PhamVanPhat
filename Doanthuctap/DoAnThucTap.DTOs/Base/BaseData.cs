using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnThucTap.DTOs.Base
{
    public class BaseData
    {
        public int Id { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public int? CreateBy { get; set; }
        public int? UpdateBy { get; set; }
        public int? Deleteby { get; set; }
        public int? DislayOrder { get; set; }
    }
}
