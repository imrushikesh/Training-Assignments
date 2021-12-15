// program 7
// write a Student class in type script in following data member constructor
// roll-no
// name
// marks[]//number
// Percentage
// Grade
// write a method to display info and calculate  result and assign grade as per percentage
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
    student.prototype.Grade = function () {
        if (this.per >= 80) {
            this.grade = "A";
        }
        else if (this.per >= 65 && this.per < 80) {
            this.grade = "B";
        }
        else if (this.per >= 55 && this.per < 65) {
            this.grade = "C";
        }
        else if (this.per >= 35 && this.per < 55) {
            this.grade = "D";
        }
        else if (this.per < 35) {
            this.grade = "failed";
        }
        else {
            this.grade = "invalid";
        }
        console.log(this.grade);
    };
    student.prototype.display = function () {
        console.log(this.rollno + " " + this.name + " " + this.per + " " + this.grade);
    };
    return student;
}());
var stud = new student(1, "student_1", 80, 88, 88);
stud.calculate();
stud.Grade();
stud.display();
