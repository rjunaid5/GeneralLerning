// Map filter reduce

//map copies an array and apply itteration over it and makes new array

const arr = [1, 2, 4, 5];

const multiplyarr = arr.map((num, index, arr) => {
    return num * 3;
}
);

console.log(multiplyarr); // [3,6,12,15]


// filter returns those element from array which fulils certain criteria

const morethan2 = arr.filter((num) => {
    return num > 2;
})

console.log(morethan2); //[4,5]

// reduce it reduce the array to one element

const reducearr = arr.reduce((accumulator, currentElementofArray, index, arr ) => {
    return accumulator + currentElementofArray;
}, 0)
