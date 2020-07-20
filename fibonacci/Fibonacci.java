import java.util.LinkedList;
import java.util.Queue;

public class Fibonacci {
  static Queue fibonacciGenerator(int n) {
    int num1 = 0;
    int num2 = 1;
    int num3;
    int i = 3;
    Queue myQueue = new LinkedList();

    if(n==1){
        myQueue.add(num1);
        return myQueue;
    }
    else if(n==2){
        myQueue.add(num1);
        myQueue.add(num2);
        return myQueue;
    }
    else{
        myQueue.add(num1);
        myQueue.add(num2);
        while(i<=n){
            num3 = num1+num2;
            myQueue.add(num3);
            num1=num2;
            num2=num3;
            i++;
        }
        return myQueue;
    }
 }

  public static void main(String[] args) {
    Queue receiver = new LinkedList();
    receiver = fibonacciGenerator(13);

    System.out.println(receiver);
  }
}
