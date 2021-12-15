var student = /** @class */ (function () {
    function student(id, name, marks) {
        this.id = id;
        this.name = name;
        this.marks = marks;
    }
    // acceptDetails(id:number,name:string,marks:number):void{
    //  this.id=id;
    //  this.name=name;
    //  this.marks=marks;
    // }
    student.prototype.show = function () {
        return "hello......";
    };
    student.prototype.display = function () {
        console.log(this.id + " " + this.name + " " + this.marks);
    };
    return student;
}());
var stud = new student(1, "student_1", 505);
//stud.acceptDetails(1,"student_1",444);
console.log(stud.show());
stud.display();
