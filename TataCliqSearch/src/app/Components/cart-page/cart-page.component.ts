import { Component, OnInit, ViewChild } from '@angular/core';
import { Cart } from 'src/app/Models/Cart';
import { orderdetails , productdetails } from 'src/app/Models/TataCliqOrdersModel';
import { TataCliqWebApi } from 'src/app/Service/TataCliqWebApi';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { MatPaginator } from '@angular/material/paginator';
import { Shops } from 'src/app/Models/Shops';
import { NgModel } from '@angular/forms';


@Component({
  selector: 'app-cart-page',
  templateUrl: './cart-page.component.html',
  styleUrls: ['./cart-page.component.css']
})
export class CartPageComponent implements OnInit {
  pincode! : number;
  customerName :string ='';
  address : string= '';
  mop: string = '';
  shopAddressId: number = 0;
  ArrCart : Cart[] =[];
  shopaddress! : string;
  pincodearray!:number[];
  shopDropDown!: Shops[] ;
  // isShopAddressId = false;

  @ViewChild(MatPaginator) paginator!: MatPaginator;

  constructor(private tatacliqservice : TataCliqWebApi, private toastr: ToastrService, private router: Router) { }
  

  // pincodearray: number[];
  
  products : productdetails[] = [];
  Shop : Shops[] = [];
  orders: orderdetails = {
    name: '',
    address: '',
    modeOfPayment: '',
    shopAddressId: 0,
    products: []
  };

  filteraddress(){
   this.shopDropDown = this.Shop.filter(address => address.pincode === this.pincode)
   console.log(this.shopAddressId,this.pincode);
  }

  GetCart() {
    this.tatacliqservice.GetCart().subscribe(res => {
      console.log(res);
      this.ArrCart = res;
      this.ArrCart.forEach(product => {
        product.orderQuantity = 1; // Set default quantity to 1
      });
      console.log(this.ArrCart[0].orderQuantity);
    })
  }

 
  ngOnInit(): void {
    this.GetCart();
    this.tatacliqservice.getShop().subscribe((Response)=> {
      this.Shop=Response;
      this.pincodearray = this.Shop.map((shop) => shop.pincode);
      this.pincodearray = [...new Set(this.pincodearray)];
      console.log(this.pincodearray)
      console.log(this.Shop);
    })
  }

  decreaseQuantity(product: any) {
    if (product.orderQuantity > 1) {
      product.orderQuantity--;
    }
  }

  increaseQuantity(product: any) {
    if (product.orderQuantity <  product.stockQuantity ) {
      product.orderQuantity++;
    }
    else{
      this.toastr.error('Out Of Stock', 'Error', { timeOut: 3000 });
      
    }
  }

   AddToOrder(){  
    if(confirm('Your Order will be placed')){
      console.log("add to order is provoked")
      console.log(this.customerName,this.mop,this,this.address)
       this.ArrCart.forEach(element => {
         let temp = {
          cartId : element.cartId,
           orderQuantity: element.orderQuantity
          }
          this.products.push(temp);
       }
       );
       this.orders.name = this.customerName;
       this.orders.address = this.address;
       this.orders.modeOfPayment = this.mop;
       this.orders.shopAddressId=this.shopAddressId;
       this.orders.products = this.products;
       console.log('this is orders object',this.orders)
       this.tatacliqservice.AddToOrder(this.orders).subscribe();
       this.router.navigate(['/order-placed']);
     }
     else{
      this.router.navigate(['/cart-page']);
     }
    }


    isShopAddressId: boolean = false;

    showShopAddressId(): void {
      if (this.isShopAddressId) {
        // Slide toggle is turned on, perform any necessary action
        // For example, set isShopAddressId to false
        this.isShopAddressId = false;
        
      } else {
        // Slide toggle is turned off, perform any other necessary action
        // For example, set isShopAddressId to true
        this.isShopAddressId = true;
      }
    }


    
}
