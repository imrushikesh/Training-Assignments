// Program 8
// write a class product
// pid
// pname
// amount
// discount
// qty
// calculate discount  
var Product = /** @class */ (function () {
    function Product(pid, pname, amount, qty, discount) {
        this.pid = pid;
        this.pname = pname;
        this.amount = amount;
        this.discount = discount;
        this.qty = qty;
    }
    Product.prototype.CalculateTotalPrice = function () {
        var dis = (this.amount * this.discount) / 100;
        this.total = (this.amount - dis) * this.qty;
        console.log(this.total);
    };
    Product.prototype.display = function () {
        console.log(this.amount + " * " + this.qty + " price => " + (this.amount * this.qty) + " Discount = " + this.discount + " Total==>" + this.total);
    };
    return Product;
}());
var pro = new Product(1, "mobile", 2000, 2, 30);
pro.CalculateTotalPrice();
pro.display();
