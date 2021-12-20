import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-custom-pipe1',
  templateUrl: './custom-pipe1.component.html',
  styleUrls: ['./custom-pipe1.component.css']
})
export class CustomPipe1Component implements OnInit {

  divident:number=0;
  divisor:number=0;
  constructor() { }

  ngOnInit(): void {
  }

}
