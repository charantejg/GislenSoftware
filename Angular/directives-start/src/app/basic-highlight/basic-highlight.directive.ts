@BasicDirective({

  selector: '[app-basic]'
})
export class BasicDirective implements onInit
{
    constructor()
    {private elementref: ElementRef}

    ngonint()
    {
      this.elementRef.nativeElement.style.backgroundColor = 'yellow';
    }
}
