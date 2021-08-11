import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BookFormComponent } from './book-form/book-form.component';
import { BookDisplayComponent } from './book-display/book-display.component';

@NgModule({
  declarations: [
    AppComponent,
    BookFormComponent,
    BookDisplayComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
