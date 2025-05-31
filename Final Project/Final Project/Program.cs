namespace FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Car Management System\n************************\n");
            string s;
            do
            {
                Console.WriteLine("Enter NO. of choice\n1.BMW\n2.Mercedes\n3.Mustang\n4.show details of my BMW\n5.show details of my Mercedes\n6.show details of my Mustang\n7.search by Model\n************************ ");
                int ch = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                string Name = string.Empty, Model = string.Empty, Color = string.Empty, Engine = string.Empty;
                int Year = 0, Price = 0;
                if (ch == 1 || ch == 2 || ch == 3)
                {
                    Console.WriteLine("Enter the name of the car:");
                    Name = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("********************\nEnter the model of the car:");
                    Model = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("********************\nEnter the color of the car:");
                    Color = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("********************\nEnter the year of the car:");
                    Year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("********************\nEnter the engine of the car:");
                    Engine = Console.ReadLine() ?? string.Empty;
                    Console.WriteLine("********************\nEnter the price of the car:");
                    Price = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }

                switch (ch)
                {
                    case 1:
                        BMW.B b1 = new BMW.B
                        {
                            Name = Name,
                            Model = Model,
                            Color = Color,
                            Year = Year,
                            Engine = Engine,
                            Price = Price
                        };
                        b1.ADD_Data();
                        Console.WriteLine("Data added to BMW file.");
                        break;
                    case 2:
                        Mercedes.M m1 = new Mercedes.M
                        {
                            Name = Name,
                            Model = Model,
                            Color = Color,
                            Year = Year,
                            Engine = Engine,
                            Price = Price
                        };
                        m1.ADD_Data();
                        Console.WriteLine("Data added to Mercedes file.");
                        break;
                    case 3:
                        Mustang.Mu mu1 = new Mustang.Mu
                        {
                            Name = Name,
                            Model = Model,
                            Color = Color,
                            Year = Year,
                            Engine = Engine,
                            Price = Price
                        };
                        mu1.ADD_Data();
                        Console.WriteLine("Data added to Mustang file.");
                        break;
                    case 4:
                        BMW.B b2 = new BMW.B();
                        string[] bData = b2.Show_Data();
                        for (int i = 0; i < bData.Length; i++)
                        {
                            string[] ss = bData[i].Split(' ');
                            for (int j = 0; j < ss.Length; j++)
                            {
                                Console.Write(ss[j] + " ");
                            }
                        }
                        break;
                    case 5:
                        Mercedes.M m2 = new Mercedes.M();
                        string[] mData = m2.Show_Data();
                        for (int i = 0; i < mData.Length; i++)
                        {
                            string[] ss2 = mData[i].Split(' ');
                            for (int j = 0; j < ss2.Length; j++)
                            {
                                Console.Write(ss2[j] + " ");
                            }
                        }
                        break;
                    case 6:
                        Mustang.Mu mu2 = new Mustang.Mu();
                        string[] muData = mu2.Show_Data();
                        for (int i = 0; i < muData.Length; i++)
                        {
                            string[] ss3 = muData[i].Split(' ');
                            for (int j = 0; j < ss3.Length; j++)
                            {
                                Console.Write(ss3[j] + " ");
                            }
                        }
                        break;
                    case 7:
                        Console.WriteLine("Enter the model to search:");
                        string New_Model = Console.ReadLine() ?? string.Empty;
                        BMW.B b3 = new BMW.B();
                        Mercedes.M m3 = new Mercedes.M();
                        Mustang.Mu mu3 = new Mustang.Mu();
                        string[] bSearchData = b3.Show_Data();
                        string[] mSearchData = m3.Show_Data();
                        string[] muSearchData = mu3.Show_Data();
                        for (int i = 0; i < bSearchData.Length; i++)
                        {
                            if (bSearchData[i].Contains(New_Model))  
                            {
                                Console.WriteLine(bSearchData[i]);
                            }
                        }
                        for (int i = 0; i < mSearchData.Length; i++)
                        {
                            if (mSearchData[i].Contains(New_Model))
                            {
                                Console.WriteLine(mSearchData[i]);
                            }
                        }
                        for (int i = 0; i < muSearchData.Length; i++)
                        {
                            if (muSearchData[i].Contains(New_Model))
                            {
                                Console.WriteLine(muSearchData[i]);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                Console.WriteLine("Do you want to add another car? (yes/no)");
                s = Console.ReadLine();
                Console.Clear();
            } while (s == "yes");
        }
    }
}
