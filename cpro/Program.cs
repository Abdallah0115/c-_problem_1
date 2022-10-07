using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpro
{

    class Program
    {
         static void Main(string[] args)
        {
            
            try
            {
                int key = 0;
                do
                {
                    Console.WriteLine("if you want rect type (R) else square type (S) ");
                    string x = Console.ReadLine();
                    if(x=="R")
                    {
                        Console.WriteLine("***********************");
                        Console.WriteLine("enter width:");
                        float z =float.Parse( Console.ReadLine());
                        Console.WriteLine("enter hight:");
                        float y= float.Parse(Console.ReadLine());
                        rect j = new rect(z,y);
                        Console.WriteLine("************************");
                        Console.WriteLine("aria is:{0}", j.aria());
                        Console.WriteLine("IF want to continue write 0");
                        key = int.Parse(Console.ReadLine());
                    }
                    else if (x == "S")
                    {
                        Console.WriteLine("***********************");
                        Console.WriteLine("enter width:");
                        float z = float.Parse(Console.ReadLine());
                        square j = new square(z, z);
                        Console.WriteLine("************************");
                        Console.WriteLine("aria is:{0}", j.aria());
                        Console.WriteLine("IF want to continue write 0");
                        key = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("error: retype again you didn't choose posible thing");
                        key = 0;
                    }
                } while (key == 0);
                }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey(true);
        }
         
    }
    public abstract class shap
    {
        float hight;
        float width;
         public virtual float aria(){
            return 0;
        }
        public  void print()
        {
            Console.WriteLine(this.aria());
        }
        public void setWidth(float x)
        {
            width = x;
        }
        public void setHight(float x)
        {
            hight = x;
        }
        public float getWidth()
        {
          return   width ;
        }
        public float getHight()
        {
           return hight ;
        }
    }
    public sealed  class square:shap
    {
        public square(float x,float y)
        {
            setHight(x);
            setWidth(y);
        }
        public override float  aria()
        {
            return getHight() * getWidth();
        }
    }
    public sealed class rect : shap
    {
        public rect(float x, float y)
        {
            setHight(x);
            setWidth(y);
        }
        public override float aria()
        {
            return getHight() * getWidth();
        }
    }
}
