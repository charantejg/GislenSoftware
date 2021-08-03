const months = ['Jan','Feb', 'March', 'Dec']

console.log(months)
months.sort()
console.log(months)

const masterLocations = [{
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

    const sortedList = masterLocations.sort(function(a,b)
    {
        if(a.city.toLowerCase() <b.city.toLowerCase())
        return -1
        else if(b.city.toLowerCase() <a.city.toLowerCase())
        return 1
        else
        return 0
    })

    console.log(sortedList)