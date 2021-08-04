'use strict';

const request = new XMLHttpRequest()

request.addEventListener('readystatechange',(e)=>{
    if(e.target.readyState === 4)
    {
        const data = JSON.parse(e.target.responseText)
        console.log(data)
    }
})


request.open('GET','https://reqres.in/api/users/2')
request.send()



