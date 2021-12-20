import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'division'
})
export class DivisionPipe implements PipeTransform {

  transform(value: number, num_divisor:number): unknown {
    return value/num_divisor;
  }

}
