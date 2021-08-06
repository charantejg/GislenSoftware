import { Component } from "@angular/core";

@Component({
  templateUrl: './notes.component.html',
  selector: 'app-notes'

})
export class NotesComponent
{
  title:string = "my  title"
  isActive = false
  description = "Default Description"
  notesPath ="https://image.shutterstock.com/image-illustration/small-yellow-compact-car-260nw-394558741.jpg"
  newFlag = false
  myNotes = ['Notes 1', 'Notes 2', 'Notes 3']

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

 onExecute()
 {
   this.description = 'The description is changed by button click';
   this.newFlag = true;
 }

 OnUpdate(event:any)
 {
   this.description = event.target.value;
 }

}

