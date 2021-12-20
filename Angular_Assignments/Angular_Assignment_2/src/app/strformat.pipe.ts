import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'strformat'
})
export class StrformatPipe implements PipeTransform {

  transform(value: string, operator:string): unknown {
   
    return  value.replace(/ /g,operator);
  }

}
