def fibonacci(n):
    num1 = 0;
    num2 = 1;
    array = [];
    i=3;

    if n==1:
        array.append(num1);
        return array;
    elif n==2:
        array.append(num1);
        array.append(num2);
        return array;
    else:
        array.append(num1);
        array.append(num2);

        while i<=n:
            num3 = num1+num2;
            array.append(num3);
            num1=num2;
            num2=num3;
            i=i+1;
        return array;


print(fibonacci(13));
