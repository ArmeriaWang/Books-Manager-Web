using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksManagerWeb.Models
{
    public class Book
    {
        public int ID { get; set; }

        // [Display(Name = "书名")]
        public string Name { get; set; }

        // [Display(Name = "出版日期")]
        [Display(Name = "Publish Date")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        // [Display(Name = "作者")]
        public string Author { get; set; }

        // [Display(Name = "分类")]
        public string Genre { get; set; }

        // [Display(Name = "价格")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        /*
        public bool IsLent { get; set; }
        public string IsLentStr { get; set; }
        */
    }
}
