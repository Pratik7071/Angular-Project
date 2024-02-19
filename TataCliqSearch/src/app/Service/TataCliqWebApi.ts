import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from '../Models/Product';
import { Observable, catchError, throwError } from 'rxjs';
import { Category } from '../Models/Category';
import { Brand } from '../Models/Brand';
import { Cart } from '../Models/Cart';
import { orderdetails } from '../Models/TataCliqOrdersModel';
import { Wishlist } from '../Models/Wishlist';
import { Shops } from '../Models/Shops';


@Injectable({
  providedIn: 'root'
})

export class TataCliqWebApi {


  constructor(private httpClient: HttpClient) { }

  baseUrl = "https://localhost:7109/api/";

  getAllProductService(): Observable<Product[]> {
    return this.httpClient.get<Product[]>(this.baseUrl + 'Product/GetAllProducts');
  }
  
  createProduct(prod: Product): Observable<Product> {
    return this.httpClient.post<Product>(this.baseUrl + 'Product/CreateProduct', prod);
  }

  updateProduct(prod: Product): Observable<Product> {
    return this.httpClient.put<Product>(this.baseUrl + 'Product/ToUpdateProduct', prod);
  }

  getAllCategoryService(): Observable<Category[]> {
    return this.httpClient.get<Category[]>(this.baseUrl + 'Product/GetCategories');
  }

  getAllBrandService(): Observable<Brand[]> {
    return this.httpClient.get<Brand[]>(this.baseUrl + 'Product/GetBrands');
  }

  addToWishlist(productId: number): Observable<any> {
    const url = `${this.baseUrl}Product/AddProductToWishlist?productId=${productId}`;
    return this.httpClient.post<any>(url, { productId });
  }

  GetWishlist(): Observable<Wishlist[]> {
    return this.httpClient.get<Wishlist[]>(this.baseUrl + "Product/ViewWishlist");
  }

  addToCart(productId: number): Observable<any> {
    const newurl = `${this.baseUrl}Product/AddToCart?productId=${productId}`;
    return this.httpClient.post<any>(newurl, { productId });
  }

  GetCart(): Observable<Cart[]> {
    return this.httpClient.get<Cart[]>(this.baseUrl + "Product/ViewCart");
  }
  AddToOrder (orders: orderdetails): Observable<orderdetails>{
    return this.httpClient.post<orderdetails>(this.baseUrl+ "Product/AddToOrders", orders);
  }
  
  getShop(): Observable<Shops[]> {
    return this.httpClient.get<Shops[]>(this.baseUrl + 'Product/ViewShopAddress');
  }
  
}
