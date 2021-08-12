import { Component, Input, OnInit, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-account-display',
  templateUrl: './account-display.component.html',
  styleUrls: ['./account-display.component.css']
})
export class AccountDisplayComponent implements OnInit {

 @Input() account: {name:string, status: string};
 @Output() statusChange = new EventEmitter<{id:number; status:string}>()
 @Input() id: number;

  constructor() { }

  ngOnInit(): void {
  }

  onSet(status:string)
  {
    console.log('sending new status from child: '+ status);
     this.statusChange.emit({id:this.id, status: status});
  }

}
