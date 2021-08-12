import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NewAccountComponent } from './new-account/new-account.component';
import { AccountDisplayComponent } from './account-display/account-display.component';
import { LoggingService } from './logging.service';
import { AccountsService } from './accounts.service';

@NgModule({
  declarations: [
    AppComponent,
    NewAccountComponent,
    AccountDisplayComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [LoggingService, AccountsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
