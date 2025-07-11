namespace Math;
using Drawing;
using Circle;
using Sqaure;

public class Program
{
    private string Name=String.Empty;
    private string Description=String.Empty;
    private string  Author=string.Empty;

    public static  void Main(string []args)
    {
        Program P1= new Program();
        P1.Name="Maths";
        P1.Description="Addition";
        P1.Author="Swapnali Deshpande";

        Console.WriteLine(P1.Name);
        Console.WriteLine(P1.Description);
        Console.WriteLine(P1.Author);

        Complex  C1=new Complex();
        C1.SetImaginary(56);
        C1.SetReal(90);
        Console.WriteLine(C1.GetImaginary());
        Console.WriteLine(C1.GetReal());
        //Area of Rectangle
        Rectangle r1=new Rectangle();
        Console.WriteLine("Enter value for R1");

        Console.WriteLine("Enter width");
        int width=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter height");
        int height=Convert.ToInt32(Console.ReadLine());

        r1.SetHeight(height);
        r1.SetWidth(width);

        int area=r1.CalculateArea();

        Console.WriteLine("Area ="+ area);
        //Area of Circle
        Circle c1=new Circle();
        Console.WriteLine("Enter value for C1");

        Console.WriteLine("Enter Radius");
        int Radius=Convert.ToInt32(Console.ReadLine());
        c1.setRadius(Radius);
        int Areaofcircle=c1.CalculateAreaofCircle();
        Console.WriteLine("Areaofcircle ="+ Areaofcircle);
        //Area of Square
        Sqaure s1=new Sqaure();
        int Side=Convert.ToInt32(Console.ReadLine());
        s1.setSide(Side);
        int CalculateAreaofSide=s1.CalculateAreaofSide();
        Console.WriteLine("Areaofcircle ="+ CalculateAreaofSide);
        
        
        


    }
}
