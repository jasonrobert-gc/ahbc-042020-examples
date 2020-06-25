// Self invoking function
(function () {
    console.log('hello class');

    var i = 25;   // number
    var j = "25"; // string
    
    console.log(i == j);  // true
    console.log(i === j); // false
    
    compare(i, j);
    
    function compare(first, second) {
        if (first === second) {
            console.log('first === second');
        } else {
            console.log('first !== second');
        }
    }
})();