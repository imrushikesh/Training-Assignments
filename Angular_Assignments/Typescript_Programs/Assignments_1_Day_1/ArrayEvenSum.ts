


// Program 5

// find the Array even  element sum and return it.


function EvenSum (arr:number[]){
		var even:number=0;
		for (let i =0;i<arr.length;i++) {
			if(arr[i]%2==0) {
			even=even+arr[i];
			}
		}
	    console.log(even);
		
    }

 var  arr= [1,2,3,4,5,6,2];

 EvenSum(arr);