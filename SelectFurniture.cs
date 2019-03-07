/*Patrick Topor-Madry
* PROG 110 Homework 10
* November 27th, 2017
* 
* When executed, this program will ask for the number of drawers and the type of wood for a desk
* It will use a function to calculate the costs of all the drawers, another one to calculate the cost of the desk based on the wood.
* Finally, a third function will add up the total cost based on the wood type and drawer number.
* Total cost, type of wood and extra cost of drawers are displayed to the user.
*/

using static System.Convert;
using static System.Console;

namespace Homework10_final
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char woodType = ' ';
            float drawerPrice = 0.00f;
            float total = 0.00f;

            WriteLine("Hello!  Welcome to the generic desk company!");

            woodType = GetWoodType();
            drawerPrice = GetDrawerPrice();
            total = GetTotal(drawerPrice, woodType);

            WriteLine(" ");
            WriteLine("Thank you for using the generic desk company!");
            WriteLine("The desk will be made of {0} wood.", woodType);
            WriteLine("The cost of the drawers will be ${0}.", drawerPrice);
            WriteLine("Your total bill will be ${0}.", total);

        }
        //Calculates total cost based on number of drawers and wood type
        private static float GetTotal(float drawerPrice, char woodType)
        {
            float total = 0.00f;
            int price;
            switch (woodType)
            {
                case 'p': //Pine
                    price = 100;
                    break;
                case 'o':  //Oak
                    price = 140;
                    break;
                default: //Mahogany (only option left)
                    price = 180;
                    break;
            }

            total = drawerPrice + price;

            return total;

        }

        //Calculate additional price based on desired drawers
        private static float GetDrawerPrice()
        {
            float drawerPrice = 0.00f;
            int drawerNumber;
            bool done = false;
            string userString;

            while (!done)
            {
				Write("How many drawers do you want with your desk? >> ");
                userString = ReadLine();
                drawerNumber = ToInt32(userString);

                if (drawerNumber >= 0)
                {
                    done = true;
                    drawerPrice = drawerNumber * 30;
                }
            }
            return drawerPrice;
        }

        //Gets the type of wood user wants for their desk
        private static char GetWoodType()
        {
            char wood = ' ';
            string userString;
            bool done = false;

            while (!done)
            {
				WriteLine("Please enter the type of wood you want your drawer to be made of.");
				Write("Press P for Pine, M for Mahogany, or O for Oak >> ");
				userString = ReadLine();
				wood = ToChar(userString.ToLower());  

                switch (wood)
                {
                    case 'o':
                        
                        done = true;
                        break;
                    case 'p':
                        done = true;
                        break;
                    case 'm':
                        done = true;
                        break;
                }      
            }
            return wood;
        }
    }
}
