namespace HomeWorkMethodOverloading;

public class HighNumber
{
    public int HighResult(int number1, int number2, int number3)
    {
        if (number1 > number2 && number1 > number3)
        {
            return number1;
        }
        else if (number2 > number1 && number2 > number3)
        {
            return number2;
        }
        else
        {
            return number3;
        }
    }
    public int HighResult(int number1, int number2, int number3, int number4)
    {
        int result = HighResult(number1, number2, number3);
        if (number4 > result) return number4;
        else return result;
    }
    public int HighResult(int number1, int number2, int number3, int number4, int number5)
    {
        int result = HighResult(number1, number2, number3, number4);
        if (number5 > result) return number5;
        else return result;
    }
}
