


// Program 3 

// write a function to find a factorial of number





function factorial (num:number){
let fact:number=1;

    for (let i=1;i<=num;i++){
        fact=fact*i;
    }
    
    console.log(fact);

}


factorial (4);