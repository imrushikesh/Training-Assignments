import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'app-reactive-form-group',
  templateUrl: './reactive-form-group.component.html',
  styleUrls: ['./reactive-form-group.component.css']
})
export class ReactiveFormGroupComponent implements OnInit {

userForm:FormGroup;
country=['','india','us','japan'];

  constructor() {
    this.userForm = new FormGroup({
      name:new FormControl('', [Validators.required,Validators.minLength(5)]),
      email: new FormControl('', [Validators.required,Validators.pattern("[a-zA-Z0-9]+@[a-z]+[.][a-z]+")]),
      password:new FormControl('', [Validators.required,Validators.minLength(8)]),
      contactDetails:new FormGroup({
        landLine:new FormControl(''),
        mobile:new FormControl('')
      }),
country:new FormControl(''),


      
      })
      
  }



  onSubmit(){
    console.log(this.userForm.value);
  }

  ngOnInit(): void {
  }

}
