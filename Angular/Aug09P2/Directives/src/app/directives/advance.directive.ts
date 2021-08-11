import { Directive, ElementRef, Input, TemplateRef, ViewContainerRef } from '@angular/core';

@Directive({
  selector: '[appAdvance]'
})
export class AdvanceDirective {

  @Input() updateStatus(condition: boolean){

    if(condition)
    {
      this.viewRef.createEmbeddedView(this.templateRef)
    }
    else
    {
      this.viewRef.clear();
    }
  }
  constructor(private templateRef: TemplateRef<any>, private viewRef: ViewContainerRef ) { }

}
