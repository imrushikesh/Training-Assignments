import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-form-demo',
  templateUrl: './form-demo.component.html',
  styleUrls: ['./form-demo.component.css']
})
export class FormDemoComponent implements OnInit {

  country= ["India", "usa", "russia", "uk"];

  constructor() { }

  ngOnInit(): void {
  }

  onSubmit(Value:any){
    console.log(Value);
  }

}
