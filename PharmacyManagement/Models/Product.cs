using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyManagement.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "نام دوا الزامی است")]
        [StringLength(100, ErrorMessage = "نام دوا نمی‌تواند بیشتر از 100 کاراکتر باشد")]
        public string Name { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "توضیحات نمی‌تواند بیشتر از 500 کاراکتر باشد")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "قیمت الزامی است")]
        [Range(0.01, double.MaxValue, ErrorMessage = "قیمت باید بیشتر از 0 باشد")]
        [Column(TypeName = "decimal(18,2)")] // اضافه کردن این خط
        public decimal Price { get; set; }

        [Required(ErrorMessage = "تعداد موجودی الزامی است")]
        [Range(0, int.MaxValue, ErrorMessage = "تعداد موجودی نمی‌تواند منفی باشد")]
        public int StockQuantity { get; set; }

        [Required(ErrorMessage = "تاریخ تولید الزامی است")]
        public DateTime ProductionDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "تاریخ انقضا الزامی است")]
        public DateTime ExpiryDate { get; set; } = DateTime.Now.AddYears(2);

        [StringLength(100)]
        public string Manufacturer { get; set; } = string.Empty;

        [Required(ErrorMessage = "دسته‌بندی الزامی است")]
        [StringLength(50)]
        public string Category { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}