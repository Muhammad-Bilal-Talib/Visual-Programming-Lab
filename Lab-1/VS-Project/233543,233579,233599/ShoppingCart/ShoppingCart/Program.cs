using System;
using System.IO;
using System.Collections.Generic;


class BannerDisplay
{
    public static void SetColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }

    public static void AquaColor()
    {
        SetColor(ConsoleColor.Cyan);
    }

    public static void RedColor()
    {
        SetColor(ConsoleColor.Red);
    }

    public static void WhiteColor()
    {
        SetColor(ConsoleColor.White);
    }

    public static void DisplayDigitalLine()
    {
        AquaColor();
        Console.WriteLine("    _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   _   ");
        Console.WriteLine(" |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_| |_|");
        WhiteColor();
    }

    public static void StartBanner()
    {
        RedColor();
        Console.WriteLine(@"
                      (o----+----------------------------------------------------------------------------------------------------+----o)
                             _ _     \    /\    /   _  _     __   __  _    _  _     o              _____    ___               _ _  
                            |o o|     \  /  \  /   |_  |    |    |  | |\  /| |_     o                |     |   |             |o o|
                             \-/       \/    \/    |_  |__  |__  |__| | \/ | |_     o                |     |___|              \-/  
                      (o----+----------------------------------------------------------------------------------------------------+----o)  
");
        WhiteColor();
    }

    public static void DisplayBanner()
    {
        RedColor();
        Console.WriteLine(@"
                      (o----+----------------------------------------------------------------------------------------------------+----o)
                             _ _           ___                    |  /               o        ___     _      __     _____     _ _  
                            |o o|         / \ \  _    _  *   __   |_/                o       /       /_\    |__|   /  |  \   |o o|
                             \-/          \__\/   |__|   |  |__   | \                o       \___   /   \   |  \      |       \-/  
                      (o----+----------------------------------------------------------------------------------------------------+----o)  
");
        WhiteColor();
    }

    public static void start_banner1()
    {
        // Print empty lines equivalent to the C++ code's cout statements
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");

        StartBanner();

        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");

        WhiteColor(); // Call to white_color equivalent in C#
    }
    public static void start_banner2()
    {
        // Print empty lines equivalent to the C++ code's cout statements
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");

        DisplayBanner();

        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t   \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t    \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");

        WhiteColor(); // Call to white_color equivalent in C#
    }


    public static void FinalStartBanner()
    {
        int iterations = 1; // Adjust the number of iterations as needed
        int delayMilliseconds = 250; // Adjust the delay as needed

        for (int i = 0; i < iterations; i++)
        {
            start_banner1();
            Thread.Sleep(delayMilliseconds);
            Console.Clear();
            start_banner1();
            Thread.Sleep(delayMilliseconds);
            Console.Clear();
            start_banner1();
            Thread.Sleep(delayMilliseconds);
            Console.Clear();


            start_banner2();
            Thread.Sleep(delayMilliseconds);
            Console.Clear();
            start_banner2();
            Thread.Sleep(delayMilliseconds);
            Console.Clear();
            start_banner2();
            Thread.Sleep(delayMilliseconds);
            Console.Clear();
        }
        Console.Clear();
    }

    public void FinalExitBanner()
    {
        for (int i = 0; i < 5; i++)
        {
            DisplayBanner();
            Console.Clear();
            DisplayBanner();
            Console.Clear();
        }
        DisplayBanner();
        Console.Clear();
    }

    public static void DisplayPlainLine()
    {
        AquaColor();
        Console.WriteLine("________________________________________________________________________________________________________________________________________________________________________");
        WhiteColor();
    }
    public static void DisplayPlainLinered()
    {
        RedColor();
        Console.WriteLine("________________________________________________________________________________________________________________________________________________________________________");
        WhiteColor();
    }
    public static void DisplayPlainLinegreen()
    {
        ConsoleColors.GreenColor();
        Console.WriteLine("________________________________________________________________________________________________________________________________________________________________________");
        WhiteColor();
    }
}




class ConsoleColors
{
    public static void BlueColor()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
    }

    public static void GreenColor()
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }

    public static void AquaColor()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;  // Closest to Aqua in C#
    }

    public static void RedColor()
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }

    public static void YellowColor()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }

    public static void WhiteColor()
    {
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void LightGreenColor()
    {
        Console.ForegroundColor = ConsoleColor.Green;  // Use ConsoleColor.Green for Light Green
    }

    public static void CyanColor()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }

    public static void LightRedColor()
    {
        Console.ForegroundColor = ConsoleColor.Red;  // No light red, closest is Red
    }

    public static void PurpleColor()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;  // Closest to Purple in C#
    }

    public static void SkinColor()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;  // DarkYellow resembles skin tone
    }

    public static void ResetColor()
    {
        Console.ResetColor();  // Reset the color to default
    }
}

class Product
{
    public string Name { get; }
    public decimal Price { get; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

class ShoppingCart
{
    private string username;
    private string basePath = "C:\\Users\\PMLS\\source\\repos\\ShoppingCart\\ShoppingCart";  // Base path for all files
    private string cartFile;

    public ShoppingCart(string username)
    {
        this.username = username;
        cartFile = Path.Combine(basePath, "cart.txt");  // Single cart file for all users
    }

    public void AddProductToCart(int expirationHours = 24)
    {
        Console.Clear();
        BannerDisplay.DisplayBanner();
        BannerDisplay.DisplayDigitalLine();
        ConsoleColors.LightRedColor();
        Console.WriteLine("\t   __________________  \t   \t  ____________________  \t   \t  ___________________________  ");
        Console.WriteLine("\t  |                  | \t > \t |                    | \t > \t |             *             | ");
        Console.WriteLine("\t  |    User Login    | \t > \t |        Menu        | \t > \t |         ADD TO CART       | ");
        Console.WriteLine("\t  |__________________| \t > \t |____________________| \t > \t |___________________________| ");

        BannerDisplay.DisplayDigitalLine();
        ConsoleColors.LightRedColor();
        Console.WriteLine("\t\t\t\t\t\t\t   __________________________ ");
        Console.WriteLine("\t\t\t\t\t\t\t  |                          |");
        Console.WriteLine($"\t\t\t\t\t\t\t  |    WELCOME ({username})  |");
        Console.WriteLine("\t\t\t\t\t\t\t  |__________________________|");

        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayPlainLine();
        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayDigitalLine();
        ConsoleColors.LightRedColor();
        Console.WriteLine("\t\t\t\t\t\t\t   __________________________ ");
        Console.WriteLine("\t\t\t\t\t\t\t  |                          |");
        Console.WriteLine("\t\t\t\t\t\t\t  |        ADD TO CART       |");
        Console.WriteLine("\t\t\t\t\t\t\t  |__________________________|");

        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayPlainLine();
        string productFile1 = Path.Combine(basePath, "product.txt");

        if (!File.Exists(productFile1) || new FileInfo(productFile1).Length == 0)
        {
            ConsoleColors.RedColor();
            Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t NO! PRODUCT AVAILABLE :)");
            BannerDisplay.DisplayPlainLinered();
            Console.ReadKey();
            return;
        }

        string[] lines = File.ReadAllLines(productFile1);

        // Display table headers with better alignment for ">" symbols
        ConsoleColors.CyanColor();
        Console.WriteLine("\t   __________________  \t   \t  ____________________  \t   \t  ________________________  \t   \t  ______________________   ");
        Console.WriteLine("\t  |                  | \t > \t |                    | \t > \t |                        | \t > \t |                      |  ");
        Console.WriteLine("\t  |   PRODUCT NAME   | \t > \t |        PRICE       | \t > \t |        CATEGORY        | \t > \t |       QUANTITY       |  ");
        Console.WriteLine("\t  |__________________| \t > \t |____________________| \t > \t |________________________| \t > \t |______________________|  ");
        BannerDisplay.DisplayPlainLine();

        ConsoleColors.YellowColor();

        foreach (string line in lines)
        {
            var parts = line.Split('-');  

           
            if (parts.Length < 4)
            {
                ConsoleColors.RedColor();
                Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ERROR ! PRODUCT DATA IS MISSING :)");
                ConsoleColors.WhiteColor();
                continue;
            }

            try
            {
                
                string p_name = parts[0].Trim();             
                decimal price = decimal.Parse(parts[1].Trim());  
                string category = parts[2].Trim();           
                int quantity = int.Parse(parts[3].Trim()); 

               
                Console.WriteLine(
                    $"\t  | {p_name.PadRight(16)} |   > \t | {price.ToString("C").PadRight(18)} | \t > \t | {category.PadRight(22)} | \t > \t | {quantity.ToString().PadRight(20)} |"
                );
            }
            catch (Exception ex)
            {
                
                ConsoleColors.RedColor();
                Console.WriteLine($"Error processing product: {line} - {ex.Message}");
                ConsoleColors.WhiteColor();
            }
        }

        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayPlainLine();

        // Ask for product name and quantity
        Console.Write("\n\n\n\t\t\t\t\t Enter Product Name To ADD\t :::::::::: \t");
        string inputProductName = Console.ReadLine().Trim();  

        Console.Write("\n\n\n\t\t\t\t\t Enter Quantity\t\t\t :::::::::: \t");
        if (int.TryParse(Console.ReadLine(), out int inputQuantity) && inputQuantity > 0) 
        {
            string productFile = Path.Combine(basePath, "product.txt");
            string[] lines1 = File.ReadAllLines(productFile1);
            bool productFound = false;

            foreach (string line in lines1)
            {
                var parts = line.Split('-'); 

                if (parts[0].Trim().Equals(inputProductName, StringComparison.OrdinalIgnoreCase))
                {
                    string p_name = parts[0].Trim(); 
                    decimal price = decimal.Parse(parts[1].Trim());  
                    string category = parts[2].Trim();  
                    int availableQuantity = int.Parse(parts[3].Trim()); 

                    if (inputQuantity > availableQuantity)
                    {
                        ConsoleColors.RedColor();
                        Console.WriteLine($"\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tSORRY! ONLY {availableQuantity} AVAILABLE IN STOCK :)");
                        BannerDisplay.DisplayPlainLinered();
                        Console.ReadKey();
                        return;
                    }

                    decimal total_price = price * inputQuantity; 
                    productFound = true;

               
                    DateTime addTime = DateTime.Now;
                    DateTime expirationTime = addTime.AddHours(expirationHours);

               
                    SaveProductToCartFile(username, p_name, price, category, inputQuantity, total_price, cartFile, addTime, expirationTime);
                    ConsoleColors.GreenColor();
                    Console.WriteLine($"\n\n\n\t\t\t\t\t\t\t\t\t\t\tADDED {inputQuantity} QUANTITY OF PRODUCT {p_name} TO YOUR CART :) IT WILL EXPIRE AT {expirationTime} :)");
                    BannerDisplay.DisplayPlainLinegreen();
                    Console.ReadKey();

                    break;
                }
            }

            if (!productFound)
            {
                ConsoleColors.RedColor();
                Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tPRODUCT NOT FOUND :)");
                BannerDisplay.DisplayPlainLinered();
                Console.ReadKey();
            }
        }
        else
        {
            ConsoleColors.RedColor();
            Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t INVALID! Quantity :)");
            BannerDisplay.DisplayPlainLinered();
            Console.ReadKey();
        }

      
        Program.UserSession(this, username);
    }


 
    private void SaveProductToCartFile(string username, string p_name, decimal price, string category, int quantity, decimal total_price, string cartFile, DateTime addTime, DateTime expirationTime)
    {
        using (StreamWriter writer = new StreamWriter(cartFile, true))
        {
            writer.WriteLine($"{username},{p_name},{price},{category},{quantity},{total_price},{addTime},{expirationTime}");
        }
    }


    //Remove all expired cart Products
    public void RemoveExpiredCartItems(string cartFile)
    {
        string[] lines = File.ReadAllLines(cartFile);
        List<string> updatedCart = new List<string>();
        bool cartExpired = false;

        foreach (string line in lines)
        {
            var parts = line.Split(',');
            string username = parts[0];  // Username
            DateTime expirationTime = DateTime.Parse(parts[6]);  

      
            if (DateTime.Now > expirationTime)
            {
                cartExpired = true;
                Console.WriteLine($"Cart for user {username} has expired and is being removed.");
            }
            else
            {
                updatedCart.Add(line); 
            }
        }


        File.WriteAllLines(cartFile, updatedCart);

        if (cartExpired)
        {
            Console.WriteLine("Expired cart items have been removed.");
        }
    }


    public void Checkout()
    {
        Console.Clear(); 
        BannerDisplay.DisplayBanner();
        BannerDisplay.DisplayDigitalLine();
        ConsoleColors.LightRedColor();
        Console.WriteLine("\t   __________________  \t   \t  ____________________  \t   \t  ___________________________  ");
        Console.WriteLine("\t  |                  | \t > \t |                    | \t > \t |            *              | ");
        Console.WriteLine("\t  |    User Login    | \t > \t |        Menu        | \t > \t |         Check Out         | ");
        Console.WriteLine("\t  |__________________| \t > \t |____________________| \t > \t |___________________________| ");
        BannerDisplay.DisplayDigitalLine();
        ConsoleColors.LightRedColor();
        Console.WriteLine("\t\t\t\t\t\t\t   __________________________ ");
        Console.WriteLine("\t\t\t\t\t\t\t  |                          |");
        Console.WriteLine($"\t\t\t\t\t\t\t  |    WELCOME ({username})  |");
        Console.WriteLine("\t\t\t\t\t\t\t  |__________________________|");

        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayPlainLine();
        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayDigitalLine();
        ConsoleColors.LightRedColor();
        Console.WriteLine("\t\t\t\t\t\t\t   __________________________ ");
        Console.WriteLine("\t\t\t\t\t\t\t  |                          |");
        Console.WriteLine("\t\t\t\t\t\t\t  |        Check Out         |");
        Console.WriteLine("\t\t\t\t\t\t\t  |__________________________|");

        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayPlainLine();

        // Check if cart file exists
        if (!File.Exists(cartFile))
        {
            ConsoleColors.RedColor();
            Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tYOUR CART IS EMPTY ! ADD SOME ITEMS FIRST :) ");
            BannerDisplay.DisplayPlainLinered();
            Console.ReadKey();
            Program.UserSession(this, username); // Return to UserSession
            return;
        }

        // Read cart lines and filter by current user
        string[] cartLines = File.ReadAllLines(cartFile);
        List<string[]> userCartItems = new List<string[]>();

        foreach (string line in cartLines)
        {
            string[] parts = line.Split(',');
            if (parts[0] == username) // Only get products for the current user
            {
                userCartItems.Add(parts);
            }
        }

        // Check if user has items in their cart
        if (userCartItems.Count == 0)
        {
            ConsoleColors.RedColor();
            Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tYOUR CART IS EMPTY ! ADD SOME ITEMS FIRST :) ");
            BannerDisplay.DisplayPlainLinered();
            Console.ReadKey();
            Program.UserSession(this, username); // Return to UserSession
            return;
        }

        // Display table headers
        ConsoleColors.CyanColor();
        Console.WriteLine("\t   __________________  \t   \t  ____________________  \t   \t  ________________________  \t   \t  ______________________   ");
        Console.WriteLine("\t  |                  | \t > \t |                    | \t > \t |                        | \t > \t |                      |  ");
        Console.WriteLine("\t  |   PRODUCT NAME   | \t > \t |        PRICE       | \t > \t |        QUANTITY        | \t > \t |        TOTAL         |  ");
        Console.WriteLine("\t  |__________________| \t > \t |____________________| \t > \t |________________________| \t > \t |______________________|  ");

        ConsoleColors.YellowColor();

        // Display the user's cart items
        foreach (string[] item in userCartItems)
        {
            string productName = item[1];
            decimal price = decimal.Parse(item[2]);
            int quantity = int.Parse(item[4]);
            decimal total = price * quantity;

            // Display each item in a table format
            Console.WriteLine(
                $"\t  | {productName.PadRight(16)} |   > \t | {price.ToString("C").PadRight(18)} | \t > \t | {quantity.ToString().PadRight(22)} | \t > \t | {total.ToString("C").PadRight(20)} |"
            );
        }

        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayPlainLine();

        // Get the product user wants to checkout
        Console.Write("\n\n\n\t\t\t\t\t Enter Product Name You Want To CHECK-OUT\t :::::::::: \t");
        string selectedProductName = Console.ReadLine();

        // Find the product in the cart
        string[] selectedProduct = null;
        foreach (var item in userCartItems)
        {
            if (item[1].Equals(selectedProductName, StringComparison.OrdinalIgnoreCase))
            {
                selectedProduct = item;
                break;
            }
        }

        if (selectedProduct == null)
        {
            ConsoleColors.RedColor();
            Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tPRODUCT NOT FOUND ! IN YOUR CART :) ");
            BannerDisplay.DisplayPlainLinered();
            Console.ReadKey();
            Program.UserSession(this, username); // Return to UserSession
            return;
        }

        // Get product details
        string productNameToCheckout = selectedProduct[1];
        decimal priceToCheckout = decimal.Parse(selectedProduct[2]);
        int quantityToCheckout = int.Parse(selectedProduct[4]);

        // Calculate total cost
        decimal totalCost = priceToCheckout * quantityToCheckout;

        // Apply a discount if quantity is 5 or more
        if (quantityToCheckout >= 5)
        {
            decimal discount = totalCost * 0.10m; // 10% discount
            totalCost -= discount;
            ConsoleColors.YellowColor();
            Console.WriteLine($"\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tDISCOUNT APPLIED --> {discount:C} :) ");
            ConsoleColors.WhiteColor();
        }

        // Add sales tax (2.5%)
        decimal salesTax = totalCost * 0.025m;
        totalCost += salesTax;

        // Display total amount due
        ConsoleColors.YellowColor();
        Console.WriteLine($"\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tTOTAL AMOUNT DUE (WITH SALES TAX) --> {totalCost:C} :) ");
        ConsoleColors.WhiteColor();




            // Get user's phone number with validation
            string phoneNumber;
            while (true)
            {
                Console.Write("\n\n\n\t\t\t\t\t Enter Your Phone Number (11 digits only)\t\t\t :::::::::: \t");
                phoneNumber = Console.ReadLine();

                // Check if the phone number has exactly 11 digits and is numeric
                if (phoneNumber.Length == 11 && long.TryParse(phoneNumber, out _))
                {
                    break; // Valid phone number
                }
                else
                {
                ConsoleColors.RedColor();
                Console.WriteLine("\nInvalid phone number. Please enter exactly 11 digits.");
                ConsoleColors.WhiteColor();
            }
            }

            // Get user's shipping address
            Console.Write("\n\n\n\t\t\t\t\t Enter Your Shipping Address\t\t\t :::::::::: \t");
            string shippingAddress = Console.ReadLine();

            // Get user's account number with basic validation
            string accountNumber;
            while (true)
            {
                Console.Write("\n\n\n\t\t\t\t\t Enter Your Account Number For Payment (numeric only)\t :::::::::: \t");
                accountNumber = Console.ReadLine();

                // Check if the account number is numeric and has a realistic length (e.g., 10 to 16 digits)
                if (accountNumber.Length >= 10 && accountNumber.Length <= 16 && long.TryParse(accountNumber, out _))
                {
                    break; // Valid account number
                }
                else
                {
                ConsoleColors.RedColor();
                Console.WriteLine("\nInvalid account number. Please enter a numeric account number between 10 and 16 digits.");
                ConsoleColors.WhiteColor();
            }
            }
        ConsoleColors.YellowColor();
        Console.WriteLine("\nData collected successfully!");
        ConsoleColors.WhiteColor();




        // Save checkout details
        SaveCheckoutDetails(productNameToCheckout, quantityToCheckout, totalCost, phoneNumber, shippingAddress, accountNumber);
        

        // Remove product from the cart directly in the Checkout function
        string tempFile = "C:\\Users\\PMLS\\source\\repos\\ShoppingCart\\ShoppingCart";
        using (StreamWriter writer = new StreamWriter(tempFile))
        {
            foreach (string line in cartLines)
            {
                var parts = line.Split(',');

                // Write all items except the checked-out product
                if (!(parts[0].Equals(username, StringComparison.OrdinalIgnoreCase) &&
                      parts[1].Equals(productNameToCheckout, StringComparison.OrdinalIgnoreCase)))
                {
                    writer.WriteLine(line);
                }
            }
        }

        // Replace the cart file with the updated file
        File.Delete(cartFile);
        File.Move(tempFile, cartFile);

        // Display confirmation without clearing the screen
        BannerDisplay.DisplayPlainLine();
        ConsoleColors.GreenColor();
        Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tTHANK YOU ! FOR YOUR PURCHASE :) ");
        BannerDisplay.DisplayPlainLinegreen();
        ConsoleColors.WhiteColor();
        Console.ReadKey();

        // Return to UserSession after checkout
        Program.UserSession(this, username);
    }




    // Function to save checkout details
    private void SaveCheckoutDetails(string productName, int quantity, decimal totalCost, string phoneNumber, string shippingAddress, string accountNumber)
    {
        UpdateProductQuantity(productName, quantity);
        string checkoutFile = "C:\\Users\\PMLS\\source\\repos\\ShoppingCart\\ShoppingCart\\checkout.txt";
        //string checkoutFile = "checkout.txt"; // Path to save checkout info
        string data = $"{username}-{productName}-{quantity}-{totalCost:C}-{phoneNumber}-{shippingAddress}-{accountNumber}-{DateTime.Now}";
        File.AppendAllText(checkoutFile, data + Environment.NewLine); // Append the checkout data to a file
    }



    // Function to update product quantity after checkout

private void UpdateProductQuantity(string productName, int quantityToDeduct)
{
    string productFile = "C:\\Users\\PMLS\\source\\repos\\ShoppingCart\\ShoppingCart\\product.txt"; // Original file path
    string tempFile = "C:\\Users\\PMLS\\source\\repos\\ShoppingCart\\ShoppingCart\\temp1.txt"; // Temporary file path
    string[] productLines;

    try
    {
        productLines = File.ReadAllLines(productFile); // Read the original file
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine($"File not found: {ex.Message}");
        return;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error reading file: {ex.Message}");
        return;
    }

    List<string> updatedProductLines = new List<string>();
    bool productFound = false; 

    foreach (string line in productLines)
    {
        string[] parts = line.Split('-');

  
        if (parts.Length >= 4 && parts[0].Equals(productName, StringComparison.OrdinalIgnoreCase))
        {
            if (int.TryParse(parts[3], out int currentQuantity))
            {
                int newQuantity = currentQuantity - quantityToDeduct;

             
                if (newQuantity < 0)
                {
                    Console.WriteLine($"Error: Quantity for {productName} cannot be negative.");
                    return;
                }

                updatedProductLines.Add($"{parts[0]}-{parts[1]}-{parts[2]}-{newQuantity}");
                productFound = true; 
            }
            else
            {
                Console.WriteLine("Error parsing the current quantity.");
                return;
            }
        }
        else
        {
            updatedProductLines.Add(line); 
        }
    }

    if (!productFound)
    {
        Console.WriteLine($"Error: Product '{productName}' not found.");
        return;
    }

    try
    {
        // Write to a temporary file first
        File.WriteAllLines(tempFile, updatedProductLines);

       
        File.Delete(productFile); // Delete the original file
        File.Move(tempFile, productFile); 

        Console.WriteLine("Product quantity updated successfully.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error writing to file: {ex.Message}");
    }
}


public void CheckoutHistory()
    {
        Console.Clear();
        BannerDisplay.DisplayBanner();
        BannerDisplay.DisplayDigitalLine();
        ConsoleColors.LightRedColor();
        Console.WriteLine("\t   __________________  \t   \t  ____________________  \t   \t  ___________________________  ");
        Console.WriteLine("\t  |                  | \t > \t |                    | \t > \t |            *              | ");
        Console.WriteLine("\t  |    User Login    | \t > \t |        Menu        | \t > \t |     Check-Out History     | ");
        Console.WriteLine("\t  |__________________| \t > \t |____________________| \t > \t |___________________________| ");

        BannerDisplay.DisplayDigitalLine();
        ConsoleColors.LightRedColor();
        Console.WriteLine("\t\t\t\t\t\t   __________________________ ");
        Console.WriteLine("\t\t\t\t\t\t  |                          |");
        Console.WriteLine($"\t\t\t\t\t\t  |    WELCOME ({username})  |");
        Console.WriteLine("\t\t\t\t\t\t  |__________________________|");

        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayPlainLine();
        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayDigitalLine();
        ConsoleColors.LightRedColor();
        Console.WriteLine("\t\t\t\t\t\t   __________________________ ");
        Console.WriteLine("\t\t\t\t\t\t  |                          |");
        Console.WriteLine("\t\t\t\t\t\t  |    Check-Out History     |");
        Console.WriteLine("\t\t\t\t\t\t  |__________________________|");

        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayPlainLine();
        string checkoutFile = "C:\\Users\\PMLS\\source\\repos\\ShoppingCart\\ShoppingCart\\checkout.txt"; // Path to the checkout file

        // Check if the file exists
        if (File.Exists(checkoutFile))
        {

            string[] lines = File.ReadAllLines(checkoutFile);


            List<string> userHistory = new List<string>();


            foreach (var line in lines)
            {
               
                if (line.Contains(username))
                {
                    userHistory.Add(line);
                }
            }

            // Display the user's checkout history
            if (userHistory.Count > 0)
            {

                ConsoleColors.CyanColor();
                Console.WriteLine("  __________________     _________________    _____________    _____________    _______________    __________________    ________________    _______________ ");
                Console.WriteLine(" |     USERNAME     |   |   PRODUCT NAME  |  |  QUANTITY   |  | TOTAL PRICE |  | PHONE NUMBER  |  | SHIPPING ADDRESS |  | ACCOUNT NUMBER |  |  DATE & TIME  |");
                Console.WriteLine(" |__________________|   |_________________|  |_____________|  |_____________|  |_______________|  |__________________|  |________________|  |_______________|");
                BannerDisplay.DisplayPlainLine();

                ConsoleColors.YellowColor();

                // Define column widths
                int usernameWidth = 15;
                int productNameWidth = 18;
                int quantityWidth = 13;
                int totalPriceWidth = 13;
                int phoneNumberWidth = 16;
                int shippingAddressWidth = 20;
                int accountNumberWidth = 16;
                int dateTimeWidth = 19;

       
                foreach (var record in userHistory)
                {
                    var parts = record.Split('-'); 

                    if (parts.Length >= 8)  
                    {
                
                        string dateTime = parts[0]; 
                        string recordUsername = parts[1];
                        string productName = parts[2];
                        string quantity = parts[3];
                        string totalPrice = parts[4];
                        string phoneNumber = parts[5];
                        string shippingAddress = parts[6];
                        string accountNumber = parts[7];

                        Console.WriteLine(
                            $"| {dateTime.PadRight(dateTimeWidth)}" +
                            $" | {recordUsername.PadRight(usernameWidth)}" +
                            $" | {productName.PadRight(productNameWidth)}" +
                            $" | {quantity.PadRight(quantityWidth)}" +
                            $" | {totalPrice.PadRight(totalPriceWidth)}" +
                            $" | {phoneNumber.PadRight(phoneNumberWidth)}" +
                            $" | {shippingAddress.PadRight(shippingAddressWidth)}" +
                            $" | {accountNumber.PadRight(accountNumberWidth)} |"
                        );

                        Console.WriteLine(
                            $"|{new string('_', dateTimeWidth + 2)}" +
                            $"|{new string('_', usernameWidth + 2)}" +
                            $"|{new string('_', productNameWidth + 2)}" +
                            $"|{new string('_', quantityWidth + 2)}" +
                            $"|{new string('_', totalPriceWidth + 2)}" +
                            $"|{new string('_', phoneNumberWidth + 2)}" +
                            $"|{new string('_', shippingAddressWidth + 2)}" +
                            $"|{new string('_', accountNumberWidth + 2)}|"
                        );
                    }
                    else
                    {
                        ConsoleColors.RedColor();
                        Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tERROR ! INVALID CHECK-OUT DATA :)");
                        ConsoleColors.WhiteColor();
                    }
                }
            }
            else
            {
                ConsoleColors.RedColor();
                Console.WriteLine($"\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\tNO CHECK-OUT HISTORY FOUND FOR {username} :) ");
                BannerDisplay.DisplayPlainLinered();
                Console.ReadKey();
            }
        }
        else
        {
            ConsoleColors.RedColor();
            Console.WriteLine($"\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\tCHECK-OUT FILE DOES NOT EXIST :) ");
            BannerDisplay.DisplayPlainLinered();
            Console.ReadKey();
        }

    
        ConsoleColors.WhiteColor();
        Console.WriteLine("\n\nPress any key to return to the main menu...");
        Console.ReadKey();

      
        Program.UserSession(this, username);
    }




    public void ViewCart()
    {
        Console.Clear();
        BannerDisplay.DisplayBanner();
        BannerDisplay.DisplayDigitalLine();
        ConsoleColors.LightRedColor();
        Console.WriteLine("\t   __________________  \t   \t  ____________________  \t   \t  ___________________________  ");
        Console.WriteLine("\t  |                  | \t > \t |                    | \t > \t |            *              | ");
        Console.WriteLine("\t  |    User Login    | \t > \t |        Menu        | \t > \t |        View Cart          | ");
        Console.WriteLine("\t  |__________________| \t > \t |____________________| \t > \t |___________________________| ");

        BannerDisplay.DisplayDigitalLine();
        ConsoleColors.LightRedColor();
        Console.WriteLine("\t\t\t\t\t\t\t   __________________________ ");
        Console.WriteLine("\t\t\t\t\t\t\t  |                          |");
        Console.WriteLine($"\t\t\t\t\t\t\t  |    WELCOME ({username})  |");
        Console.WriteLine("\t\t\t\t\t\t\t  |__________________________|");

        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayPlainLine();
        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayDigitalLine();
        ConsoleColors.LightRedColor();
        Console.WriteLine("\t\t\t\t\t\t\t   __________________________ ");
        Console.WriteLine("\t\t\t\t\t\t\t  |                          |");
        Console.WriteLine("\t\t\t\t\t\t\t  |        View Cart         |");
        Console.WriteLine("\t\t\t\t\t\t\t  |__________________________|");

        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayPlainLine();

        if (!File.Exists(cartFile))
        {
            ConsoleColors.RedColor();
            Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tYOUR CART IS EMPTY :) ");
            BannerDisplay.DisplayPlainLinered();
            Console.ReadKey();
            return;
        }

        string[] lines = File.ReadAllLines(cartFile);
        bool hasItems = false;

        ConsoleColors.CyanColor();
        Console.WriteLine("\t   __________________  \t   \t  ____________________  \t   \t  ________________________  \t   \t  ______________________   ");
        Console.WriteLine("\t  |                  | \t > \t |                    | \t > \t |                        | \t > \t |                      |  ");
        Console.WriteLine("\t  |   PRODUCT NAME   | \t > \t |        PRICE       | \t > \t |        CATEGORY        | \t > \t |       QUANTITY       |  ");
        Console.WriteLine("\t  |__________________| \t > \t |____________________| \t > \t |________________________| \t > \t |______________________|  ");
        BannerDisplay.DisplayPlainLine();

        ConsoleColors.YellowColor();

        foreach (string line in lines)
        {
            var parts = line.Split(',');
            if (parts[0] == username) 
            {
                hasItems = true;

                try
                {
                  
                    string p_name = parts[1];                    // Product Name
                    decimal price = decimal.Parse(parts[2]);     // Product Price
                    string category = parts[3];                  // Product Category
                    int quantity = int.Parse(parts[4]);          // Product Quantity

                    // Adjust the length of each string for proper alignment in the table
                    Console.WriteLine(
                        $"\t  | {p_name.PadRight(16)} |   > \t | {price.ToString("C").PadRight(18)} | \t > \t | {category.PadRight(22)} | \t > \t | {quantity.ToString().PadRight(20)} |"
                    );
                }
                catch (Exception ex)
                {
                    // If there is any parsing error, display an error message for that product line
                    ConsoleColors.RedColor();
                    Console.WriteLine($"Error processing cart item: {line} - {ex.Message}");
                    ConsoleColors.WhiteColor();
                }
            }
        }

        if (!hasItems)
        {
            ConsoleColors.RedColor();
            Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tYOUR CART IS EMPTY :) ");
            BannerDisplay.DisplayPlainLinered();
            Console.ReadKey();
        }

        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayPlainLine();

        // Prompt the user to press any key to return to the main menu (UserSession)
        Console.WriteLine("\n\nPress any key to return to the main menu...");
        Console.ReadKey();

        // After pressing a key, return to UserSession
        Program.UserSession(this, username);
    }

    public void ShowRecommendedProducts()
    {
        Console.Clear();
        BannerDisplay.DisplayBanner();
        BannerDisplay.DisplayDigitalLine();
        ConsoleColors.LightRedColor();
        Console.WriteLine("\t   __________________  \t   \t  ____________________  \t   \t  ___________________________  ");
        Console.WriteLine("\t  |                  | \t > \t |                    | \t > \t |             *             | ");
        Console.WriteLine("\t  |    User Login    | \t > \t |        Menu        | \t > \t |    Recommended Products   | ");
        Console.WriteLine("\t  |__________________| \t > \t |____________________| \t > \t |___________________________| ");
        BannerDisplay.DisplayDigitalLine();
        ConsoleColors.LightRedColor();
        Console.WriteLine("\t\t\t\t\t\t\t   __________________________ ");
        Console.WriteLine("\t\t\t\t\t\t\t  |                          |");
        Console.WriteLine($"\t\t\t\t\t\t\t  |    WELCOME ({username})  |");
        Console.WriteLine("\t\t\t\t\t\t\t  |__________________________|");
        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayPlainLine();
        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayDigitalLine();
        ConsoleColors.LightRedColor();
        Console.WriteLine("\t\t\t\t\t\t\t   ____________________________ ");
        Console.WriteLine("\t\t\t\t\t\t\t  |                            |");
        Console.WriteLine("\t\t\t\t\t\t\t  |    Recommended Products    |");
        Console.WriteLine("\t\t\t\t\t\t\t  |____________________________|");
        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayPlainLine();

        if (!File.Exists(cartFile) || new FileInfo(cartFile).Length == 0)
        {
            ConsoleColors.RedColor();
            Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tNO RECOMMENDATION AVAILABLE! YOUR CART IS EMPTY :) ");
            BannerDisplay.DisplayPlainLinered();
            Console.ReadKey();
            Program.UserSession(this, username);
            return;
        }

        string productFile = Path.Combine(basePath, "product.txt");
        if (!File.Exists(productFile) || new FileInfo(productFile).Length == 0)
        {
            ConsoleColors.RedColor();
            Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tNO PRODUCT AVAILABLE! FOR RECOMMENDATION :) ");
            BannerDisplay.DisplayPlainLinered();
            Console.ReadKey();
            Program.UserSession(this, username);
            return;
        }

        // Get the categories of products the user already has in their cart
        string[] cartLines = File.ReadAllLines(cartFile);
        var cartCategories = new HashSet<string>();
        var cartProducts = new HashSet<string>();

        foreach (string line in cartLines)
        {
            var parts = line.Split(',');
            if (parts[0] == username)
            {
                string p_name = parts[1];      // Product name in cart
                string category = parts[3];    // Category of the product in the cart
                cartCategories.Add(category);  // Collect categories
                cartProducts.Add(p_name);      // Collect product names to avoid recommending the same
            }
        }

        if (cartCategories.Count == 0)
        {
            ConsoleColors.RedColor();
            Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tNO RECOMMENDATION AVAILABLE! YOUR CART IS EMPTY :) ");
            BannerDisplay.DisplayPlainLinered();
            Console.ReadKey();
            Program.UserSession(this, username);
            return;
        }

        // Display header for recommended products



        // Display table headers with similar alignment
        ConsoleColors.CyanColor();
        Console.WriteLine("\t   __________________  \t   \t  ____________________  \t   \t  ________________________  \t   \t  ______________________   ");
        Console.WriteLine("\t  |                  | \t > \t |                    | \t > \t |                        | \t > \t |                      |  ");
        Console.WriteLine("\t  |   PRODUCT NAME   | \t > \t |        PRICE       | \t > \t |        CATEGORY        | \t > \t |       QUANTITY       |  ");
        Console.WriteLine("\t  |__________________| \t > \t |____________________| \t > \t |________________________| \t > \t |______________________|  ");
        BannerDisplay.DisplayPlainLine();

        ConsoleColors.YellowColor();
        bool hasRecommendations = false;
        string[] productLines = File.ReadAllLines(productFile);

        foreach (string line in productLines)
        {
            var parts = line.Split('-');
            string p_name = parts[0];        // Product Name
            decimal price = decimal.Parse(parts[1]);  // Product Price
            string category = parts[2];      // Product Category
            int quantity = int.Parse(parts[3]);       // Product Quantity

            // Recommend products that match the category but are not in the cart
            if (cartCategories.Contains(category) && !cartProducts.Contains(p_name))
            {
                hasRecommendations = true;
                Console.WriteLine(
                    $"\t  | {p_name.PadRight(16)} |   > \t | {price.ToString("C").PadRight(18)} | \t > \t | {category.PadRight(22)} | \t > \t | {quantity.ToString().PadRight(20)} |"
                );
            }
        }

        if (!hasRecommendations)
        {
            ConsoleColors.RedColor();
            Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tNO RECOMMENDATION FOUND! BASED ON YOUR CART :) ");
            BannerDisplay.DisplayPlainLinered();
            Program.UserSession(this, username);
            Console.ReadKey();
        }

        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayPlainLine();

        // Prompt the user to press any key to return to the main menu (UserSession)
        Console.WriteLine("\n\nPress any key to return to the main menu...");
        Console.ReadKey();

        // Return to UserSession after displaying recommendations
        Program.UserSession(this, username);
    }



    // Updated method to save product details to the cart file
    private void SaveProductToCartFile(string username, string p_name, decimal price, string category, int quantity, decimal total_price, string cartFile)
    {
        using (StreamWriter writer = new StreamWriter(cartFile, true))
        {
            writer.WriteLine($"{username}-{p_name}-{price}-{category}-{quantity}-{total_price}");
        }
    }

    public void RemoveProductFromCart(string username)
    {
        Console.Clear();
        BannerDisplay.DisplayBanner();
        BannerDisplay.DisplayDigitalLine();
        ConsoleColors.LightRedColor();
        Console.WriteLine("\t   __________________  \t   \t  ____________________  \t   \t  ___________________________  ");
        Console.WriteLine("\t  |                  | \t > \t |                    | \t > \t |  Delete Product From Cart | ");
        Console.WriteLine("\t  |    User Login    | \t > \t |        Menu        | \t > \t |           *              | ");
        Console.WriteLine("\t  |__________________| \t > \t |____________________| \t > \t |___________________________| ");
        BannerDisplay.DisplayDigitalLine();
        ConsoleColors.LightRedColor();
        Console.WriteLine("\t\t\t\t\t\t\t   __________________________ ");
        Console.WriteLine("\t\t\t\t\t\t\t  |                          |");
        Console.WriteLine($"\t\t\t\t\t\t\t  |    WELCOME ({username})  |");
        Console.WriteLine("\t\t\t\t\t\t\t  |__________________________|");
        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayPlainLine();
        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayDigitalLine();
        ConsoleColors.LightRedColor();
        Console.WriteLine("\t\t\t\t\t\t\t   ____________________________ ");
        Console.WriteLine("\t\t\t\t\t\t\t  |                            |");
        Console.WriteLine("\t\t\t\t\t\t\t  |  Delete Product From Cart  |");
        Console.WriteLine("\t\t\t\t\t\t\t  |____________________________|");
        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayPlainLine();

        // Check if the cart file exists and has content
        if (!File.Exists(cartFile) || new FileInfo(cartFile).Length == 0)
        {
            ConsoleColors.RedColor();
            Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t YOUR CART IS EMPTY :)");
            BannerDisplay.DisplayPlainLinered();
            Console.ReadKey();
            Program.UserSession(this, username);
            return;
        }

        string[] cartLines = File.ReadAllLines(cartFile);
        bool hasItems = false;

        // Display cart items in a table format
        ConsoleColors.CyanColor();
        Console.WriteLine("\t   __________________  \t   \t  ____________________  \t   \t  ________________________  \t   \t  ______________________   ");
        Console.WriteLine("\t  |                  | \t > \t |                    | \t > \t |                        | \t > \t |                      |  ");
        Console.WriteLine("\t  |   PRODUCT NAME   | \t > \t |        PRICE       | \t > \t |        CATEGORY        | \t > \t |       QUANTITY       |  ");
        Console.WriteLine("\t  |__________________| \t > \t |____________________| \t > \t |________________________| \t > \t |______________________|  ");
        BannerDisplay.DisplayPlainLine();

        ConsoleColors.YellowColor();
        foreach (string line in cartLines)
        {
            var parts = line.Split(',');

            // Display items only for the current user
            if (parts[0].Equals(username, StringComparison.OrdinalIgnoreCase))
            {
                hasItems = true;

                // Display each product in a structured row
                string p_name = parts[1];
                decimal price = decimal.Parse(parts[2]);
                string category = parts[3];
                int quantity = int.Parse(parts[4]);

                Console.WriteLine(
                    $"\t  | {p_name.PadRight(16)} |   > \t | {price.ToString("C").PadRight(18)} | \t > \t | {category.PadRight(22)} | \t > \t | {quantity.ToString().PadRight(20)} |"
                );
            }
        }

        if (!hasItems)
        {
            ConsoleColors.RedColor();
            Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t YOUR CART IS EMPTY :)");
            BannerDisplay.DisplayPlainLinered();
            Console.ReadKey();
            Program.UserSession(this, username);
            return;
        }

        ConsoleColors.WhiteColor();
        BannerDisplay.DisplayPlainLine();

        // Prompt the user to enter the product name to delete
        Console.Write("\n\n\n\t\t\t\t\t Enter Product Name To DELETE\t :::::::::: \t");
        string productName = Console.ReadLine();

        string tempFile = "temp_cart.txt";
        bool productFound = false;

        // Rewrite the cart file excluding the deleted product
        using (StreamWriter writer = new StreamWriter(tempFile))
        {
            foreach (string line in cartLines)
            {
                var parts = line.Split(',');

                // If line does not match, write it to temp file
                if (!(parts[0].Equals(username, StringComparison.OrdinalIgnoreCase) &&
                      parts[1].Equals(productName, StringComparison.OrdinalIgnoreCase)))
                {
                    writer.WriteLine(line);
                }
                else
                {
                    productFound = true;
                }
            }
        }

        if (productFound)
        {
            File.Delete(cartFile);        // Delete the original cart file
            File.Move(tempFile, cartFile); // Rename the temp file to original cart file
            ConsoleColors.GreenColor();
            Console.WriteLine($"\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t {productName} REMOVED FROM YOUR CART :)");
            BannerDisplay.DisplayPlainLinegreen();
        }
        else
        {
            File.Delete(tempFile); // Delete the temp file if product was not found
            ConsoleColors.RedColor();
            Console.WriteLine($"\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t {productName} IS NOT IN YOUR CART :)");
            BannerDisplay.DisplayPlainLinered();
        }

        Console.ReadKey();
        Program.UserSession(this, username); // Return to UserSession
    }



    class Program
    {
        static string basePath = "C:\\Users\\PMLS\\source\\repos\\ShoppingCart\\ShoppingCart";  // Base path for all files

        static void Main()
        {
            Console.ReadKey();
            BannerDisplay.FinalStartBanner();
            log_reg();
        }

        static void log_reg()
        {
            // Ensure product.txt exists (it will be blank initially if not found)
            string productFile = Path.Combine(basePath, "product.txt");
            if (!File.Exists(productFile))
            {
                using (File.Create(productFile)) { }
            }

            bool exit = false;

            while (!exit)
            {
                Console.Clear();

                BannerDisplay.DisplayBanner();
                BannerDisplay.DisplayDigitalLine();
                ConsoleColors.LightRedColor();
                Console.WriteLine("\t\t\t\t\t\t\t   _________________________ ");
                Console.WriteLine("\t\t\t\t\t\t\t  |                         |");
                Console.WriteLine("\t\t\t\t\t\t\t  | WELCOME TO QUICK CART   |");
                Console.WriteLine("\t\t\t\t\t\t\t  |_________________________|");

                ConsoleColors.WhiteColor();

                BannerDisplay.DisplayPlainLine();
                ConsoleColors.PurpleColor();

                Console.WriteLine("\t\t  _____________________     \t \t  _____________________ \t \t  _____________________   ");
                Console.WriteLine("\t\t |          1          |    \t>\t |          2          |\t>\t |          3          |  ");
                Console.WriteLine("\t\t |       Register      |    \t>\t |        Login        |\t>\t |        EXIT         |  ");
                Console.WriteLine("\t\t |_____________________|    \t>\t |_____________________|\t>\t |_____________________|  ");

                ConsoleColors.WhiteColor();

                Console.Write("\n\n\n\t\t\t\t\t Enter Your Choice\t :::::::::: \t");

                string mainChoice = Console.ReadLine();

                switch (mainChoice)
                {
                    case "1":
                        RegisterUser();
                        break;
                    case "2":
                        if (LoginUser(out string username))
                        {
                            ShoppingCart cart = new ShoppingCart(username);
                            UserSession(cart, username);
                        }
                        break;
                    case "3":
                        ConsoleColors.RedColor();
                        Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t EXITING.......... :)");
                        BannerDisplay.DisplayPlainLinered();
                        ConsoleColors.WhiteColor();
                        Console.ReadKey();
                        Console.Clear();

                        Environment.Exit(0);  // Terminate the program completely

                        break;
                    default:
                        ConsoleColors.RedColor();
                        Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t INVALID ! CHOICE :)");
                        BannerDisplay.DisplayPlainLinered();
                        ConsoleColors.WhiteColor();
                        Console.ReadKey();

                        break;
                }
            }
        }

        public static void UserSession(ShoppingCart cart, string username)
        {
            Console.Clear();
            bool sessionActive = true;
            BannerDisplay.DisplayBanner();
            BannerDisplay.DisplayDigitalLine();
            ConsoleColors.LightRedColor();
            Console.WriteLine("\t   __________________  \t   \t  ____________________ ");
            Console.WriteLine("\t  |                  | \t > \t |         *          |");
            Console.WriteLine("\t  |    User Login    | \t > \t |        Menu        |");
            Console.WriteLine("\t  |__________________| \t > \t |____________________|");

            // Reset the text color to white
            ConsoleColors.WhiteColor();
            BannerDisplay.DisplayDigitalLine();
            ConsoleColors.LightRedColor();
            Console.WriteLine("\t\t\t\t\t\t\t   __________________________ ");
            Console.WriteLine("\t\t\t\t\t\t\t  |                          |");
            Console.WriteLine($"\t\t\t\t\t\t\t  |    WELCOME ({username})  |");
            Console.WriteLine("\t\t\t\t\t\t\t  |__________________________|");

            ConsoleColors.WhiteColor();

            while (sessionActive)
            {
                BannerDisplay.DisplayPlainLine();
                ConsoleColors.PurpleColor();
                Console.WriteLine(String.Format("{0,-35}     {1,-35}     {2,-35}     {3,-20}", "        _________________________ ", "   ___________________________ ", "   _____________________ ", "   __________________________ "));
                Console.WriteLine(String.Format("{0,-35}  >  {1,-35}  >  {2,-35}  >  {3,-20}", "       |           1             |", "  |            2              |", "  |          3          |", "  |           4              |"));
                Console.WriteLine(String.Format("{0,-35}  >  {1,-35}  >  {2,-35}  >  {3,-20}", "       | View Available Products |", "  | View Recommended Products |", "  | Add Product To Cart |", "  | Delete Product From Cart |"));
                Console.WriteLine(String.Format("{0,-35}  >  {1,-35}  >  {2,-35}  >  {3,-20}", "       |_________________________|", "  |___________________________|", "  |_____________________|", "  |__________________________|"));
                Console.WriteLine(String.Format("{0,-35}  >  {1,-35}  >  {2,-35}  >  {3,-20}", "        _________________________ ", "   ___________________________ ", "   _____________________ ", "   __________________________ "));
                Console.WriteLine(String.Format("{0,-35}  >  {1,-35}  >  {2,-35}  >  {3,-20}", "       |           5             |", "  |            6              |", "  |          7          |", "  |            8             |"));
                Console.WriteLine(String.Format("{0,-35}  >  {1,-35}  >  {2,-35}  >  {3,-20}", "       |        View Cart        |", "  |         Check-Out         |", "  |  Check-Out History  |", "  |         Log-Out          |"));
                Console.WriteLine(String.Format("{0,-35}  >  {1,-35}  >  {2,-35}  >  {3,-20}", "       |_________________________|", "  |___________________________|", "  |_____________________|", "  |__________________________|"));

                ConsoleColors.WhiteColor();
                Console.Write("\n\n\n\t\t\t\t\t Enter Your Choice\t\t :::::::::: \t");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowAvailableProducts(cart, username);
                        break;
                    case "2":
                        cart.ShowRecommendedProducts();
                        break;
                    case "3":
                        cart.AddProductToCart();
                        break;
                    case "4":
                        cart.RemoveProductFromCart(username);
                        break;
                    case "5":
                        cart.ViewCart();
                        break;
                    case "6":
                        cart.Checkout();
                        break;
                    case "7":
                        cart.CheckoutHistory();
                        break;
                    case "8":
                        ConsoleColors.RedColor();
                        Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t LOGGING OUT... THANK YOU FOR USING OUR SERVICE :)");
                        BannerDisplay.DisplayPlainLinered();
                        ConsoleColors.WhiteColor();
                        Console.ReadKey();
                        Console.Clear();
                        sessionActive = false; // Terminate the session loop
                        log_reg();
                        break;
                    default:
                        ConsoleColors.RedColor();
                        Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t INVALID CHOICE! PLEASE TRY AGAIN :)");
                        BannerDisplay.DisplayPlainLinered();
                        break;
                }
            }
        }


        static void ShowAvailableProducts(ShoppingCart cart, string username)
        {
            Console.Clear();
            BannerDisplay.DisplayBanner();
            BannerDisplay.DisplayDigitalLine();
            ConsoleColors.LightRedColor();
            Console.WriteLine("\t   __________________  \t   \t  ____________________  \t   \t  ___________________________  ");
            Console.WriteLine("\t  |                  | \t > \t |                    | \t > \t |            *              | ");
            Console.WriteLine("\t  |    User Login    | \t > \t |        Menu        | \t > \t |  View Available Products  | ");
            Console.WriteLine("\t  |__________________| \t > \t |____________________| \t > \t |___________________________| ");

            BannerDisplay.DisplayDigitalLine();
            ConsoleColors.LightRedColor();
            Console.WriteLine("\t\t\t\t\t\t\t   __________________________ ");
            Console.WriteLine("\t\t\t\t\t\t\t  |                          |");
            Console.WriteLine($"\t\t\t\t\t\t\t  |    WELCOME ({username})  |");
            Console.WriteLine("\t\t\t\t\t\t\t  |__________________________|");

            ConsoleColors.WhiteColor();
            BannerDisplay.DisplayPlainLine();
            ConsoleColors.WhiteColor();
            BannerDisplay.DisplayDigitalLine();
            ConsoleColors.LightRedColor();
            Console.WriteLine("\t\t\t\t\t\t\t   __________________________ ");
            Console.WriteLine("\t\t\t\t\t\t\t  |                          |");
            Console.WriteLine("\t\t\t\t\t\t\t  |    Available Products    |");
            Console.WriteLine("\t\t\t\t\t\t\t  |__________________________|");

            ConsoleColors.WhiteColor();
            BannerDisplay.DisplayPlainLine();

            string productFile = Path.Combine(basePath, "product.txt");

            if (!File.Exists(productFile) || new FileInfo(productFile).Length == 0)
            {
                ConsoleColors.RedColor();
                Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t NO! PRODUCT AVAILABLE :)");
                BannerDisplay.DisplayPlainLinered();
                Console.ReadKey();
                // Return to UserSession after viewing the message
                Program.UserSession(cart, username);
                return;
            }

            string[] lines = File.ReadAllLines(productFile);

            // Display table headers with better alignment for ">" symbols
            ConsoleColors.CyanColor();
            Console.WriteLine("\t   __________________  \t   \t  ____________________  \t   \t  ________________________  \t   \t  ______________________   ");
            Console.WriteLine("\t  |                  | \t > \t |                    | \t > \t |                        | \t > \t |                      |  ");
            Console.WriteLine("\t  |   PRODUCT NAME   | \t > \t |        PRICE       | \t > \t |        CATEGORY        | \t > \t |       QUANTITY       |  ");
            Console.WriteLine("\t  |__________________| \t > \t |____________________| \t > \t |________________________| \t > \t |______________________|  ");
            BannerDisplay.DisplayPlainLine();

            ConsoleColors.YellowColor();

            foreach (string line in lines)
            {
                var parts = line.Split('-');  // Expecting parts to be separated by '-'

                // Check if the line has the expected number of parts (4 in this case)
                if (parts.Length < 4)
                {
                    ConsoleColors.RedColor();
                    Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t ERROR ! PRODUCT DATA IS MISSING :)");
                    ConsoleColors.WhiteColor();
                    continue; // Skip this line and continue with the next one
                }

                try
                {
                    // Storing product details into variables
                    string p_name = parts[0];                    // Product Name
                    decimal price = decimal.Parse(parts[1]);     // Product Price
                    string category = parts[2];                  // Product Category
                    int quantity = int.Parse(parts[3]);          // Product Quantity

                    // Adjust the length of each string for proper alignment in the table
                    Console.WriteLine(
                        $"\t  | {p_name.PadRight(16)} |   > \t | {price.ToString("C").PadRight(18)} | \t > \t | {category.PadRight(22)} | \t > \t | {quantity.ToString().PadRight(20)} |"
                    );
                }
                catch (Exception ex)
                {
                    // If there is any parsing error, display an error message for that product line
                    ConsoleColors.RedColor();
                    Console.WriteLine($"Error processing product: {line} - {ex.Message}");
                    ConsoleColors.WhiteColor();
                }
            }

            ConsoleColors.WhiteColor();
            BannerDisplay.DisplayPlainLine();

            // Prompt the user to press any key to return to the main menu (UserSession)
            Console.WriteLine("\n\nPress any key to return to the main menu...");
            Console.ReadKey();

            // After pressing a key, return to UserSession
            Program.UserSession(cart, username);
        }



        static void RegisterUser()
        {
            Console.Clear();
            BannerDisplay.DisplayBanner();
            BannerDisplay.DisplayDigitalLine();
            ConsoleColors.LightRedColor();
            Console.WriteLine("\t\t\t\t\t\t\t   _________________________ ");
            Console.WriteLine("\t\t\t\t\t\t\t  |                         |");
            Console.WriteLine("\t\t\t\t\t\t\t  |      Register User      |"); // Changed to "Quick Cart" as per your previous requirement
            Console.WriteLine("\t\t\t\t\t\t\t  |_________________________|");

            // Reset text color to white
            ConsoleColors.WhiteColor();

            // Display a plain line for separation
            BannerDisplay.DisplayPlainLine();
            Console.Write("\n\n\n\t\t\t\t\t Enter User Name\t :::::::::: \t");
            string username = Console.ReadLine();
            Console.Write("\n\n\n\t\t\t\t\t Enter Password\t\t :::::::::: \t");
            string password = Console.ReadLine();

            if (IsUsernameTaken(username))
            {
                ConsoleColors.RedColor();
                Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tUSERNAME ALREADY TAKEN! PLEASE CHOOSE ANOTHER :) ");
                BannerDisplay.DisplayPlainLinered();
                Console.ReadKey();
                log_reg();
                return;
            }

            string userFile = Path.Combine(basePath, "users.txt");
            using (StreamWriter writer = new StreamWriter(userFile, true))
            {
                writer.WriteLine($"{username},{password}");
            }
            ConsoleColors.GreenColor();
            Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tUser Registered Successfully :) ");
            BannerDisplay.DisplayPlainLinegreen();
            Console.ReadKey();
        }

        static bool IsUsernameTaken(string username)
        {
            string userFile = Path.Combine(basePath, "users.txt");

            if (File.Exists(userFile))
            {
                string[] lines = File.ReadAllLines(userFile);
                foreach (string line in lines)
                {
                    var parts = line.Split(',');
                    if (parts[0].Equals(username, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static bool LoginUser(out string username)
        {
            Console.Clear();
            BannerDisplay.DisplayBanner();
            BannerDisplay.DisplayDigitalLine();
            ConsoleColors.LightRedColor();
            Console.WriteLine("\t\t\t\t\t\t\t   _________________________ ");
            Console.WriteLine("\t\t\t\t\t\t\t  |                         |");
            Console.WriteLine("\t\t\t\t\t\t\t  |        Login User       |"); // Changed to "Quick Cart" as per your previous requirement
            Console.WriteLine("\t\t\t\t\t\t\t  |_________________________|");

            // Reset text color to white
            ConsoleColors.WhiteColor();

            // Display a plain line for separation
            BannerDisplay.DisplayPlainLine();

            Console.Write("\n\n\n\t\t\t\t\t Enter User Name\t :::::::::: \t");
            username = Console.ReadLine();
            Console.Write("\n\n\n\t\t\t\t\t Enter Password\t\t :::::::::: \t");
            string password = Console.ReadLine();

            string userFile = Path.Combine(basePath, "users.txt");

            if (!File.Exists(userFile))
            {
                ConsoleColors.RedColor();
                Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tNO REGISTERED USER! PLEASE REGISTER FIRST :) ");
                BannerDisplay.DisplayPlainLinered();
                username = null;
                Console.ReadKey();
                return false;
            }

            string[] lines = File.ReadAllLines(userFile);
            foreach (string line in lines)
            {
                var parts = line.Split(',');
                if (parts[0].Equals(username, StringComparison.OrdinalIgnoreCase) && parts[1] == password)
                {
                    ConsoleColors.GreenColor();
                    Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tLOGIN SUCCESSFULL :)");
                    BannerDisplay.DisplayPlainLinegreen();
                    Console.ReadKey();
                    return true;

                }
            }
            ConsoleColors.RedColor();
            Console.WriteLine("\n\n\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t INVALID ! USERNAME OR PASSWORD :)");
            BannerDisplay.DisplayPlainLinered();
            username = null;
            Console.ReadKey();
            return false;
        }

    }
}
