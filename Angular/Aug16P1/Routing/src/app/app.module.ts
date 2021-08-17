import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { BooksComponent } from './books/books.component';
import { UsersComponent } from './users/users.component';
import { RouterModule, Routes } from '@angular/router';
import { BookComponent } from './books/book/book.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

const appRouting : Routes =[
  { path: '', component: HomeComponent },
  { path: 'books', component: BooksComponent },
  {path: 'users', component:UsersComponent},
  {path: 'book/:id', component:BookComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    BooksComponent,
    UsersComponent,
    BookComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(appRouting),
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
