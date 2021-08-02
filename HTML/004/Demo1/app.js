


//1. check for button click
//2. add a new contnet paragraph  

document.querySelector('button').addEventListener
('click', function(e)
{
    console.log(e)
        const p = document.createElement('p')
    p.textContent = 'A new paragraph is created by javascript'
    document.querySelector('body').append(p)
})

/* document.querySelector('#firstName').addEventListener
('change',function(e)
{
    console.log(e.target.value)
}) */

document.querySelector('#simple-form').addEventListener
('submit',function(e)
{
    e.preventDefault()
    console.log(e.target.elements.firstName.value)
    console.log(e.target.elements.lastName.value)
    
})


//console.log(p)

//const ps = document.querySelectorAll('p')

/* ps.forEach(function(p)
{
    if(p.textContent.includes('The'))
    {
        console.log(p.textContent)
        p.textContent = "*************"

    }
   
}) */





