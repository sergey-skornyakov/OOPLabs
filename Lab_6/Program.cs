using Lab_6;

namespace Lab_6
{
    static class Program
    {
        // 8.
        public static void AssignValueStr1(Lab6Class instance)
        {
            instance.Str1 ??= "Empty string";
            instance.Num2 ??= 0;
            instance.DNum2 ??= 0.0;
        }

        // 9.
        public static string GetPropertyValueWithNullableInstance(Lab6Class? instance)
        {
            return instance?.Str1 ?? "String";
        }

        // 10.
        public static string GetPropertyValueWithNullableProperty(Lab6Class instance)
        {
            return instance.Str1 ?? "String";
        }

        static void Main(string[] args)
        {
            Lab6Class  lab6Class1 = new Lab6Class("Text 1", "Text 2", 1, 2, 5.1, 4.3);
            Lab6Class  lab6Class2 = new Lab6Class("Text 1", null, 1, 2, 5.2, 4.3);
            Lab6Class  lab6Class3 = new Lab6Class("Text 1", "Text 2", 1, null, 5.3, 4.3);
            Lab6Class  lab6Class4 = new Lab6Class("Text 1", "Text 2", 1, 2, 5.4, null);
            Console.WriteLine(lab6Class1);
            Console.WriteLine(lab6Class2);
            Console.WriteLine(lab6Class3);
            Console.WriteLine(lab6Class4);

            Console.WriteLine("5.1 Если присвоить null свойству типа string, которое не может принимать null, то строка " +
                              "автоматически примет пустое значение.");
            Console.WriteLine("5.2 Если написать после null восклицательный знак, то будут подавляться предупреждения о " +
                              "возможном null значении.");
            Console.WriteLine("6.1 Если присвоить null значение переменной типа int или double, то возникает ошибка на " +
                              "этапе компиляции о невозможности преобразовать null в int или double. Тот же эффект будет " +
                              "и при использовании восклицательного знака.");
        }
    }
}