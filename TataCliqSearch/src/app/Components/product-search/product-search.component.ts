import { Component, OnInit, ViewChild } from '@angular/core';
import { ProductService } from 'src/product.service';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Product } from '../../Models/product.model';
import { MatInput } from '@angular/material/input';
import { SharedService } from 'src/app/shared/shared.service';

@Component({
  selector: 'app-product-search',
  templateUrl: './product-search.component.html',
  styleUrls: ['./product-search.component.css'],
})
export class ProductSearchComponent implements OnInit {
  searchTerm: string = '';
  discountTerm: string = '';
  searchResults: any[] = [];
  Available : boolean = true
  searchPlaceholders: string[] = ['Search For Products', 'Search For Brands', 'Search For Categories'];
  currentPlaceholderIndex: number = 0;
  isShowBody : boolean = true;
  searchPlaceholder: string = this.searchPlaceholders[0]; 
  isToggleOn = false;

  displayedColumns: string[] = [
    'productName',
    'productDescription',
    'categoryName',
    'brandName',
    'actualProductPrice',
    'discountPercentage',
    'finalProductPrice',
  ];

  dataSource: any;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatInput) input!: MatInput;


  constructor(private apiService: ProductService, private sharedService : SharedService) { }
  
  searchProducts() {
      this.apiService.searchProducts(this.searchTerm, this.discountTerm).subscribe({
        next: (data) => {
          this.searchResults = data;
          this.dataSource.data = this.searchResults;
        },
      });
  }




  ngOnInit(): void {
    this.searchTerm = '';
    this.discountTerm = '';
    this.searchProducts();

    this.sharedService.currentSearch.subscribe(
      search => this.searchTerm  = search);
    

    this.apiService
      .searchProducts(this.searchTerm, this.discountTerm)
      .subscribe({
        next: (response) => {
          this.searchResults = response;
          this.dataSource = new MatTableDataSource<Product>(this.searchResults)
          console.log(this.searchResults)

        },
        error: (error) => console.error(error)

      });
  }

  updatePlaceholderText(): void {
    // Cycle through the array of placeholders
    this.currentPlaceholderIndex = (this.currentPlaceholderIndex + 1) % this.searchPlaceholders.length;
    this.searchPlaceholder = this.searchPlaceholders[this.currentPlaceholderIndex];
  }

  onToggleChange(): void {
    this.isToggleOn = !this.isToggleOn;
  }

  ngAfterViewInit(): void {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
    console.log(this.paginator);
    console.log(this.dataSource)
    this.paginator.page.subscribe((event: PageEvent) =>
      console.log('Page Event triggered', event))

  }

  ShowBodyData(){
    isShowBody : true;
  }
}
