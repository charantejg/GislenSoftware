import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { LoggingService } from '../logging.service';
import { AccountsService } from '../accounts.service';


@Component({
  selector: 'app-new-account',
  templateUrl: './new-account.component.html',
  styleUrls: ['./new-account.component.css'],


})
export class NewAccountComponent implements OnInit {

  //@Output() accountCreation = new EventEmitter<{name:string,status:string}>();

  constructor(private log: LoggingService, private accountService: AccountsService) { }

  ngOnInit(): void {

    /* this.accountService.OnaccountCreation()
     .subscribe(arg => this.property = arg); */

  }

  onAccountCreated(inputname:string, status:string)
  {

    this.accountService.OnaccountCreation(inputname, status);
    this.log.logger('adding  new name and  status in child: '+ inputname +',' + status);
   // this.accountCreation.emit({name: inputname, status: status});
  }



}
