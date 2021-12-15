
// Program 8

// write a class product
// pid
// pname
// amount
// discount
// qty
// calculate discount  



class Product 
{
pid:number;
pname:string;
amount:number;
discount:number;
qty:number;

    constructor(pid:number,pname:string,amount:number,qty:number,discount:number){

        this.pid=pid;
        this.pname=pname;
        this.amount=amount;
        this.discount=discount;
        this.qty=qty;
    }

    total:number;
    CalculateTotalPrice():void{
        var dis = (this.amount*this.discount)/100;
        this.total = (this.amount - dis)*this.qty;
       console.log(this.total);
    }

    display(){
        console.log(this.amount+" * "+this.qty+" price => "+(this.amount*this.qty)+" Discount = "+this.discount+" Total==>"+this.total);
    }
}



var pro= new Product(1,"mobile",2000,2,30);
pro.CalculateTotalPrice();
pro.display();