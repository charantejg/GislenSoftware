import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-book-display',
  templateUrl: './book-display.component.html',
  styleUrls: ['./book-display.component.css']
})
export class BookDisplayComponent implements OnInit {

 @Input() bookElement: {type: string, name: string, description: string}

  constructor() { }

  ngOnInit(): void {
  }

}
