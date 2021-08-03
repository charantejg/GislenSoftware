

try
{
    const result = 100 / 0
    
    throw Error('null')
}
catch(e)
{
   console.log(`Divide by Zero , ${e.result}`)
   
}