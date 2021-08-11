@Directive
({ selector: '[c]'})
export class BetterHighlight implements onInit
{

  constructor(private renderer: Renderer2, private elRef: ElementRef)
  {}

  ngOnInit()
  {
    this.renderer.setStyle(this.elRef.nativeEelement,'back-groundcolor', 'yellow',false, false);

  }

  @HostListener('mouseenter') mouseover(eventData: Event)
  {
    this.renderer.setStyle(this.elRef.nativeEelement,'back-groundcolor', 'yellow',false, false);
  }

  @HostListener('mouseleave') mouseLeave(eventData: Event)
  {
    this.renderer.setStyle(this.elRef.nativeEelement,'back-groundcolor', 'transperent',false, false);

    this.backgroundColor = 'blue';
  }

  @HostBinding('style.backgroundColor') backgroundColor: string = 'transperent';
}
}
