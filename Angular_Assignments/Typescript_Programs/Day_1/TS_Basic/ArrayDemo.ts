



function display(arr:string[]){


for ( let i=0;i<arr.length;i++){

console.log(arr[i]);
}

//elements
for (let i of arr){
    console.log(i);
}
// in = index
for (let i in arr){
    console.log(i);
}


}


var myArr= ["rushikesh","patil"];
display(myArr);