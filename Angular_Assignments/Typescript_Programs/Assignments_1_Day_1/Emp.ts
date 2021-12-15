// write a employee class with data constructor

// eid
// empname
// deptno
// salary
// HRA
// DA
// gross salary
// calculate gross salary on the base of
// if basic salary <20000 then HRA 20% and  DA  80%
// if basic salary   >20000 and<35000 then HRA 25% and DA 70%

class Emp{
    eid:number;
    empname:string;
    deptno:string;
    salary:number;
    gross:number;
    hra:number;
    da:number;
    constructor( eid:number,empname:string,deptno:string,salary:number){
this.eid=eid;
this.empname=empname;
this.deptno=deptno;
this.salary=salary;
    }


cal():void {
    if (this.salary>20000 && this.salary<35000){
        this.hra =(this.salary*25)/100;
        this.da=(this.salary*75)/100;
        this.gross=(this.salary+this.hra+this.da);
    }
    else if (this.salary<20000){
        this.hra =(this.salary*20)/100;
        this.da=(this.salary*80)/100;
        this.gross=(this.salary+this.hra+this.da);
    }
    else {
        console.log("invalid");
    }

    console.log(this.salary+" hra= "+this.hra+" da= "+this.da+" total sal- "+this.gross);

}

}


var emp=new Emp(1,"emp_1","dept_1",32000);
emp.cal();