let a = 5;
console.log(a);

let num = 100;
let array = [];
let primeNumbers =[];

for (i = 2; i <= 100; i++) {
  array.push(i)
} 

console.log(array);


for (let x = 0; x < array.length; x++) {
  index = 0;
  for (let y = 0; y < array.length; y++){
    if ( array[x] % array[y] === 0){
      index ++
    }
  }
  if (index === 1){
    primeNumbers.push(array[x]);
  }
}

// let prime = [];

// for (i =1; i <array.length; i++) {
//   for (let x =0; x < array.length; x++) {
//     if (array[i] % array[x] !== 0) {
//       prime.push(array[i]);
//     }
//   }
// }

// console.log(prime)
console.log(primeNumbers);