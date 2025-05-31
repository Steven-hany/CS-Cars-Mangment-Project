namespace FinalProject
{
    internal interface Cars
    {
         string Name { get; internal set; }
         string Model { get; internal set; }
         string Color { get; internal set; }
         int Year { get; internal set; }
         string Engine { get; internal set; }
         int Price { get; internal set; }
         void ADD_Data()
        {
            File.AppendAllText("cars.txt", this.Name + " " + this.Model + " " + this.Color + " " + this.Year + " " + this.Engine + " " + this.Price + "*");
        }
        string[] Show_Data();
        
    }

}