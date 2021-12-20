import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-reactiveform',
  templateUrl: './reactiveform.component.html',
  styleUrls: ['./reactiveform.component.css']
})
export class ReactiveformComponent implements OnInit {
  //admission:FormGroup;
  constructor(public fb:FormBuilder) {}
    // grouping of controls provided by formbuilder
   admission=this.fb.group({
     // name must be same as html -->
     fullname:[''],
     email:[''],
     password:[''],
     mobile:[''],
     country:['']
   })
 
   country=['india','usa','japan'];
 
   ngOnInit(): void {
  }

  onSubmit(){
    console.log(this.admission.value);
  }

}
