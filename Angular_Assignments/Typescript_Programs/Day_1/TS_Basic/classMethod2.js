var student = /** @class */ (function () {
    function student(rollno, name, math, phy, che) {
        this.rollno = rollno;
        this.name = name;
        this.math = math;
        this.phy = phy;
        this.che = che;
    }
    student.prototype.calculate = function () {
        this.per = (this.math + this.phy + this.che) / 3;
        console.log(this.per);
    };
    student.prototype.display = function () {
        console.log(this.rollno + " " + this.name + " " + this.per);
    };
    return student;
}());
var stud = new student(1, "student_1", 67, 56, 78);
stud.calculate();
stud.display();
//assign grade.-- program
