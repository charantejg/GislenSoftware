const square = function(num)
{
    return num * num
}

const newSquare = (num)=>{num * num}

console.log(newSquare(5))

const persons = [
    {
        name: 'Tej',
        age: 30
    },
  {
      name: 'Jason', age: 20
  }]

  const findPerson = persons.find((p)=> p.age < 30)
  console.log(findPerson.name)

