import { Component, OnDestroy, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

import { interval, Observable, Subscription } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit, OnDestroy {

  constructor(private router: Router) { }
  private mySubscription: Subscription;

  userForm: FormGroup;
  agentName: string = 'book agent';


  ngOnInit(): void {

   this.userForm = new FormGroup({

       'name': new FormControl(null, Validators.required),
       'email': new FormControl(null,[Validators.required, Validators.email] )
   });


    let count = 0;

    const customObservable = Observable.create((observer)=>{

    });



  }

  ngOnDestroy()
  {
     this.mySubscription.unsubscribe();
  }

  onLoadBooks()
  {
    this.router.navigate(['/books']);
  }

  onAddUser()
  {
    console.log(this.userForm);
  }


}
