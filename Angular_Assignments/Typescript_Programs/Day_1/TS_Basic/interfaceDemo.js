var MyBook = /** @class */ (function () {
    function MyBook(id, name, author, price) {
        this.id = id;
        this.name = name;
        this.author = author;
        this.price = price;
    }
    MyBook.prototype.CreateBook = function () {
        for (var i = 0; i < 2; i++) {
            this.arr = [
                {
                    "book_id": this.id,
                    "book_name": this.name,
                    "book_author": this.author,
                    "book_price": this.price
                }
            ];
        }
    };
    MyBook.prototype.ListDetails = function () {
        console.log("I am from Interface.");
        console.log(this.arr);
    };
    return MyBook;
}());
for (var j = 0; j < 2; j++) {
    var book = new MyBook(1, "book_1", "author_1", 2500);
    book.CreateBook();
    book.ListDetails();
}
