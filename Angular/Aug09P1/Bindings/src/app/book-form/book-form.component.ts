import { Component, OnInit,  EventEmitter, Output } from '@angular/core';


@Component({
  selector: 'app-book-form',
  templateUrl: './book-form.component.html',
  styleUrls: ['./book-form.component.css']
})
export class BookFormComponent implements OnInit {

  bookName = '';
  bookDesc = '';
 @Output() bookCreated = new EventEmitter<{name:string, description:string}>();

  constructor() { }

  ngOnInit(): void {
  }

  onAddBook()
  {
    this.bookCreated.emit({name:this.bookName, description: this.bookDesc})
    
   /*  this.bookList.push({
      type: 'book',
      bookName: this.bookName,
      bookDesc: this.bookDesc
    }); */
  }

}
