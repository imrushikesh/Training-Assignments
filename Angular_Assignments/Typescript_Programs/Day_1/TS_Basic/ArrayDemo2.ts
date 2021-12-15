



function sumOfArray(arr:number[]) {
    let sum=0;
    for (let i=0;i<arr.length;i++){
        sum=sum+arr[i];
    }
    return sum;
}


var MyArr =[4,5,3,2,1];
console.log(sumOfArray(MyArr));