

class Employee {


    id:number=24;
    name:string="rushikesh";
    sal:number=25000;


 display():void {
    console.log(this.id+" "+this.name+" "+this.sal);
}




}


let emp= new Employee();
emp.display();