import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared/shared.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  searchTerm: string = '';
  headerSearchTerm: string = '';
  searchPlaceholders: string[] = ['Search For Products', 'Search For Brands', 'Search For Categories'];
  searchPlaceholder: string = this.searchPlaceholders[0]; 
  currentPlaceholderIndex: number = 0;

  constructor(private sharedService : SharedService) { }

  ngOnInit(): void {
    setInterval(() => {
      this.updatePlaceholderText();
    }, 2000);
  }

  updatePlaceholderText(): void {
    this.currentPlaceholderIndex = (this.currentPlaceholderIndex + 1) % this.searchPlaceholders.length;
    this.searchPlaceholder = this.searchPlaceholders[this.currentPlaceholderIndex];
  }

  updateSearchTerm(term :string){
    this.sharedService.changeSearch(term);
  }

}
