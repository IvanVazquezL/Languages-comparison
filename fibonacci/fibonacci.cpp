#include <iostream>
#include <queue>
using namespace std;

queue<int> fibonacci(int n){
  queue<int> myQueue;
  int num1 = 0;
  int num2 = 1;
  int num3;
  int i=3;

  if(n==1){
    myQueue.push(num1);
    return myQueue;
  }
  else if(n==2){
    myQueue.push(num1);
    myQueue.push(num2);
    return myQueue;
  }
  else{
    myQueue.push(num1);
    myQueue.push(num2);

    while(i<=n){
      num3 = num1+num2;
      myQueue.push(num3);
      num1=num2;
      num2=num3;
      i++;
    }

    return myQueue;
  }
}

int main() {
  queue<int> receiver;

  receiver = fibonacci(3);

  while(!receiver.empty()){
    cout << receiver.front()<<endl;
    receiver.pop();
  }
  return 0;
}
