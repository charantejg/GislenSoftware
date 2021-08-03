// Filtering

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
    },
    {
        city: 'puducheri',
        location:'south east'
    }]


/* const southEastCities = location.filter(function(locality, index)
{
    return locality.location === 'south east'
}) */

const query = 'south east'
const southEastCities = function(location, query)
{
   return location.filter(function(locality, index)
    {
        return locality.location.toLowerCase() === query
    })
}

console.log(southEastCities)

