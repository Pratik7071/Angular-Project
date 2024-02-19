import { Component, EventEmitter, Output } from '@angular/core';
import { ProductService } from 'src/product.service';
import { Product } from './Models/product.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'TataCliqSearch';
}
