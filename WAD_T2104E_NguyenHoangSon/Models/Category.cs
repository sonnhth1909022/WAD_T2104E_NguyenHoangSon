using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WAD_T2104E_NguyenHoangSon.Models
{
    [Table("categories")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public DateTime? createTime { get; set; }
        public DateTime? updateTime { get; set; }
        public string createUser { get; set; }
        public string updateUser { get; set; }
        public virtual ICollection<Product> products { get; set; }
    }
}