import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable, catchError } from 'rxjs';
import { Product } from './app/Models/product.model';
import { environment } from './environments/environment';

@Injectable({ 
  providedIn: 'root'
})
export class ProductService {

  private baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  searchProducts(searchTerm: string, discountTerm: string):Observable<Product[]> {
    const url = `${this.baseUrl}/api/Product/Search?searchTerm=${searchTerm}&DiscountTerm=${discountTerm}`;
    return this.http.get<Product[]>(url)

  }

  private searchTermSource = new BehaviorSubject<string>('');
  currentSearchTerm = this.searchTermSource.asObservable();

  changeSearchTerm(searchTerm: string) {
    this.searchTermSource.next(searchTerm);
  }

}
