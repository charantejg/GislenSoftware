// Scoping - Lexical scoping 
// Global scope 
// Local scope 

let value1 = 'myValue'

if(true)
{
    console.log(value1)
    let value2 = 'mynewValue'
    console.log(value2)
}

console.log(value1)
