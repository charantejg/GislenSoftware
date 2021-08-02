let resturant =
{
    name : 'A2B',
    guestCpacity: 75,
    guestCount: 0,
    checkAvailabilty: function(pax)
    {
        // logics
        let seatsLeftout = this.guestCpacity - this.guestCount
        return seatsLeftout
    },
    RemoveSeats: function(pax)
    {

    }
}


let result = resturant.checkAvailabilty(5)
console.log(result)


// check avaiability 