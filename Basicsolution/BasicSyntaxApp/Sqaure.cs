namespace Sqaure;


  public class Sqaure
   {
        private int Side;

        public Sqaure()
        {
            this.Side=13;
        }
         
         public void setSide(int Side)
         {
            this.Side=Side; 

         }
         public int getSide()
    {
       return  this.Side;
    }

    public int CalculateAreaofSide()
    {
        return 2 * Side;
    }
   }
 