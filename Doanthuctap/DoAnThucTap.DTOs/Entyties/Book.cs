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
    [Table(NameTable.Book)]
    public class Book:BaseData
    {
        public Book() { 
            images=new HashSet<ImageBook>();
        }
        public string NameBook { get; set; }
        public string Img { get; set; }
        public string Descriptions { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public int Amount { get; set; }
        //số lương hiện có
        public int QuantityAvailable { get; set; }
        public int Borrowed { get; set; }
        public string slug { get; set; }
        public int IdCategpryBook { get; set; }
        public CategoryBook categoryBook { get; set; }
        public ICollection<ImageBook> images { get; set; }
    }
}
