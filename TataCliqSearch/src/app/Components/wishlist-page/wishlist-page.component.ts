import { Component, NgModule, OnInit, ViewChild } from '@angular/core';
import { TataCliqWebApi } from 'src/app/Service/TataCliqWebApi';
import { Product } from 'src/app/Models/Product';
import { Wishlist } from 'src/app/Models/Wishlist';
import { MatTableModule } from '@angular/material/table';
import { MatButtonModule } from '@angular/material/button';
import { Observable, map } from 'rxjs';
import { ToastrService } from 'ngx-toastr';
import { MatPaginator } from '@angular/material/paginator';

@Component({
  selector: 'app-wishlist-page',
  templateUrl: './wishlist-page.component.html',
  styleUrls: ['./wishlist-page.component.css']
})

export class WishlistPageComponent implements OnInit {

  displayedColumns: string[] = [
    'productName',
    'finalProductPrice',
    'categoryName',
    'brandName',
    'addToCart',
    // 'delete'
  ];

  @ViewChild(MatPaginator) paginator!: MatPaginator;

  ArrWishlist: Wishlist[] = [];

  constructor(private tatacliqservice: TataCliqWebApi, private toastr: ToastrService) { }


  GetWishlist() {
    this.tatacliqservice.GetWishlist().subscribe(res => {
      console.log(res);
      this.ArrWishlist = res;
    })
  }
  ngOnInit(): void {
    this.GetWishlist();
  }

  AddToCart(productId: number) {

    this.tatacliqservice.addToCart(productId)
      .subscribe();

  }


  toggleCart(product: Product) {
    this.isProductInCart(product.productId).subscribe(isInCart => {
      if (isInCart) {
        this.toastr.warning('The product is already in the cart.');
      } else {
        // Proceed with the toggle logic
        product.addedToCart = !product.addedToCart;
        if (product.addedToCart) {
          this.tatacliqservice.addToCart(product.productId);
        }
      }
    });
  }


  isProductInCart(productId: number): Observable<boolean> {
    const userId = 1; // Replace with the actual user ID or identifier
    return this.tatacliqservice.GetCart().pipe(
      map(cartItems => cartItems.some(item => item.productId === productId))
    );
  }

}
