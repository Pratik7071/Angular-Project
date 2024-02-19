import { Component, OnInit, ViewChild } from '@angular/core';
import { Product } from 'src/app/Models/Product';
import { TataCliqWebApi } from 'src/app/Service/TataCliqWebApi';
import { FormBuilder, FormControl, FormGroup, ValidationErrors, Validators } from '@angular/forms';
import { MatPaginator } from '@angular/material/paginator';
import { MatTable, MatTableDataSource, MatTableModule, _MatTableDataSource } from '@angular/material/table';
import { Category } from 'src/app/Models/Category';
import { Brand } from 'src/app/Models/Brand';
import { MatSort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';
import { Observable, map, switchMap } from 'rxjs';
import { ToastrService } from 'ngx-toastr';
import message from 'src/assets/validation_en.json'
import { MatProgressSpinner } from '@angular/material/progress-spinner';
import { SlicePipe } from '@angular/common';
import {MatCheckboxModule} from '@angular/material/checkbox';
 
 
@Component({
  selector: 'app-product-management',
  templateUrl: './product-management.component.html',
  styleUrls: ['./product-management.component.css']
})
 
export class ProductManagementComponent implements OnInit {
  showSubmitButton: boolean = true;
  showUpdateButton: boolean = false;
  ProductFormGroup!: FormGroup;
  FilterForm!:FormGroup;
  ProductArr: Product[] = [];
  CategoryArr: Category[] = [];
  BrandArr: Brand[] = [];
  dataSource: any;
  product: Product = {} as Product;
  productIDToUpdate: number = 0;
  errorMessages: any = message;
  apierror: boolean = false;
  api_error_code!: number;
  api_error_message: any;
  sortDirection: 'asc' | 'desc' = 'asc';
  tempStockQuantity: number = 0;
  progressBarForm: boolean = false;
 
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatTable) myTable!: MatTable<any>;

  defaultFormValues = {
    productName: '',
    productDescription: '',
    actualProductPrice: '',
    discountPercentage: '',
    finalProductPrice: '',
    stockQuantity: '',
    categoryId: '',
    brandId: '',
    enableDiscounts: false,
  };
 
  displayedColumns: string[] = [
    'productName',
    'productDescription',
    'Price',
    'stockQuantity',
    'categoryName',
    'brandName',
    'editButton',
    'wishlist'
  ];
 
  filterData(){
    console.log("filter method is execute")
    let filterString = "";
    if(this.FilterForm.get('stockCheckBox')?.value){
      filterString = "product.stockQuantity > 0"
    }
    if(this.FilterForm.get('brandId')?.value !== null){
      if(filterString.length > 0){
        filterString = filterString + "&&"
      }
      filterString = filterString + "product.brandId === this.FilterForm.get('brandId')?.value"
    }
    if(this.FilterForm.get('categoryId')?.value){
      if(filterString.length > 0){
        filterString = filterString + "&&"
      }
      filterString = filterString + "product.categoryId === this.FilterForm.get('categoryId')?.value"
    }
    if(filterString.length > 0){
    this.dataSource = new MatTableDataSource<Product>()
    this.dataSource.data =this.ProductArr.filter(product => eval(filterString) );
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
      }else{
      console.log("this is else method");
      this.dataSource.data = this.ProductArr;
    }
    console.log(this.dataSource.data);
    this.myTable.renderRows();
  }
  constructor(private serviceApi: TataCliqWebApi, private fb: FormBuilder, private httpClient: HttpClient, private toastr: ToastrService) { }
 
 
  ngOnInit(): void {
    this.ProductFormGroup = this.fb.group({
      productName: [''],
      productDescription: ['', [Validators.required, Validators.pattern('^[a-zA-Z0-9].*$'), this.spaceValidaterDescription.bind(this)]],
      actualProductPrice: [null, [Validators.pattern(/^-?\d*\.?\d+$/), Validators.min(1), Validators.required]],
      discountPercentage: [null, [Validators.min(0), Validators.max(99), Validators.pattern(/^-?\d*\.?\d+$/)]],
      finalProductPrice: [{ value: null, disabled: true }, Validators.pattern(/^-?\d*\.?\d+$/)],
      stockQuantity: ['', [Validators.min(0), Validators.pattern(/^-?\d*\.?\d+$/), Validators.required]],
      categoryId: ['', Validators.required],
      brandId: ['', Validators.required],
      enableDiscounts: [false]
     
    });
    this.FilterForm = this.fb.group({
      stockCheckBox:[false],
      brandId:[null],
      categoryId:[null]
    })
    this.FilterForm.valueChanges.subscribe(()=>{
      this.filterData();
    });
    this.getAllProducts();
    this.getAllCategories();
    this.getAllBrands();
  }
 
  ngAfterViewInit(): void {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
    this.sort.disableClear = true;
    this.sort.sortChange.subscribe(() => {
      if (this.sort.active === 'Price') {
        this.applySorting()
      }
      // this.myTable.renderRows();
    });
  }
 
  addToWishlistsInProgress: boolean = false;

addToWishlists(productId: number) {
  if (this.addToWishlistsInProgress) {
    return;
  }

  this.addToWishlistsInProgress = true;
  console.log('product:', productId);
  this.serviceApi.addToWishlist(productId)
    .subscribe(() => {
      this.addToWishlistsInProgress = false;
    });
}

toggleWishlist(product: Product) {
  this.isProductInWishlist(product.productId).subscribe(isInWishlist => {
    if (isInWishlist) {
      // Product is already in the wishlist, show toaster and return
      this.toastr.warning('The product is already in the wishlist.');
      return;
    }

    // Toggle the addedToWishlist flag
    product.addedToWishlist = true;

    // Add the product to the wishlist
    this.addToWishlists(product.productId);
  });
}


isProductInWishlist(productId: number): Observable<boolean> {
  const userId = 1;
  return this.serviceApi.GetWishlist().pipe(
    map((wishlistItems: any[]) => wishlistItems.some(item => item.productId === productId))
  );
}

  
  
  
  applySorting() {
    this.dataSource.data = this.sortData(this.dataSource.data, this.sort);
    // this.dataSource.sort = this.sort;
    // this.dataSource.paginator = this.paginator
  }
 
  sortData(data: Product[], sort: MatSort): Product[] {
    const sortedData = [...data];//creating an shallow copy
    if (sort.direction) {
      sortedData.sort((a, b) => {
        const price1 = a.finalProductPrice;
        const price2 = b.finalProductPrice;
        return sort.direction === 'asc' ? price1 - price2 : price2 - price1;
      });
    }
    return sortedData;
  }
 
  addProduct(val: Product): void {
    this.progressBarForm =true;
    this.product.productName = this.ProductFormGroup.get('productName')?.value;
    this.product.productDescription = this.ProductFormGroup.get('productDescription')?.value;
    this.product.actualProductPrice = this.ProductFormGroup.get('actualProductPrice')?.value;
    this.product.stockQuantity = this.ProductFormGroup.get('stockQuantity')?.value;
    this.product.categoryId = this.ProductFormGroup.get('categoryId')?.value;
    this.product.brandId = this.ProductFormGroup.get('brandId')?.value;
    if (this.ProductFormGroup.get('enableDiscounts')?.value) {
      if ([null, undefined, ""].includes(this.ProductFormGroup.get('discountPercentage')?.value)) {
        this.product.discountPercentage = 0;
      } else {
        this.product.discountPercentage = this.ProductFormGroup.get('discountPercentage')?.value;
      }
      this.product.finalProductPrice = this.ProductFormGroup.get('finalProductPrice')?.value;
    } else {
      this.product.discountPercentage = 0;
      this.product.finalProductPrice = this.ProductFormGroup.get('actualProductPrice')?.value;
    }
    this.serviceApi.createProduct(this.product).pipe(
      switchMap(() => this.serviceApi.getAllProductService())
    ).subscribe({
      next: (response) => {
        this.ProductArr = response;
        this.dataSource = new MatTableDataSource<Product>(this.ProductArr);      
        this.dataSource.paginator = this.paginator;
        this.dataSource.sort = this.sort;
        this.filterData();
      },
      error: (error) => {
        this.toastr.error(error.status + message.toastrMessages['failure-create']);
      },
      complete: () => {
        this.toastr.success(message.toastrMessages['success-create']);
        this.cancel();
      }
    });
    this.progressBarForm =false;
  }
 
  calculateDiscount() {
    const actualPriceValue = this.ProductFormGroup.get('actualProductPrice')?.value;
    const discountPercentageValue = this.ProductFormGroup.get('discountPercentage')?.value;
    if ((!([null, 0, "", undefined].includes(actualPriceValue)) && !(([null, 0, "", undefined]).includes(discountPercentageValue)))) {
      const discountedPrice = actualPriceValue - (actualPriceValue * discountPercentageValue / 100);
      this.ProductFormGroup.patchValue({
        finalProductPrice: discountedPrice.toFixed(2)
      });
    } else {
      this.ProductFormGroup.patchValue({
        finalProductPrice: this.ProductFormGroup.get('actualProductPrice')?.value
      });
    }
  }
 
  cancel() {
    this.ProductFormGroup.reset(this.defaultFormValues);
    this.showSubmitButton = true;
    this.showUpdateButton = false;
    this.ProductFormGroup.enable();
    this.ProductFormGroup.get('finalProductPrice')?.disable();
  }
 
  showToUpdate(id: number) {
    this.productIDToUpdate = id;
    const selectedProduct = this.ProductArr.find(product => product.productId === id);
    if (selectedProduct) {
      this.setFormValues(selectedProduct);
    }
    this.ProductFormGroup.disable();
    this.ProductFormGroup.get('stockQuantity')?.enable();
    this.showSubmitButton = false;
    this.showUpdateButton = true;
  }
 
  setFormValues(selectedProduct: Product) {
    this.ProductFormGroup.setValue({
      productName: selectedProduct.productName,
      productDescription: selectedProduct.productDescription,
      actualProductPrice: selectedProduct.actualProductPrice,
      discountPercentage: selectedProduct.discountPercentage,
      finalProductPrice: selectedProduct.finalProductPrice,
      stockQuantity: selectedProduct.stockQuantity,
      categoryId: selectedProduct.categoryId,
      brandId: selectedProduct.brandId,
      enableDiscounts: true,
      // stockCheckBox : this.ProductFormGroup.get('stockCheckBox')?.value
    })
    this.tempStockQuantity = this.ProductFormGroup.get('stockQuantity')?.value;
  }
 
  toUpdate() {
    this.progressBarForm = true;
    const selectedProduct = this.ProductArr.find(product => product.productId === this.productIDToUpdate);
    if (selectedProduct) {
      selectedProduct.stockQuantity = this.ProductFormGroup.get('stockQuantity')?.value;
      this.updateProduct(selectedProduct)
      this.showSubmitButton = true;
      this.showUpdateButton = false;
      this.ProductFormGroup.reset(this.defaultFormValues);
      this.ProductFormGroup.enable();
      this.ProductFormGroup.get('finalProductPrice')?.disable();
     
    }
    this.filterData();
  }
 
  oneAlphabetValidator(control: FormControl): ValidationErrors {
    const enteredProductName = control.value;
    const atleastOneAlphabets = /[a-zA-Z]/.test(enteredProductName);
    const onlyNumber = /^\d+$/.test(enteredProductName);
    if ((atleastOneAlphabets === true) && (onlyNumber === false)) {
      return { atleastOneAlphabet: false }
    }
    else {
      return { atleastOneAlphabet: true }
    }
  }
 
  uniqueNameValidator(control: FormControl): ValidationErrors | null {
    const enteredProductName = control.value.toLowerCase().trim();
    const isDuplicate = this.ProductArr.some(product => product.productName.toLowerCase() === enteredProductName);
    return isDuplicate ? { duplicateProductName: true } : null;
  }
 
  spaceValidaterDescription(control: FormControl): ValidationErrors | null {
    const enteredProductName = control.value.trim();
    let isValidLength = false;
    if (enteredProductName.length >= 30) {
      isValidLength = true;
    }
    return isValidLength ? null : { lengthInvalid: true };
  }
 
  spaceValidaterName(control: FormControl): ValidationErrors | null {
    const enteredProductName = control.value.trim();
    let isValidLength = false;
    if (enteredProductName.length >= 3) {
      isValidLength = true;
    }
    return isValidLength ? null : { lengthInvalid: true };
  }
 
  getAllProducts() {
    this.serviceApi.getAllProductService().subscribe({
      next: (response) => {
        this.ProductArr = response;
        this.dataSource = new MatTableDataSource<Product>();
        this.dataSource.data = this.ProductArr
        this.dataSource.sort = this.sort;
        this.dataSource.paginator = this.paginator;
      },
      error: (error) => {
        this.apierror = true;
        this.api_error_code = error.status;
      }
    }
    )
  }
 
  getAllCategories() {
    this.serviceApi.getAllCategoryService().subscribe({
      next: (response) => {
        this.CategoryArr = response;
      },
      error: (error) => {
        this.apierror = true;
        this.api_error_code = error.status;
      }
    }
    );
  }
 
  getAllBrands() {
    this.serviceApi.getAllBrandService().subscribe({
      next: (response) => {
        this.BrandArr = response;
      },
      error: (error) => {
        this.apierror = true;
        this.api_error_code = error.status;
      }
    }
    );
  }
 
  updateProduct(selectedProduct: Product) {
    this.serviceApi.updateProduct(selectedProduct).subscribe({
      error: (error) => {
        console.log(error)
        this.toastr.error(error.status + message.toastrMessages['failure-update'] );
        selectedProduct.stockQuantity = this.tempStockQuantity;
      },
      complete: () => {
        this.toastr.success(message.toastrMessages['success-update']);
        this.tempStockQuantity = 0;
        this.progressBarForm =false;
      }
    })
  }
 
}