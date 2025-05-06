let zahl = Number(prompt("Erste Zahl?"))+Number(prompt("Zweite Zahl?"))
alert(zahl)

for (let i=0;i<=100;i++){
    if (i%3 === 0 && i%5===0){
        console.log("FizzBuzz")
            }
    else if(i%5 === 0){
        console.log("Buzz")
    }
    else if(i%3===0){
        console.log("Fizz")
    }
    else{
        console.log(i)
    }
}