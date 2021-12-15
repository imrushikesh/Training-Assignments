// Program 5
// find the Array even  element sum and return it.
function EvenSum(arr) {
    var even = 0;
    for (var i = 0; i < arr.length; i++) {
        if (arr[i] % 2 == 0) {
            even = even + arr[i];
        }
    }
    console.log(even);
}
var arr = [2, 2, 1];
EvenSum(arr);
