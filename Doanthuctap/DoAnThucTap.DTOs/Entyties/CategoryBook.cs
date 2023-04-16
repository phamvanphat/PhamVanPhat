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
    [Table(NameTable.CategoryBook)]
    public class CategoryBook: BaseData
    {
        public CategoryBook() { 
            books=new HashSet<Book>();
        }
        public string CategoryBookName { get; set; }
        public int Total { get; set; }
        public ICollection<Book> books { get; set; }
    }
}
