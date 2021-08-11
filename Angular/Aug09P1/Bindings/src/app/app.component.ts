import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Bindings';

  bookList = [];


  OnBookCreated(bookData: {name: string, description: string})
  {
     this.bookList.push({
       type:'book',
       name: bookData.name,
       description: bookData.description
     });
  }



  }

