import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductManagementComponent } from './Components/product-management/product-management.component';
import { WishlistPageComponent } from './Components/wishlist-page/wishlist-page.component';
import { CartPageComponent } from './Components/cart-page/cart-page.component';
import { OrderPlacedComponent } from './Components/order-placed/order-placed.component';
import { ProductSearchComponent } from './Components/product-search/product-search.component';
import { HeaderComponent } from './Components/header/header.component';
const routes: Routes = [
  { path: "product-management", component: ProductManagementComponent },
  { path: "wishlist-page", component: WishlistPageComponent },
  { path: "order-placed", component: OrderPlacedComponent },
  { path: "cart-page", component: CartPageComponent },
  { path: "product-search", component: ProductSearchComponent }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
