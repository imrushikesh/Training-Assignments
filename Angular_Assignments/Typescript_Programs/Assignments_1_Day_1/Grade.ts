




// program 7
// write a Student class in type script in following data member constructor
// roll-no
// name
// marks[]//number
// Percentage
// Grade
// write a method to display info and calculate  result and assign grade as per percentage



class student {

    rollno:number;
    name:string;
    math:number;
    phy:number;
    che:number;
    
    
    
    constructor(rollno:number,name:string,math:number,phy:number,che:number,)
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
    
    
    grade:string

    Grade():void{
        if (this.per>=80){
            this.grade="A";
        }
        else if (this.per>=65 && this.per<80){
            this.grade="B";
        }
        else if (this.per>=55 && this.per<65){
            this.grade="C";
        }
        else if (this.per>=35 && this.per<55){
            this.grade="D";
        }
        else if (this.per<35){
            this.grade="failed"
        }
        else{
            this.grade="invalid"
        }
        console.log(this.grade);
    }

    display():void {
        console.log(this.rollno+" "+this.name+" "+this.per+" "+this.grade);
    }
    
    
    
    
    }
    
    
    
    
    let stud= new student(1,"student_1",80,88,88);
    stud.calculate();
    stud.Grade();
    stud.display();
