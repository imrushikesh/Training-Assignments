


// Program 4

// write a function to find max of  array number function should take array as a parameter  and return max value




function ArrayMax (arr:number[]){

    var max:number = arr[0];    
	
    for (let i=0;i<arr.length;i++) {       
       if(arr[i] > max)  {  
           max = arr[i];
       }
    }   
    return max;

}

var arr=[5,55,-2,6,3,87];
console.log(ArrayMax(arr));