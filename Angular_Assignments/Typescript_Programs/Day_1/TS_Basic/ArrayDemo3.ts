

function positionElements(arr:string[]){
    for (let i=0;i<arr.length;i++)
    {
        if(i%2==0)
        {
            console.log(arr[i]);
        }
    }
}

function Reverse(arr:string[]){
    for (let i=arr.length-1;i>=0;i--)
    {
            console.log(arr[i]);
    }
}



var myArr=["red","green","white","black","brown"];
//positionElements(myArr);
Reverse(myArr);