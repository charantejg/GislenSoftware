const myBook =  {
     title: 'Let us C',
     author: 'Yashwant',
     noOfPages: 500
}

// constructor functions

const myBookInfo = function(title, author, noOfPages)
{
    this.title =title
    this.author = author
    this.noOfPages = noOfPages

}

myBookInfo.prototype.getIntro = function()
{
   console.log(`${this.title} is written by ${this.author}`)
}


const book1 = new myBookInfo('Let us C', 'Yashwant',500)
console.log(book1)
book1.getIntro()

const book2 = new myBookInfo('Python guide','Robert', 300)
console.log(book2)





