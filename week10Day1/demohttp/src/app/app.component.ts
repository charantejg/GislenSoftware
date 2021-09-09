import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'demohttp';

  constructor(private http: HttpClient){}

  ngOnint()
  {
     // this.onCreate({email:'test3@test.com', password: 'Testbed@123' });
  }

  onCreate(loginDto:{email: string,password: string})
{
    console.log(loginDto);
   this.http.post('http://localhost/resortapi/api/Account/login',loginDto).subscribe
   (responseData=>{
     console.log(responseData);
   });

}

onFetch()
{
  this.http.get('http://localhost/resortapi/WeatherForecast')
  .subscribe(data=>{console.log(data)});
}


}


