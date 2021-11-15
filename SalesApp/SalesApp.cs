/* SalesApp.cs
 * This application tallies sales for four sales areas 
 * selling three different types of dessert pies.  
 * Sales are input by the user. Any number of sales can 
 * be entered. Note we are tallying up the sales not the
 * counts.
*/
using System;
using static System.Console;

namespace SalesApp
{
    class SalesApp
    {
        static void Main(string[] args)
        {
            const int COUNT_OF_SALES_AREAS = 4;
            const int COUNT_OF_PRODUCTS = 3;

            double[,] sales = new double[COUNT_OF_SALES_AREAS, COUNT_OF_PRODUCTS];

            string[] salesArea = { "Victoria", "Nanaimo", "Kamloops", "Vancouver" };
            string[] productName = { "Lemon", "Apple", "Pumpkin" };

            InitializeArray(sales);
            //Console.WriteLine(sales[0, 0]);
            GetSalesFigures(sales, salesArea, productName);

            //DisplayResults(sales, salesArea, productName);
            ReadKey();

        }
        public static void InitializeArray(double[,] sales)
        {
            /*  Set all sales values for each sales area and product to zero.
             */
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    sales[i, j] = 0;
                }
            }
        }

        public static void GetSalesFigures(double[,] sales, string[] salesmenName, string[] productName)
        {

            int salesNo,
                productNo;
            string inputValue;
            bool moreData = true;
            while (moreData)
            {
                salesNo = GetSalesNumber(salesmenName);
                productNo = GetProductNumber(productName);
                sales[salesNo, productNo] += GetSalesFigures();
                
                /* TODO: Prompt if there are more sales.  If there are
                 *       no more sales to record, set the moreData 
                 *       sentinel to false.
                 */
                
            }
        }

        public static int GetSalesNumber(string[] salesAreaName)
        {
            int salesNo = -1;
            while (salesNo > 0 || salesNo < 5)
            {
                Clear();
                WriteLine("Sales Registry\n\n");
                /*
                 * TODO: show the sales area names by number: 
                 *     1. Victoria
                 *     2. Nanaimo ... etc
                 */
                Write("\nSales are for which sales area? (1-4):  ");
                
                /*
                 * TODO: read in a salesNo value that is confirmed to be valid,
                 *       if it isn't, display a message, then reread the value
                 *       until it is valid.
                 */
            }
            return salesNo - 1;
        }

        public static int GetProductNumber(string[] productName)
        {
            int productNo = -1;
            while (productNo > 0 || productNo < 4)
            {
                Clear();
                WriteLine("Products\n\n");
                /*
		 * TODO: show the product names by number: 
		 *     1. Lemon
		 *     2. Apple ... etc
                 */

                Write("\nSales are for which product?  ");
                
                /*
                 * TODO: read in a productNo value that is confirmed to be valid,
                 *       if it isn't, display a message, then reread the value
                 *       until it is valid.
                 */                

            }
            return productNo - 1;
        }

        public static double GetSalesFigures()
        {
            double salesAmt=0;
            Write("What was the sales amount? ");
            /*
             * TODO: read in a salesAmt value that is confirmed to be valid,
             *       if it isn't, display a message, then reread the value.
             */            

            return salesAmt;
        }

        public static void DisplayResults(double[,] sales, string[] salesAreaName, string[] productName)
        {
            Clear();
            WriteLine("\t\tSales Summary\n\n");
            Write("{0, -15}", "Sales Area");
            for (int i = 0; i < productName.Length; i++)
            {
                Write("{0, 10}", productName[i]);
            }
            WriteLine();
            
            /* 
             * TODO: display the sales data in table format like this:
             *      
             *  Victoria           100.00    200.00      0.00
             *  Nanaimo              0.00      0.00      0.00
             *  etc..
             */
        }
    }
}