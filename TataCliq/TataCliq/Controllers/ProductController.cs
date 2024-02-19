using ApplicationLayer;
using CoreModelss;
using Microsoft.AspNetCore.Mvc;

namespace TataCliq.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase

    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger, IProductRepository productRepository)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        [Route("GetAllProducts")]
        [HttpGet]
        public List<Product> GetAllProducts()
        {
            try
            {
                return _productRepository.GetAllProducts();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception();
            }
        }

     
        [Route("CreateProduct")]
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            try
            {
                _productRepository.CreateProduct(product);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception();
            }
       }

        [Route("ToUpdateProduct")]
        [HttpPut]
        public IActionResult ToUpdateProduct(Product product)
        {
            try
            {
                _productRepository.UpdateProduct(product);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception();
            }
        }

        [Route("ViewOneProduct")]
        [HttpGet]
        public TblTataCliqProduct ViewOneProduct(int id)
        {
            try
            {
                var prod = _productRepository.ToViewOneProduct(id);
                return prod;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception();
            }
        }

        [Route("GetCategories")]
        [HttpGet]
        public List<TblTataCliqCategory> getCategories()
        {
            try
            {
                return _productRepository.getCategories();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception();
            }
        }

        [Route("GetBrands")]
        [HttpGet]
        public List<TblTataCliqBrand> getBrands()
        {
            try
            {
                return _productRepository.getBrands();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception();
            }
        }

        [Route("AddBrand")]
        [HttpPost]
        public IActionResult addBrand(TblTataCliqBrand brand)
        {
            try
            {
                _productRepository.CreateBrand(brand);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception();
            }
        }
       

        [Route("AddCategory")]
        [HttpPost]
        public IActionResult addCategory(TblTataCliqCategory category)
        {
            try
            {
                _productRepository.CreateCategory(category);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception();
            }
        }

        [Route("UpdateBrand")]
        [HttpPut]
        public IActionResult updateBrand(TblTataCliqBrand brand)
        {
            try
            {
                _productRepository.UpdateBrand(brand);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception();
            }
        }

        [Route("UpdateCategory")]
        [HttpPut]
        public IActionResult updateCategory(TblTataCliqCategory category)
        {
            try
            {
                _productRepository.UpdateCategory(category);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception();
            }
        }

        [Route("AddProductToWishlist")]
        [HttpPost]
        public IActionResult AddProductToWishlist(int productId)
        {
            _productRepository.AddProductToWishlist(productId);
            return Ok();
        }

        [Route("ViewWishlist")]
        [HttpGet]
        public async Task<IActionResult> ViewWishlist()
        {
            var result = await Task.FromResult(_productRepository.ViewWishList());
            return Ok(result);
        }


        [Route("DeleteFromWishlist")]
        [HttpPut]
        public IActionResult DeleteFromWishlist(int productId)
        {
            
            _productRepository.DeleteFromWislist(productId);
            return Ok();
        }

        [Route("AddToCart")]
        [HttpPost]
        public IActionResult AddToCart(int productId)
        {
            _productRepository.AddProductTocart(productId);
            return Ok();
        }

        [Route("ViewCart")]
        [HttpGet]
        public IActionResult ViewCart()
        {
            var cartItems = _productRepository.CartView();
            return Ok(cartItems);
        }


        [Route("AddToOrders")]
        [HttpPost]
        public IActionResult AddToOrders([FromBody] TataCliqOrdersModel tataCliqOrdersModel)
        {
            _productRepository.AddToOrders(tataCliqOrdersModel);
            return Ok();
        }

        [Route("ViewShopAddress")]
        [HttpGet]

        public IActionResult ViewShopAddress()
        {
            var addresses = _productRepository.ViewShopAddress();
            return Ok(addresses);
        }

        [Route("SignUp")]
        [HttpPost]

        public IActionResult AddUser(string UserName, string Email, string Password, int UserTypeId)
        {
           _productRepository.SignUp(UserName, Email, Password , UserTypeId);
            return Ok();
        }

        [Route("getUserType")]
        [HttpGet]

        public List<TblTataCliqUserType> getUserType()
        {
            return _productRepository.ViewUserType();
        }

        [Route("Login")]
        [HttpPost]

        public IActionResult Login(LoginCredentials logincredentials)
        {
            var result = _productRepository.Login(logincredentials);
            if (result == true)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [Route("ForgotPassword")]
        [HttpPut]

        public IActionResult ForgotPassword(ForgotPassword forgotpassword)
        {
            var result = _productRepository.ForgotPassword(forgotpassword);
            if (result == true)
            {
                return Ok(result);
            }
            else 
            {
                return BadRequest(); 
            }
        }

    }
}

