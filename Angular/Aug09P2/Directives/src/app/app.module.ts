import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { basicDirective } from './directives/basic.directive';
import { AdvanceDirective } from './directives/advance.directive';

@NgModule({
  declarations: [
    AppComponent,
    basicDirective,
    AdvanceDirective
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
