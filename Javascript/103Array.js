const places = ['Bengaluru', 'Mysuru', 'Chennai','Hyderabad']

const index = places.indexOf('Mysuru')
console.log(`Mysore is located at index ${index+1}`)

const location = [{
   city: 'Bengaluru',
   location: 'south'},
   {
      city: 'Mysore',
      location: 'south' 
   },
   {
       city: 'Chennai',
       location:'south east'
   }]

   const newIndex = location.findIndex(function(localtiy,index)
   {
       return localtiy.city === 'Mysore'
   })
   console.log(newIndex)

   const newLocation = location.find(function(locality, index)
   {
       return locality.city.toLowerCase() === 'mysore'
   })
   
   console.log(newLocation)

   console.log('a' < 'A')

   








