namespace Drawing;

public class Rectangle

{
    private int height;
    private int width;

    public Rectangle(){
        this.height=0;
        this.width=0;
    }

    public void SetHeight(int height)
    {
        this.height=height;
    }
    public void SetWidth(int width)
    {
        this.width=width;
    }
    public int GetHeight()
    {
        return this.height;
    }

    public int GetWidth()
    {
        return this.width;
    }

    public int CalculateArea(){
        return height * width;
    }
}