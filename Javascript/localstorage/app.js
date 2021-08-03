const notes = []

document.querySelector('#createNote').addEventListener('click',
function(e){

   // console.log('test')
    notes.push({title:'My first task of the day' })

    console.log(notes)

    localStorage.setItem('mynote',JSON.stringify(notes))

    localStorage.removeItem('mynote')

    const mynewInfo = localStorage.get('mynote')

    localStorage.clear()

})