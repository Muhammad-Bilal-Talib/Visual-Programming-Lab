using System;
using System.IO;
using System.Collections.Generic;

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
    private string basePath = "C:\\Users\\PMLS\\source\\repos\\testnew\\testnew";  // Base path for all files
    private string cartFile;

    public ShoppingCart(string username)
    {
        this.username = username;
        cartFile = Path.Combine(basePath, "cart.txt");  // Single cart file for all users
    }











    // Add product to the cart and file
    //public void AddProductToCart(string productName, int quantity)
    //{
    //    string productFile = Path.Combine(basePath, "product.txt");
    //    string[] lines = File.ReadAllLines(productFile);
    //    bool productFound = false;

    //    foreach (string line in lines)
    //    {
    //        var parts = line.Split(',');
    //        if (parts[0].Equals(productName, StringComparison.OrdinalIgnoreCase))
    //        {
    //            decimal price = decimal.Parse(parts[1]);
    //            productFound = true;

    //            SaveProductToCartFile(username, productName, price, quantity, cartFile);
    //            Console.Clear();
    //            Console.WriteLine($"Added {quantity} of {productName} to your cart.");

    //            break;
    //        }
    //    }

    //    if (!productFound)
    //    {
    //        Console.WriteLine("Product not found.");
    //    }
    //}










    public void AddProductToCart(string productName, int quantity, int expirationHours = 24)
    { 
        string productFile = Path.Combine(basePath, "product.txt");
        string[] lines = File.ReadAllLines(productFile);
        bool productFound = false;

        foreach (string line in lines)
        {
            var parts = line.Split(',');

            if (parts[0].Equals(productName, StringComparison.OrdinalIgnoreCase))
            {
                string p_name = parts[0];       // Product Name
                decimal price = decimal.Parse(parts[1]);  // Product Price
                string category = parts[2];     // Product Category
                int availableQuantity = int.Parse(parts[3]);  // Available Product Quantity

                if (quantity > availableQuantity)
                {
                    Console.WriteLine($"Sorry, only {availableQuantity} available in stock.");
                    return;
                }

                decimal total_price = price * quantity;  // Total price for the given quantity
                productFound = true;

                // Get the current timestamp and calculate the expiration time
                DateTime addTime = DateTime.Now;
                DateTime expirationTime = addTime.AddHours(expirationHours);

                // Save to the cart file with the format: p_name,price,category,quantity,total_price,addTime,expirationTime
                SaveProductToCartFile(username, p_name, price, category, quantity, total_price, cartFile, addTime, expirationTime);
                Console.Clear();
                Console.WriteLine($"Added {quantity} of {p_name} to your cart. It will expire at {expirationTime}.");

                break;
            }
        }

        if (!productFound)
        {
            Console.WriteLine("Product not found.");
        }
    }




    // Save to the cart file with the format: p_name,price,category,quantity,total_price
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
            DateTime expirationTime = DateTime.Parse(parts[6]);  // Expiration Time

            // Check if the cart has expired
            if (DateTime.Now > expirationTime)
            {
                cartExpired = true;
                Console.WriteLine($"Cart for user {username} has expired and is being removed.");
            }
            else
            {
                updatedCart.Add(line);  // If not expired, keep the cart entry
            }
        }

        // Rewrite the cart file with non-expired items
        File.WriteAllLines(cartFile, updatedCart);

        if (cartExpired)
        {
            Console.WriteLine("Expired cart items have been removed.");
        }
    }






    //checkout 1
 public void Checkout()
    {
        // Check if cart file exists
        if (!File.Exists(cartFile))
        {
            Console.WriteLine("Your cart is empty. Add items to the cart before checking out.");
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
            Console.WriteLine("Your cart is empty.");
            return;
        }

        // Display the user's cart items
        Console.WriteLine($"{username}'s Shopping Cart:");
        foreach (string[] item in userCartItems)
        {
            string productName = item[1];
            decimal price = decimal.Parse(item[2]);
            int quantity = int.Parse(item[4]);
            Console.WriteLine($"{productName} - Price: {price:C}, Quantity: {quantity}, Total: {price * quantity:C}");
        }

        // Get the product user wants to checkout
        Console.Write("\nEnter the product name you want to checkout: ");
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
            Console.WriteLine("Product not found in your cart.");
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
            Console.WriteLine($"Discount applied: {discount:C}");
        }

        // Add sales tax (2.5%)
        decimal salesTax = totalCost * 0.025m;
        totalCost += salesTax;

        // Display total amount due
        Console.WriteLine($"Total Amount Due (with Sales tax): {totalCost:C}");

        // Get user's phone number, shipping address, and payment info
        Console.Write("\nEnter your phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter your shipping address: ");
        string shippingAddress = Console.ReadLine();
        Console.Write("Enter your account number for payment: ");
        string accountNumber = Console.ReadLine();

        // Save checkout details
        SaveCheckoutDetails(productNameToCheckout, quantityToCheckout, totalCost, phoneNumber, shippingAddress, accountNumber);

        // Update product stock and remove the product from cart
        UpdateProductQuantity(productNameToCheckout, quantityToCheckout);
        RemoveProductFromCart(username, productNameToCheckout);

        // Show confirmation
        Console.WriteLine("\nThank you for your purchase!");
    }





    // Function to save checkout details
    private void SaveCheckoutDetails(string productName, int quantity, decimal totalCost, string phoneNumber, string shippingAddress, string accountNumber)
    {
        string checkoutFile = "C:\\Users\\PMLS\\source\\repos\\testnew\\testnew\\checkout.txt";
        //string checkoutFile = "checkout.txt"; // Path to save checkout info
        string data = $"{DateTime.Now}, {username}, {productName}, {quantity}, {totalCost:C}, {phoneNumber}, {shippingAddress}, {accountNumber}";
        File.AppendAllText(checkoutFile, data + Environment.NewLine); // Append the checkout data to a file
    }





    // Function to update product quantity after checkout
    private void UpdateProductQuantity(string productName, int quantityToDeduct)
    {
        string product_file = "C:\\Users\\PMLS\\source\\repos\\testnew\\testnew\\product.txt";
        string[] productLines = File.ReadAllLines(product_file);
        List<string> updatedProductLines = new List<string>();

        foreach (string line in productLines)
        {
            string[] parts = line.Split(',');
            if (parts[0].Equals(productName, StringComparison.OrdinalIgnoreCase))
            {
                int currentQuantity = int.Parse(parts[3]);
                int newQuantity = currentQuantity - quantityToDeduct;
                updatedProductLines.Add($"{parts[0]},{parts[1]},{parts[2]},{newQuantity}");
            }
            else
            {
                updatedProductLines.Add(line);
            }
        }

        File.WriteAllLines("product.txt", updatedProductLines);
    }






    // Function to show checkout history based on the username
    public void CheckoutHistory()
    {
        string checkoutFile = "C:\\Users\\PMLS\\source\\repos\\testnew\\testnew\\checkout.txt"; // Path to the checkout file

        // Check if the file exists
        if (File.Exists(checkoutFile))
        {
            // Read all the lines from the checkout file
            string[] lines = File.ReadAllLines(checkoutFile);

            // Create a list to store the matching history for the user
            List<string> userHistory = new List<string>();

            // Loop through each line and check if it contains the username
            foreach (var line in lines)
            {
                // Each line should be in the format: Date, Username, ProductName, Quantity, TotalCost, PhoneNumber, ShippingAddress, AccountNumber
                if (line.Contains(username))
                {
                    userHistory.Add(line); // Add the line to the user's history if it matches the username
                }
            }

            // Display the user's checkout history
            if (userHistory.Count > 0)
            {
                Console.WriteLine($"Checkout history for {username}:");
                foreach (var record in userHistory)
                {
                    Console.WriteLine(record); // Print each record that matches the username
                }
            }
            else
            {
                Console.WriteLine($"No checkout history found for {username}.");
            }
        }
        else
        {
            Console.WriteLine("Checkout file does not exist.");
        }
    }





















    // View the products in the user's cart
    public void ViewCart()
    {
        Console.Clear();
        if (!File.Exists(cartFile))
        {
            Console.WriteLine("Your cart is empty.");
            return;
        }

        Console.WriteLine($"{username}'s Shopping Cart:");
        string[] lines = File.ReadAllLines(cartFile);
        bool hasItems = false;

        foreach (string line in lines)
        {
            var parts = line.Split(',');
            if (parts[0] == username)  // Show only the logged-in user's cart items
            {
                hasItems = true;
                Console.WriteLine($"{parts[1]} - Price: {decimal.Parse(parts[2]):C}, Quantity: {parts[3]}");   //p_name,price,quantity
            }
        }

        if (!hasItems)
        {
            Console.WriteLine("Your cart is empty.");
        }
    }





    //// Show recommended products based on the user's cart
    //public void ShowRecommendedProducts()
    //{
    //    if (!File.Exists(cartFile))
    //    {
    //        Console.WriteLine("No recommendations available. Your cart is empty.");
    //        return;
    //    }

    //    string productFile = Path.Combine(basePath, "product.txt");
    //    if (!File.Exists(productFile))
    //    {
    //        Console.WriteLine("No products available to recommend.");
    //        return;
    //    }

    //    // Get the list of products the user already has in their cart
    //    string[] cartLines = File.ReadAllLines(cartFile);
    //    var userCartProducts = new HashSet<string>();

    //    foreach (string line in cartLines)
    //    {
    //        var parts = line.Split(',');
    //        if (parts[0] == username)
    //        {
    //            userCartProducts.Add(parts[1]);  // Collect product names the user already has
    //        }
    //    }
    //    Console.Clear();
    //    // Show products that are not in the user's cart
    //    Console.WriteLine("\nRecommended Products:");
    //    string[] productLines = File.ReadAllLines(productFile);
    //    bool hasRecommendations = false;

    //    foreach (string line in productLines)
    //    {
    //        var parts = line.Split(',');
    //        string productName = parts[0];

    //        if (!userCartProducts.Contains(productName))
    //        {
    //            hasRecommendations = true;
    //            Console.WriteLine($"{productName} - Price: {decimal.Parse(parts[1]):C}");
    //        }
    //    }

    //    if (!hasRecommendations)
    //    {
    //        Console.WriteLine("You have already added all available products to your cart.");
    //    }
    //}



    public void ShowRecommendedProducts()
    {
        if (!File.Exists(cartFile))
        {
            Console.WriteLine("No recommendations available. Your cart is empty.");
            return;
        }

        string productFile = Path.Combine(basePath, "product.txt");
        if (!File.Exists(productFile))
        {
            Console.WriteLine("No products available to recommend.");
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
                string p_name = parts[1];     // Product name in cart
                string category = parts[3];   // Category of the product in the cart

                cartCategories.Add(category); // Collect categories
                cartProducts.Add(p_name);     // Collect product names to avoid recommending the same
            }
        }

        if (cartCategories.Count == 0)
        {
            Console.WriteLine("No recommendations available. Your cart is empty.");
            return;
        }

        Console.Clear();
        Console.WriteLine("Recommended Products:");

        // Show products from product.txt that belong to categories in the cart but are not already in the cart
        string[] productLines = File.ReadAllLines(productFile);
        bool hasRecommendations = false;

        foreach (string line in productLines)
        {
            var parts = line.Split(',');
            string p_name = parts[0];       // Product Name in product file
            decimal price = decimal.Parse(parts[1]);  // Product Price
            string category = parts[2];     // Product Category
            int quantity = int.Parse(parts[3]);  // Product Quantity

            // Recommend products that match the category but are not in the cart
            if (cartCategories.Contains(category) && !cartProducts.Contains(p_name))
            {
                hasRecommendations = true;
                Console.WriteLine($"{p_name} - Price: {price:C} - Category: {category} - Quantity: {quantity}");
            }
        }

        if (!hasRecommendations)
        {
            Console.WriteLine("No recommendations found based on your cart.");
        }




    }







    // Updated method to save product details to the cart file
    private void SaveProductToCartFile(string username, string p_name, decimal price, string category, int quantity, decimal total_price, string cartFile)
    {
        using (StreamWriter writer = new StreamWriter(cartFile, true))
        {
            writer.WriteLine($"{username},{p_name},{price},{category},{quantity},{total_price}");
        }
    }

    // Save the product to the single cart file (with username included)
    //private void SaveProductToCartFile(string username, string productName, decimal price, int quantity, string cartFile)
    //{
    //    using (StreamWriter writer = new StreamWriter(cartFile, true))
    //    {
    //        writer.WriteLine($"{username},{productName},{price},{quantity}");
    //    }
    //}
















    // Function to remove a product from the cart
    // Function to remove a product from the shared cart based on username and product
    public void RemoveProductFromCart(string username, string productName)
    {
       // string cartFile = "cart.txt"; // Shared cart file for all users

        if (!File.Exists(cartFile))
        {
            Console.WriteLine("The cart is empty.");
            return;
        }

        string tempFile = "temp_cart.txt";
        bool productFound = false;

        using (StreamReader reader = new StreamReader(cartFile))
        using (StreamWriter writer = new StreamWriter(tempFile))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(',');

                // Check if the line belongs to the correct user and product
                if (!(parts[0].Equals(username, StringComparison.OrdinalIgnoreCase) &&
                      parts[1].Equals(productName, StringComparison.OrdinalIgnoreCase)))
                {
                    // Write back all products except the one to be removed for the specific user
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
            File.Delete(cartFile);  // Delete original cart file
            File.Move(tempFile, cartFile);  // Rename temp file to cart file
            Console.Clear();
            Console.WriteLine($"{productName} removed from your cart.");
        }
        else
        {
            File.Delete(tempFile); // Delete the temp file if product is not found
            Console.WriteLine($"{productName} is not in your cart.");
        }
    }






    //// Function to remove the product from the cart after checkout
    //private void RemoveProductFromCart(string username, string productName)
    //{
    //    string[] cartLines = File.ReadAllLines(cartFile);
    //    List<string> updatedCart = new List<string>();

    //    foreach (string line in cartLines)
    //    {
    //        string[] parts = line.Split(',');
    //        if (!(parts[0] == username && parts[1] == productName))
    //        {
    //            updatedCart.Add(line); // Keep lines that don't match the product being checked out
    //        }
    //    }

    //    File.WriteAllLines(cartFile, updatedCart);




    //}




}

class Program
{
    static string basePath = "C:\\Users\\PMLS\\source\\repos\\testnew\\testnew";  // Base path for all files

    static void Main()
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
            Console.WriteLine("\nWelcome to the Shopping Cart Application!");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option (1-3): ");
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
                    exit = true;
                    Console.WriteLine("Exiting...");
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void UserSession(ShoppingCart cart, string username)     //use shoppingcart class as object by argument
    {
        bool sessionActive = true;

        while (sessionActive)
        {
            Console.WriteLine($"\nWelcome {username}!");
            Console.WriteLine("1. View Available Products");
            Console.WriteLine("2. View Recommended Products");
            Console.WriteLine("3. Add Product to Cart");
            Console.WriteLine("4. Delete Cart Product");
            Console.WriteLine("5. View Cart");
            Console.WriteLine("6. Checkout");
            Console.WriteLine("7. Checkout History");
            Console.WriteLine("8. Logout");
            Console.Write("Choose an option (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    
                    ShowAvailableProducts();
                    break;
                case "2":

                    cart.ShowRecommendedProducts();
                    break;
                    
                case "3":
                    Console.Write("Enter product name to add: ");
                    string productName = Console.ReadLine();
                    Console.Write("Enter quantity: ");
                    if (int.TryParse(Console.ReadLine(), out int quantity) && quantity > 0)
                    {
                        cart.AddProductToCart(productName, quantity);
                    }
                    else
                    {
                        Console.WriteLine("Invalid quantity.");
                    }
                    break;
                case "4":
                    Console.Write("Enter product name to delete: ");
                    string product_Name = Console.ReadLine();
                    cart.RemoveProductFromCart(username,product_Name);
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
                    sessionActive = false;
                    Console.WriteLine("Logging out...");
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    //static void ShowAvailableProducts()
    //{
    //    Console.Clear();
    //    Console.WriteLine("Available Products:");
    //    string productFile = Path.Combine(basePath, "product.txt");

    //    if (!File.Exists(productFile) || new FileInfo(productFile).Length == 0)
    //    {
    //        Console.WriteLine("No products available.");
    //        return;
    //    }

    //    string[] lines = File.ReadAllLines(productFile);
    //    foreach (string line in lines)
    //    {
    //        var parts = line.Split(',');
    //        Console.WriteLine($"{parts[0]} - Price: {decimal.Parse(parts[1]):C}");
    //    }
    //}

    static void ShowAvailableProducts()
    {
        Console.Clear();
        Console.WriteLine("Available Products:");
        string productFile = Path.Combine(basePath, "product.txt");

        if (!File.Exists(productFile) || new FileInfo(productFile).Length == 0)
        {
            Console.WriteLine("No products available.");
            return;
        }

        string[] lines = File.ReadAllLines(productFile);
        foreach (string line in lines)
        {
            var parts = line.Split(',');

            // Storing product details into variables
            string p_name = parts[0];       // Product Name
            decimal price = decimal.Parse(parts[1]);  // Product Price
            string category = parts[2];   // Product Category
            int quantity = int.Parse(parts[3]);   // Product Quantity

            // Displaying the product details
            Console.WriteLine($"{p_name} - Price: {price:C} - Category: {category} - Quantity: {quantity}");
        }
    }



    static void RegisterUser()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (IsUsernameTaken(username))
        {
            Console.WriteLine("Username already taken. Please choose another.");
            return;
        }

        string userFile = Path.Combine(basePath, "users.txt");
        using (StreamWriter writer = new StreamWriter(userFile, true))
        {
            writer.WriteLine($"{username},{password}");
        }
        Console.WriteLine("User registered successfully!");
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
        Console.Write("Enter username: ");
        username = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        string userFile = Path.Combine(basePath, "users.txt");

        if (!File.Exists(userFile))
        {
            Console.WriteLine("No registered users. Please register first.");
            username = null;
            return false;
        }

        string[] lines = File.ReadAllLines(userFile);
        foreach (string line in lines)
        {
            var parts = line.Split(',');
            if (parts[0].Equals(username, StringComparison.OrdinalIgnoreCase) && parts[1] == password)
            {
                Console.WriteLine("Login successful!");
                Console.Clear();
                return true;
                
            }
        }
        Console.Clear();

        Console.WriteLine("Invalid username or password.");
        username = null;
        return false;
    }

}

