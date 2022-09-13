using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WAD_T2104E_NguyenHoangSon.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int productId { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống trường này!")]
        [StringLength(32,MinimumLength =3,ErrorMessage ="Tên sản phẩm phải nằm giữa 3 đến 32 kí tự")]
        public string name { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống trường này!")]
        [Range(0, int.MaxValue, ErrorMessage = "Giá tiền phải là kiểu số")]
        public int price { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống trường này!")]
        [Range(1, 100, ErrorMessage = "Số lượng phải nằm trong khoảng 1 đến 100")]
        public int quantity { get; set; }
        public DateTime? releaseDate { get; set; }
        public DateTime? createTime { get; set; }
        public DateTime? updateTime { get; set; }
        public string createUser { get; set; }
        public string updateUser { get; set; }
        public int categoryId { get; set; }
        public virtual Category product { get; set; }
    }
}