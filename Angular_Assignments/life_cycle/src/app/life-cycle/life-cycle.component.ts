import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-life-cycle',
  templateUrl: './life-cycle.component.html',
  styleUrls: ['./life-cycle.component.css']
})
export class LifeCycleComponent implements OnInit {
  
  name="rushikesh";
  message:string="welcome.....";
  checkbox="on";
  hideme=true;
  constructor() {
    console.log("from constructor")
   }

  ngOnInit(): void {
    console.log("from ngOnInit");
  }

  ngOnChanges(){
    console.log("this is change event")
  }

  ngDoCheck(){
    console.log("this is do check event");
  }

  ngAfterContentInit(){
    console.log("this is after content init");
  }
  ngOnDestroy(){
    console.log("destory event");
  }

}
