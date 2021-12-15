

interface IBook{
    ListDetails ():void;

}


class MyBook implements IBook{

    id:number;
    name:string;
    author:string;
    price:number;
 arr: any[];

    
    constructor(id:number,
        name:string,
        author:string,
        price:number){

            this.id=id;
            this.name=name;
            this.author=author;
            this.price=price;
    }

    CreateBook():void{

        for (let i=0;i<2;i++){
                    this.arr=[
                        {
                          "book_id":this.id,
                          "book_name":this.name,
                          "book_author":this.author,
                          "book_price":this.price,

                        }
                    ]
                }
    }
    ListDetails(): void {
                console.log("I am from Interface.");
               console.log(this.arr);
        }

}

for (let j=0;j<2;j++){
    let book = new MyBook(1,"book_1","author_1",2500);
    book.CreateBook();
    book.ListDetails();
}