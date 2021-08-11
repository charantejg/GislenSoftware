import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';


import { AppComponent } from './app.component';
import { BasicDirective } from './basic-highlight/basic-highlight.directive';
import { BetterHighlight } from './basic-highlight/better-directive';

@NgModule({
  declarations: [
    AppComponent,
    BasicDirective,
    BetterHighlight
  ],
  imports: [
    BrowserModule,
    FormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
