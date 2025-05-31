using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class BMW
    {
        public class B : Cars
        {
            public string Name { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int Year { get; set; }
            public string Engine { get; set; }
            public int Price { get; set; }

            public void ADD_Data()
            {
                File.AppendAllText("B.txt", this.Name + " " + this.Model + " " + this.Color + " " + this.Year + " " + this.Engine + " " + this.Price + "*");
            }

            public string[] Show_Data()
            {
                string d = File.ReadAllText("B.txt");
                return d.Split('*');
            }
        } 

    }
}