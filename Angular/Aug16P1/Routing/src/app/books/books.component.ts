import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {

  @ViewChild('myform') booksForm: NgForm;
  booktype = ['paperback', 'ebook'];

  book = {
    title: '', authoremail: '', btype: ''
  }


  constructor() { }

  ngOnInit(): void {

    this.booksForm.form.patchValue({
      bookData: {title: 'Default Name'}
    });
  }

  onSubmit(form: NgForm)
  {
       console.log(this.booksForm);

       this.book.title = this.booksForm.value.bookData.title;
       this.book.authoremail = this.booksForm.value.bookData.authoremail;


  }

}

