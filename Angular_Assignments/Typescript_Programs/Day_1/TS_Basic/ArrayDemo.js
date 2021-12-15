function display(arr) {
    for (var i = 0; i < arr.length; i++) {
        console.log(arr[i]);
    }
    for (var _i = 0, arr_1 = arr; _i < arr_1.length; _i++) {
        var i = arr_1[_i];
        console.log(i);
    }
    for (var i in arr) {
        console.log(i);
    }
}
var myArr = ["rushikesh", "patil"];
display(myArr);
