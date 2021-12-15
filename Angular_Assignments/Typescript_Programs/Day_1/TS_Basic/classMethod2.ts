class student {

rollno:number;
name:string;
math:number;
phy:number;
che:number;



constructor(
    rollno:number,
    name:string,
    math:number,
    phy:number,
    che:number,
    )
{

    this.rollno=rollno;
    this.name=name;
    this.math=math;
    this.phy=phy;
    this.che=che;
}  



per:number;
calculate():void{
     this.per= (this.math+this.phy+this.che)/3;
    console.log(this.per);
}


display():void {
    console.log(this.rollno+" "+this.name+" "+this.per)
}




}




let stud= new student(1,"student_1",67,56,78);
stud.calculate();
stud.display();
//assign grade.-- program