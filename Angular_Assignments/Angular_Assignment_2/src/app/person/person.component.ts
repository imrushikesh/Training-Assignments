import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent implements OnInit {
person:any[]=[{
  id:1,
  name:"rushikesh",
  city:"sangli"
},
{
  id:2,
  name:"ethan",
  city:"pune"
}]
  constructor() { }

  ngOnInit(): void {
  }

}
