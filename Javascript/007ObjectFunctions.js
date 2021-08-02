let myBook =  {
    title: 'Let us C',
    author: 'Yashwant',
    noOfPages: 500
}

let myOtherBook =  {
    title: 'Javascriot bible',
    author: 'Yashwant',
    noOfPages: 300
}

let getSummary = function(book)
{
    return {
        summary: `${book.title}  by ${book.author}`
    }
}

let bookSummary = getSummary(myBook)
let otherBookSummary = getSummary(myOtherBook)

console.log(bookSummary.summary)
console.log(otherBookSummary.summary)




