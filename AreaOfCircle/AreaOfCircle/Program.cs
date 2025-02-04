class CircleArea {
    static void Main() { 
        decimal pi=(22M/7M);
        System.Console.WriteLine("Enter the Radius for circle:");
        decimal radius= System.Convert.ToDecimal(System.Console.ReadLine());
        decimal ansArea= pi * radius * radius;
        System.Console.WriteLine("Area of circle is:");
        System.Console.Write(ansArea);
    }
}