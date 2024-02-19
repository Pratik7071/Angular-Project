using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CoreModelss
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string ProductDescription { get; set; } = null!;
        public double ActualProductPrice { get; set; }
        public int? DiscountPercentage { get; set; }
        public double FinalProductPrice { get; set; }
        public int StockQuantity { get; set; }
        public string? CategoryName { get; set; }
        public string? BrandName { get; set; }

        public bool IsDeleted { get; set; }
        public int? BrandId { get; set; }

        public int? CategoryId { get; set; }
    }


    public class wishlist
    {

        public int WishListId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public double FinalProductPrice { get; set; }
        public string? CategoryName { get; set; }
        public string? BrandName { get; set; }

        public bool IsDeleted { get; set; }

        public int StockQuantity { get; set; }

    }

    public class Cart
    {

        public int CartId { get; set; }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public double FinalProductPrice { get; set; }
        public string? CategoryName { get; set; }
        public string? BrandName { get; set; }

        public bool IsDeleted { get; set; }

        public int StockQuantity { get; set; }

    }


    public class ProductOrderInfo
    {
        public int ProductId { get; set; }
        public int OrderQuantity { get; set; }
    }

    public class LoginCredentials
    {

        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? UserTypeId { get; set; }
        [JsonIgnore]
        public virtual TblTataCliqUserType? UserType { get; set; }
    }

    public class ForgotPassword
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
