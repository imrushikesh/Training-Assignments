import { Pipe, PipeTransform } from '@angular/core';


@Pipe({
  name: 'words'
})
export class WordsPipe implements PipeTransform {

  transform(value: string): unknown {
    value = value.replace(/(^\s*)|(\s*$)/gi,"");
    value = value.replace(/[ ]{2,}/gi," ");
    value = value.replace(/\n /,"\n");
    return value.split(' ').length;
    ;
  }

}
