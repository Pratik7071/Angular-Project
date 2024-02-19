using ApplicationLayer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Xml.Linq;
using CoreModelss;
using BCrypt.Net;
using System.Threading.Tasks.Dataflow;


namespace DataAccessLayer
{
    public class ProductRepository : IProductRepository
    {
        private readonly Dotnet2023Context _context;

        public ProductRepository(Dotnet2023Context context)
        {
            _context = context;
        }
        public List<Product> Search(string searchTerm, string discountRange)
        {
            decimal minDiscount = 0;
            decimal maxDiscount = 0;

            switch (discountRange)
            {
                case "0-10":
                    maxDiscount = 10;
                    break;
                case ">25":
                    minDiscount = 25;
                    break;
                case "25-50":
                    minDiscount = 25;
                    maxDiscount = 50;
                    break;
                case "<50":
                    maxDiscount = 50;
                    break;
                case ">50":
                    minDiscount = 50;
                    break;
                default:
                    minDiscount = 0;
                    maxDiscount = 100;
                    break;
            }

            var baseQuery = from product in _context.TblTataCliqProducts
                            join category in _context.TblTataCliqCategories on product.CategoryId equals category.CategoryId into productJoin
                            from productCategory in productJoin.DefaultIfEmpty()
                            join brand in _context.TblTataCliqBrands on product.BrandId equals brand.BrandId into productCategoryBrand
                            from prodCatBrand in productCategoryBrand.DefaultIfEmpty()
                            where ((string.IsNullOrEmpty(searchTerm) ||
                                    product.ProductName.Contains(searchTerm) ||
                                    productCategory.CategoryName.Contains(searchTerm) ||
                                    prodCatBrand.BrandName.Contains(searchTerm)) &&
                                    (product.DiscountPercentage >= minDiscount && product.DiscountPercentage <= maxDiscount))
                            select new { product, productCategory, prodCatBrand };

            var query = baseQuery.Select(result => new Product
            {
                ProductId = result.product.ProductId,
                ProductName = result.product.ProductName,
                ProductDescription = result.product.ProductDescription ?? "",
                ActualProductPrice = result.product.ActualProductPrice,
                DiscountPercentage = result.product.DiscountPercentage,
                FinalProductPrice = result.product.FinalProductPrice,
                StockQuantity = result.product.StockQuantity,
                CategoryId = result.productCategory.CategoryId,
                CategoryName = result.productCategory.CategoryName,
                BrandId = result.prodCatBrand.BrandId,
                BrandName = result.prodCatBrand.BrandName,
                IsDeleted = result.product.IsDeleted,
            });
            return query.ToList();
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                var query = from product in _context.TblTataCliqProducts
                            join category in _context.TblTataCliqCategories
                            on product.CategoryId equals category.CategoryId into productCategory
                            from productWithCategoryName in productCategory.DefaultIfEmpty()
                            where product.IsDeleted == false
                            join brand in _context.TblTataCliqBrands
                            on product.BrandId equals brand.BrandId into productBrand
                            from productWithBrandName in productBrand.DefaultIfEmpty()
                            where product.IsDeleted == false
                            select new
                            {
                                product,
                                productWithCategoryName,
                                productWithBrandName
                            };

                List<Product> products = query.Select(queryProduct =>
                new Product
                {
                    ProductId = queryProduct.product.ProductId,
                    ProductName = queryProduct.product.ProductName,
                    ProductDescription = queryProduct.product.ProductDescription ?? "",
                    ActualProductPrice = queryProduct.product.ActualProductPrice,
                    DiscountPercentage = queryProduct.product.DiscountPercentage,
                    FinalProductPrice = queryProduct.product.FinalProductPrice,
                    StockQuantity = queryProduct.product.StockQuantity,
                    CategoryName = queryProduct.productWithCategoryName.CategoryName,
                    BrandName = queryProduct.productWithBrandName.BrandName,
                    BrandId = queryProduct.product.BrandId,
                    CategoryId = queryProduct.product.CategoryId
                }).ToList();
                return products;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }


        public List<TblTataCliqBrand> getBrands()
        {
            try
            {
                var allBrands = _context.TblTataCliqBrands.Where(Brand => Brand.IsDeleted == false).ToList();
                return allBrands;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }

        public List<TblTataCliqCategory> getCategories()
        {
            try
            {
                var allCategory = _context.TblTataCliqCategories.Where(Category => Category.IsDeleted == false).ToList();
                return allCategory;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }

        public void CreateProduct(Product product)
        {
            try
            {
                TblTataCliqProduct toAddProduct = new();
                toAddProduct.CategoryId = product.CategoryId;
                toAddProduct.BrandId = product.BrandId;
                toAddProduct.ProductName = product.ProductName;
                toAddProduct.ProductDescription = product.ProductDescription;
                toAddProduct.ActualProductPrice = product.ActualProductPrice;
                toAddProduct.DiscountPercentage = product.DiscountPercentage;
                toAddProduct.FinalProductPrice = product.FinalProductPrice;
                toAddProduct.StockQuantity = product.StockQuantity;
                toAddProduct.CreatedOn = DateTime.Now;
                _context.TblTataCliqProducts.Add(toAddProduct);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }

        public void UpdateProduct(Product product)
        {
            try
            {
                TblTataCliqProduct toUpdate = _context.TblTataCliqProducts.FirstOrDefault(prod => prod.ProductId == product.ProductId);
                toUpdate.StockQuantity = product.StockQuantity;
                toUpdate.ModifiedOn = DateTime.Now;
                _context.TblTataCliqProducts.Update(toUpdate);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }

        }

        public TblTataCliqProduct ToViewOneProduct(int id)
        {
            try
            {
                var prod = _context.TblTataCliqProducts.FirstOrDefault(product => product.ProductId == id);
                return prod;

            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public void CreateBrand(TblTataCliqBrand brand)
        {
            _context.TblTataCliqBrands.Add(brand);
            _context.SaveChanges();
        }

        public void CreateCategory(TblTataCliqCategory category)
        {
            _context.TblTataCliqCategories.Add(category);
            _context.SaveChanges();
        }

        public void UpdateBrand(TblTataCliqBrand brand)
        {
            var brandToUpdate = _context.TblTataCliqBrands.FirstOrDefault(tempBrand => tempBrand.BrandId == brand.BrandId);
            if (brandToUpdate != null)
            {
                brandToUpdate.BrandName = brand.BrandName;
                brandToUpdate.ModifiedOn = DateTime.Now;
            }
            _context.TblTataCliqBrands.Update(brandToUpdate);
            _context.SaveChanges();
        }
        public void UpdateCategory(TblTataCliqCategory category)
        {
            var categoryToUpdate = _context.TblTataCliqCategories.FirstOrDefault(tempCategory => tempCategory.CategoryId == category.CategoryId);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.CategoryName = category.CategoryName;
                categoryToUpdate.ModifiedOn = DateTime.Now;
            }
            _context.TblTataCliqCategories.Update(categoryToUpdate);
            _context.SaveChanges();
        }



        public void AddProductToWishlist(int productId)
        {
            var existingWishlistItem = _context.TblTataCliqWishlists.FirstOrDefault(w => w.ProductId == productId && w.IsDeleted == false);
            if (existingWishlistItem == null)
            {
                //throw new InvalidOperationException("This product is already in the wishlist.");
                var newWishlistItem = new TblTataCliqWishlist();

                newWishlistItem.ProductId = productId;
                newWishlistItem.CreatedOn = DateTime.Now;

                _context.TblTataCliqWishlists.Add(newWishlistItem);
                _context.SaveChanges();
            }

        }
        public List<wishlist> ViewWishList()
        {
            var combinedData = (from wishlistt in _context.TblTataCliqWishlists
                                join product in _context.TblTataCliqProducts on wishlistt.ProductId equals product.ProductId into wishlistData
                                from wishlistItem in wishlistData.DefaultIfEmpty()
                                where wishlistt.IsDeleted == false
                                select new wishlist
                                {
                                    WishListId = wishlistt.WishListId,
                                    ProductId = wishlistItem.ProductId,
                                    ProductName = wishlistItem.ProductName,
                                    FinalProductPrice = wishlistItem.FinalProductPrice,
                                    CategoryName = wishlistItem.Category.CategoryName ?? "",
                                    BrandName = wishlistItem.Brand.BrandName ?? "",
                                    IsDeleted = wishlistItem.IsDeleted,
                                    StockQuantity = wishlistItem.StockQuantity,
                                }).ToList();
            return combinedData;
        }

        public void DeleteFromWislist(int productId)
        {
            var delete = _context.TblTataCliqWishlists.FirstOrDefault(x => x.ProductId == productId);
            if (delete != null)
            {
                var obj = new TblTataCliqWishlist();
                obj.ProductId = productId;
                obj.IsDeleted = true;
                _context.SaveChanges();
            }
        }
        public void AddProductTocart(int productId)
        {
            var existingCartItem = _context.TblTataCliqCarts.FirstOrDefault(w => w.ProductId == productId && w.IsDeleted == false);
            if (existingCartItem == null)
            {
                var newCartItem = new TblTataCliqCart()
                {
                    ProductId = productId,
                    CreatedOn = DateTime.Now
                };
                _context.TblTataCliqCarts.Add(newCartItem);
                var wishlistItem = _context.TblTataCliqWishlists.FirstOrDefault(w => w.ProductId == productId && w.IsDeleted == false);
                if (wishlistItem != null)
                {
                    wishlistItem.IsDeleted = true;
                }
                _context.SaveChanges();
            }
        }

        public List<Cart> CartView()
        {
            var x = (from cart in _context.TblTataCliqCarts.Where(x => x.IsDeleted == false)
                     join product in _context.TblTataCliqProducts on cart.ProductId equals product.ProductId into cartProduct
                     from cartFinal in cartProduct.DefaultIfEmpty()
                     select new Cart
                     {
                         CartId = cart.CartId,
                         ProductId = cartFinal.ProductId,
                         ProductName = cartFinal.ProductName,
                         FinalProductPrice = cartFinal.FinalProductPrice,
                         CategoryName = cartFinal.Category.CategoryName ?? "",
                         BrandName = cartFinal.Brand.BrandName ?? "",
                         IsDeleted = cartFinal.IsDeleted,
                         StockQuantity = cartFinal.StockQuantity
                     }).ToList();

            return x;
        }

        public void AddToOrders(TataCliqOrdersModel tataCliqOrdersModel)
        {
            foreach (var product in tataCliqOrdersModel.Products)
            {
                TblTataCliqOrder orders = new TblTataCliqOrder();
                orders.Name = tataCliqOrdersModel.Name;
                orders.Address = tataCliqOrdersModel.Address;
                orders.ModeOfPayment = tataCliqOrdersModel.ModeOfPayment;
                orders.CartId = product.CartId;
                orders.OrderQuantity = product.OrderQuantity;

                // Check if ShopAddressId is provided and not 0, otherwise set the default value (25 in this case)
                orders.ShopAddressId = (tataCliqOrdersModel.ShopAddressId != null && tataCliqOrdersModel.ShopAddressId != 0)
                    ? tataCliqOrdersModel.ShopAddressId
                    : 25;

                _context.TblTataCliqOrders.Add(orders);
                _context.SaveChanges();

                TblTataCliqCart cart = _context.TblTataCliqCarts.FirstOrDefault(carts => carts.CartId == product.CartId);

                TblTataCliqProduct productInStock = _context.TblTataCliqProducts.FirstOrDefault(p => p.ProductId == cart.ProductId);

                if (productInStock != null)
                {
                    productInStock.StockQuantity -= product.OrderQuantity;

                    _context.TblTataCliqProducts.Update(productInStock);
                    _context.SaveChanges();
                }

                var cartItem = _context.TblTataCliqCarts.FirstOrDefault(c => c.CartId == product.CartId);
                if (cartItem != null)
                {
                    cartItem.IsDeleted = true;
                    _context.SaveChanges();
                }
            }
        }

        public List<TblTataCliqShopAddress> ViewShopAddress()
        {
            var x = _context.TblTataCliqShopAddresses.ToList();
            _context.SaveChanges();
            return x;
        }

        public void SignUp(string UserName, string Email, string Password, int UserTypeId)
        {
            TblTataCliqUser obj = new TblTataCliqUser();
            obj.UserName = UserName;
            obj.Email = Email;

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(Password);
            obj.Password = hashedPassword;

            obj.UserTypeId = UserTypeId;

            _context.TblTataCliqUsers.Add(obj);
            _context.SaveChanges();
        }

        public List<TblTataCliqUserType> ViewUserType()
        {
            var userType = _context.TblTataCliqUserTypes.ToList();
            return userType;
        }

        public Boolean Login(LoginCredentials logincredentials)
        {
            TblTataCliqUser user = _context.TblTataCliqUsers
                .FirstOrDefault(u => u.UserTypeId == logincredentials.UserTypeId && u.Email == logincredentials.Email);

            if (user == null)
            {
                // User not found
                return false;
            }

            if (VerifyPassword(user.Password, logincredentials.Password))
            {
                return true;
            }
            else
            {
                // Passwords do not match
                return false;
            }
        }

        private bool VerifyPassword(string storedPassword, string providedPassword)
        {

            return BCrypt.Net.BCrypt.Verify(providedPassword, storedPassword);
        }

        public Boolean ForgotPassword(ForgotPassword forgotpassword)
        {
            TblTataCliqUser user = _context.TblTataCliqUsers.FirstOrDefault(u => u.Email == forgotpassword.Email);

            if (user == null)
            {
                return false;
            }

            user.Password = BCrypt.Net.BCrypt.HashPassword(forgotpassword.Password);

            _context.SaveChanges();

            return true;
        }

    }
}


