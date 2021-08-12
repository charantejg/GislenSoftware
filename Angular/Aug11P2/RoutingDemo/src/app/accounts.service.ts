import { Injectable } from '@angular/core';
import { LoggingService } from './logging.service';

@Injectable({
  providedIn: 'root'
})
export class AccountsService {

  constructor(private loggingServices: LoggingService) { }

  studentList:{name:string, status:string}[] = [];


  OnaccountCreation(name:string, status:string)
  {
    this.studentList.push({name:name, status:status});

     this.loggingServices.logger(this.studentList.toString());
  }

  onStatusChange(student:{id:number, status: string})
  {
    this.studentList[student.id].status = student.status;
   // console.log('updated status in parent: '+  student.status);
  }
}
