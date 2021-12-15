

// from ecmmascript module started. 

import { Area,Area2 } from "./Cal";

let Obj=new Area();

let obj2 =new Area2();

Obj.CalArea();
obj2.CalArea();

// tsc --module commonjs ModuleDemo.ts
//  node ./ModuleDemo 