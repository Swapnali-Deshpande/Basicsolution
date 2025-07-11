namespace Circle
{

public class Circle
{   
    private int Radius;

    public Circle()
    {
        int Radius=1;
    } 
    public void setRadius(int Radius)

    {
        this.Radius=Radius;
    }

    public int getRadius()
    {
       return  this.Radius;
    }

    public int CalculateAreaofCircle()
    {
        return 3 * Radius;
    }
}
}

