var Employee = /** @class */ (function () {
    function Employee() {
        this.id = 24;
        this.name = "rushikesh";
        this.sal = 25000;
    }
    Employee.prototype.display = function () {
        console.log(this.id + " " + this.name + " " + this.sal);
    };
    return Employee;
}());
var emp = new Employee();
emp.display();
