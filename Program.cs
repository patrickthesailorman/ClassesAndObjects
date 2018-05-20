using System;

namespace Bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var dozer = new BullDozer {"Yellow", "mini"};

            var dozer = new BullDozer {"Red", "Large"};

            Console.WriteLine("Bulldozer 1 is: " + dozer.color);
            Console.WriteLine("Bulldozer 2 is: " + dozer2.color);
        }
    }
    public class BullDozer
    {
   
    public BullDozer(string color, string size) 
        {
          this.color = color;
              this.size = size;
               
        }
            public string color { get; set; }
            public string size { get; set; }
    }
}