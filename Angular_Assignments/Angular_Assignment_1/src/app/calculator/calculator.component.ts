import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent implements OnInit {

  num1:number=0;
  num2:number=0;
  result:number=0;

  constructor() { }

  ngOnInit(): void {
  }


  add(num1:number,num2:number){
   this.result= (this.num1)+(this.num2); 
   console.log(this.result);  
  }

  sub(num1:number,num2:number){
    this.result=(this.num1-this.num2);   
    console.log(this.result);  
   }


   mult(num1:number,num2:number){
    this.result=(this.num1*this.num2);   
    console.log(this.result);  
   }


   div(num1:number,num2:number){
    this.result=(this.num1/this.num2);   
    console.log(this.result);  
   }

  // Create calculator component which access two numbers from user and 
  // perform task Addition,substraction,multiplication,division

}
