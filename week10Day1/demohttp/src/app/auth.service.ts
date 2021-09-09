import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import {tap} from 'rxjs/operator';
import { throwError } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpClient) { }


  login(email: string, password: string)
  {
      let loginUrl = 'http://localhost/resortapi/api/Account/login';
      return this.http.post(loginUrl, {email: email,password: password}).pipe
      (
        //catchError(this.handleError)
        tap(data=>{  console.log(data)})
      )
  }
}
