namespace Math;

public class Complex

{

    private int real;
    private int imaginary;

    public Complex()
    {
        this.real=100;
        this.imaginary=789;
    }

    public void SetReal(int real)
   
    {
        this.real=real;
    }

    public void SetImaginary(int imaginary)
    {
        this.imaginary=imaginary;
    }

    public int GetReal()
        {
            return this.real;
        }

        public int  GetImaginary()

        {
            return this.imaginary;
        }
    
}
