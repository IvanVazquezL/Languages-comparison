var num1 = 0;
var num2 = 1;
var num3;
var array = [];
var i=3;
 
 
function fibonacciGenerator(n){
 if(n==1){
   array.push(num1);
   return array;
 }
 else if(n==2){
   array.push(num1);
   array.push(num2);
   return array;
 }
 else{
   array.push(num1);
   array.push(num2);
 
   while(i <= n)
   {
     num3 = num1+num2;
     array.push(num3);
     num1=num2;
     num2=num3;
     i++;
   }
   return array;
 }
 
}
 
alert(fibonacciGenerator(13));