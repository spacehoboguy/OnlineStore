
using OnlineStore;

ClothingItem shirt  = new ClothingItem("Crew V-Neck", 399, 3,"Polo", "Medium", "Orange-Navy");
ElectronicItem googlePixel = new ElectronicItem("Pixel 3", 799, 2, "Premium", "3 Years");
shirt.CalculateSalesPrice();
googlePixel.CalculateSalesPrice();
Console.WriteLine("Thanks for shopping with us!");
