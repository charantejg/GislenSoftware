import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Observable, observable } from 'rxjs';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-auth',
  templateUrl: './auth.component.html',
  styleUrls: ['./auth.component.css']
})
export class AuthComponent implements OnInit {

  constructor(private authService: AuthService) { }

  ngOnInit(): void {
  }

  onSubmit(form: NgForm)
  {
     if(!form.valid)
      {  return; }

      const email = form.value.email;
      const password = form.value.password;
      let authService: Observable<T>

      authService = this.authService.login(email, password);

  }


  authService.subscribe(data => { console.Log(data)});

}
