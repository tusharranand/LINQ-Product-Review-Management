using System;
using System.Linq;

namespace Product_Review_Management
{
    class Program
    {
        readonly List<ItemDetails> items;
        public Program()
        {
            items = new List<ItemDetails>()
            {
                new ItemDetails(){ ProductID = 1, UserID = 9, Rating = 5, Review = "Excellent", IsLike = true },
                new ItemDetails(){ ProductID = 2, UserID = 10, Rating = 4, Review = "Good", IsLike = false },
                new ItemDetails(){ ProductID = 3, UserID = 8, Rating = 4, Review = "Good", IsLike = true },
                new ItemDetails(){ ProductID = 4, UserID = 7, Rating = 1, Review = "Very Bad", IsLike = true },
                new ItemDetails(){ ProductID = 5, UserID = 2, Rating = 1, Review = "Very Bad", IsLike = true },
                new ItemDetails(){ ProductID = 6, UserID = 6, Rating = 5, Review = "Excellent", IsLike = false },
                new ItemDetails(){ ProductID = 7, UserID = 3, Rating = 4, Review = "Good", IsLike = false },
                new ItemDetails(){ ProductID = 8, UserID = 9, Rating = 5, Review = "Excellent", IsLike = true },
                new ItemDetails(){ ProductID = 9, UserID = 6, Rating = 1, Review = "Very Bad", IsLike = false },
                new ItemDetails(){ ProductID = 10, UserID = 4, Rating = 3, Review = "Average", IsLike = false },
                new ItemDetails(){ ProductID = 11, UserID = 4, Rating = 2, Review = "Bad", IsLike = false },
                new ItemDetails(){ ProductID = 12, UserID = 10, Rating = 2, Review = "Bad", IsLike = false },
                new ItemDetails(){ ProductID = 13, UserID = 1, Rating = 5, Review = "Excellent", IsLike = true },
                new ItemDetails(){ ProductID = 11, UserID = 8, Rating = 2, Review = "Bad", IsLike = true },
                new ItemDetails(){ ProductID = 15, UserID = 5, Rating = 3, Review = "Average", IsLike = false },
                new ItemDetails(){ ProductID = 16, UserID = 1, Rating = 3, Review = "Average", IsLike = true },
                new ItemDetails(){ ProductID = 17, UserID = 7, Rating = 1, Review = "Very Bad", IsLike = false },
                new ItemDetails(){ ProductID = 18, UserID = 10, Rating = 3, Review = "Average", IsLike = true },
                new ItemDetails(){ ProductID = 19, UserID = 3, Rating = 4, Review = "Good", IsLike = true },
                new ItemDetails(){ ProductID = 20, UserID = 2, Rating = 5, Review = "Excellent", IsLike = false },
                new ItemDetails(){ ProductID = 21, UserID = 6, Rating = 3, Review = "Average", IsLike = true },
                new ItemDetails(){ ProductID = 22, UserID = 2, Rating = 1, Review = "Very Bad", IsLike = false },
                new ItemDetails(){ ProductID = 23, UserID = 2, Rating = 4, Review = "Good", IsLike = true },
                new ItemDetails(){ ProductID = 24, UserID = 1, Rating = 2, Review = "Bad", IsLike = false },
                new ItemDetails(){ ProductID = 25, UserID = 3, Rating = 5, Review = "Excellent", IsLike = true }
            };
        }
        public void DisplayList(List<ItemDetails> items)
        {
            foreach (ItemDetails item in items)
            {
                Console.WriteLine("Product ID: {0}, \nUser ID: {1}, \nRating: {2}, \nReview: {3}, " +
                    "\nIs Like: {4} \n", item.ProductID, item.UserID, item.Rating, item.Review, 
                    item.IsLike);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management using LINQ");
            Program program = new Program();
            int control;
            do
            {
                Console.WriteLine("\n-----------------------------------------------");
                Console.WriteLine("Choose a Number:");
                Console.WriteLine("1 to display the list of items"); 
                Console.WriteLine("0 to EXIT");
                control = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------\n");
                switch (control)
                {
                    case 1:
                        program.DisplayList(program.items);
                        break;
                    default:
                        break;
                }

            } while (control != 0);
        }
    }
}