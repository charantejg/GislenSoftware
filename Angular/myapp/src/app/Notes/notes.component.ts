import { Component } from "@angular/core";

@Component({
  templateUrl: './notes.component.html',
  selector: 'app-notes'

})
export class NotesComponent
{
  title:string = "my  title"
  isActive = false
  description = "This is my description"
  notesPath ="https://image.shutterstock.com/image-illustration/small-yellow-compact-car-260nw-394558741.jpg"

  constructor()
  {
    setTimeout(()=>
     {this.isActive = true},
     5000);
  }


 generateTitle()
 {
   this.title = "This is a new title"
 }

}

