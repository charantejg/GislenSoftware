class Book
{
   constructor(title,author,noOfPages)
   {
       this.title = title
       this.author = author
       this.noOfPages = noOfPages
   }

   getIntro()
   {
       return `${this.title} is written by ${this.author}`
   }

}

class Ebook extends Book
{
    constructor(title,author,noOfPages, website)
    {
        super(title,author,noOfPages)
        this.website = website
    }
}



const book1 = new Book('Javascript guide','Shiv',500)

console.log(book1)
console.log(book1.getIntro())

const ebook1 = new Ebook('Javascript guide','Shiv',500,'amazon.com')
console.log(ebook1)
