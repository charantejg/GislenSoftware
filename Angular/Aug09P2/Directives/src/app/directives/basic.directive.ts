import { Directive, ElementRef, HostBinding, HostListener, OnInit, Renderer2 } from "@angular/core";

@Directive({
  selector: '[basicDirective]'
})
export class basicDirective implements OnInit
{
     constructor(private elementRef: ElementRef, private rednerer: Renderer2){}

     ngOnInit()
     {
        //  this.elementRef.nativeElement.style.backgroundColor = 'yellow';
        this.rednerer.setStyle(this.elementRef.nativeElement, 'backgroundColor','blue');
     }
    
     // mouseenter
     @HostListener('mouseenter') mouseover(eventData: Event)
     {
     // this.rednerer.setStyle(this.elementRef.nativeElement, 'backgroundColor','yellow');
     this.backgroundColorChanger = 'blue';
     }

     // mouseleave
     @HostListener('mouseleave') mouseLeve(eventData: Event)
     {
      //this.rednerer.setStyle(this.elementRef.nativeElement, 'backgroundColor','transparent');
      this.backgroundColorChanger = 'transparent';

     }

     @HostBinding('style.backgroundColor') backgroundColorChanger = '';





}
