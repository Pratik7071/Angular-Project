
using CoreModelss;


namespace ApplicationLayer
{
    public interface IProductRepository
    {
        public List<Product> GetAllProducts();
        public void CreateProduct(Product product);
        public void UpdateProduct(Product product);
        public List<TblTataCliqBrand> getBrands();
        public List< TblTataCliqCategory> getCategories();
        public TblTataCliqProduct ToViewOneProduct(int id);
        public void CreateBrand(TblTataCliqBrand brand);
        public void CreateCategory(TblTataCliqCategory category);
        public void UpdateBrand(TblTataCliqBrand brand);
        public void UpdateCategory(TblTataCliqCategory category);

        public void AddProductToWishlist(int productId);

        public List<wishlist> ViewWishList();

        public void DeleteFromWislist(int productId);

        public void AddProductTocart(int productId);
        public List<Cart> CartView();


        public List<Product> Search(string searchTerm, string discountRange);

        public void AddToOrders(TataCliqOrdersModel tataCliqOrdersModel);

        public List<TblTataCliqShopAddress> ViewShopAddress();
        public void SignUp(string UserName, string Email, string Password, int UserTypeId);

        public List<TblTataCliqUserType> ViewUserType();
        public Boolean Login(LoginCredentials logincredentials);

        public Boolean ForgotPassword(ForgotPassword forgotpassword);



    }
}
