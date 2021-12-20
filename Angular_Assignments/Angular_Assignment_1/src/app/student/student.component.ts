import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

//  Create Student component accept id,name,marks for 3 subject calculate percentage
// And display data in tabular format



  id=1;
  name ="rushikesh";
  math = 75;
  phy = 85;
  che = 70;
  per:number=0;

display():number{
this.per = (this.math + this.phy + this.che) / 3;
console.log(this.per);
return this.per

}


}
