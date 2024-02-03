namespace lab2Task5Library;

public class Class1
{
    public static double Max2Num(double number1, double number2)
    {
        double max;
        if (number1 > number2)
            max = number1;
        else
            max = number2;

        Console.WriteLine($"The MAX value between {number1} and {number2} is {max}");
        return max;

    }

    public static double Max3Num(double number1, double number2, double number3)
    {
        double max;
        if (number1 > number2 && number1 > number3)
            max = number1;
        else if (number2 > number1 && number2 > number3)
            max = number2;
        else
            max = number3;

        Console.WriteLine($"The MAX value between {number1}, {number2}, and {number3} is {max}");
        return max;
    }
    //Mekhi Wood-Brock
    //CPS3330
    //Section *01
    //Lab #2

}


