namespace Lab_6;

public class Lab6Class
{
    public string Str1
    {
        // 11.
        get => str1!;
        set => str1 = value;
    }

    public string? Str2
    {
        get => str2;
        set => str2 = value;
    }

    public int Num1
    {
        get => num1;
        set => num1 = value;
    }

    public int? Num2
    {
        get => num2;
        set => num2 = value;
    }

    public double DNum1
    {
        get => dNum1;
        set => dNum1 = value;
    }

    public double? DNum2
    {
        get => dNum2;
        set => dNum2 = value;
    }

    public int Length
    {
        get => length;
        set => length = value;
    }

    private string str1;
    private string? str2;
    private int num1;
    private int? num2;
    private double dNum1;
    private double? dNum2;

    // 6.
    private int length;

    public Lab6Class(string str1, string? str2, int num1, int? num2, double dNum1, double? dNum2)
    {
        this.str1 = str1;
        this.str2 = str2;
        this.num1 = num1;
        this.num2 = num2;
        this.dNum1 = dNum1;
        this.dNum2 = dNum2;

        // 6.
        length = str1!.Length;
    }

    public override string ToString()
    {
        return $"{str1} {str2 ?? "Данные отсутствуют"} {num1} {(num2 != null ? num2.ToString() : "Данные отсутствуют")} " +
               $"{dNum1} {(dNum2 != null ? dNum2.ToString() : "Данные отсутствуют")}";
    }
}