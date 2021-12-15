// Program 2


// write function to calculate to find discountedbill from billamount as per given condition
//   If amount is <10000 the 5%
//  if amount is>10000 and  <20000 the 10%
//  if amount is >20000 and  <30000 the 15%
//   If amount is >30000 the 25%


function DiscountBill(billamount:number){
  var dis:number;
  if (billamount>=30000){
    dis=(billamount*25)/100;
  }
  else if (billamount<30000 && billamount>=20000){
    dis=(billamount*15)/100;
  }
  else if (billamount<20000 && billamount>=10000){
    dis=(billamount*10)/100;
  }
  else if (billamount<10000){
    dis=(billamount*5)/100;
  }
  console.log(billamount+" "+dis+" "+ (billamount-dis));

}



DiscountBill(30000);