class student {

    id:number;
    name:string;
    marks:number;



constructor(id:number,name:string,marks:number){
 this.id=id;
 this.name=name;
 this.marks=marks;
}

// acceptDetails(id:number,name:string,marks:number):void{
//  this.id=id;
//  this.name=name;
//  this.marks=marks;
// }


show():string{
    return "hello......"
}

display():void{
    console.log(this.id+" " +this.name+" "+this.marks)
}

}


let stud= new student(1,"student_1",505);
//stud.acceptDetails(1,"student_1",444);
console.log(stud.show());
stud.display();


