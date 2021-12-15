

// function factorial (num:number){

//     var fact =1;
//     // for (let i=1;i<=num;i++){
//     //     fact=fact*i;
//     // }
//     let i=1;
//     while(i<=num){
//         fact=fact*i;
//         i++;
//     }
//     return fact;
// }


// console.log(factorial(5));



function sumOfNum (num:number){
    let sum=0;

    for (let i=1;i<=num;i++)
    sum=sum+i;
    return sum;
}

console.log(sumOfNum(10));