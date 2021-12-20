import { Component, OnInit } from '@angular/core';
import { NumberValueAccessor } from '@angular/forms';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }



  // Create Product component accept product_name, price, qty and 
  // discount write a method to generate bill and display it in tabular format.

product:string="Mobile";
price:number=5000;
qty:number=2;
total:number=0;


Bill():number {
this.total= this.price* this.qty;
console.log(this.total);
return this.total
}



}
