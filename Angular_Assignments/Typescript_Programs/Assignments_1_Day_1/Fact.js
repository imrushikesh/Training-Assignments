// Program 3 
// write a function to find a factorial of number
function factorial(num) {
    var fact = 1;
    for (var i = 1; i <= num; i++) {
        fact = fact * i;
    }
    console.log(fact);
}
factorial(4);
