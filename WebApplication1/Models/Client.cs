using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "請輸入客戶名稱")]
        [StringLength(20, ErrorMessage = "請不要輸入超過 20 個字元")]
        [Display(Name = "客戶名稱")]
        public string Name { get; set; }

        [Required(ErrorMessage = "請輸入聯絡電話")]
        [RegularExpression(@"\d{10}", ErrorMessage = "聯絡電話請輸入 10 個數字")]
        [Display(Name = "聯絡電話")]
        public string Phone { get; set; }
    }
}