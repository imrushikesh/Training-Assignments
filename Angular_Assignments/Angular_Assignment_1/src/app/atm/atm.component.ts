import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-atm',
  templateUrl: './atm.component.html',
  styleUrls: ['./atm.component.css']
})
export class ATMComponent implements OnInit {
balance:number;
MyName:string="";

  constructor() {
    this.balance=2000;

   }

  ngOnInit(): void {
  }


  
// Create a ATM Component with balance data member and show_Balance(),Withdraw(),Deposited()
//  methods create button showBalance,withdrawAmount,DepositeAmount 
//  as per the button click change balance and display it,


  Show_Balance():void{
    console.log( this.balance);
  }
 
  Withdraw(withdraw_amt:number):void{
     this.balance=this.balance-withdraw_amt;
      console.log (this.balance);
  }


  Deposite(deposite_amt:number):void{
    this.balance=this.balance+deposite_amt;
    console.log(this.balance);
  }


}




