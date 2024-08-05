

namespace LINQ1
{
    internal  class Program
    {

        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            //Find all products that are out of stock:
            var outOfStockProducts = from product in ListGenerator.ProductsList
                                     where product.UnitsInStock == 0
                                     select product;

            foreach (var product in outOfStockProducts)
            {
                Console.WriteLine(product);
            }


            //2-Find all products that are in stock and cost more than 3.00 per unit:
            var inStockAndExpensiveProducts = from product in ListGenerator.ProductsList
                                              where product.UnitsInStock > 0 && product.UnitPrice > 3.00M
                                              select product;

            foreach (var product in inStockAndExpensiveProducts)
            {
                Console.WriteLine(product);
            }


            //3-Return digits whose name is shorter than their value:
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var shortNamedDigits = from item in Arr
                                   where item.Length < Array.IndexOf(Arr, item)
                                   select item;

            foreach (var item in shortNamedDigits)
            {
                Console.WriteLine(item);
            }


            #endregion

            #region Ordering Operators
            //1-Sort a list of products by name:
            var productsSortedByName = from product in ListGenerator.ProductsList
                                       orderby product.ProductName
                                       select product;

            foreach (var product in productsSortedByName)
            {
                Console.WriteLine(product);
            }


            //2-Case-insensitive sort of the words in an array:
            string[] wordsArr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var sortedWords = wordsArr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            }

            //3-Sort a list of products by units in stock from highest to lowest:
            var productsSortedByStock = from product in ListGenerator.ProductsList
                                        orderby product.UnitsInStock descending
                                        select product;

            foreach (var product in productsSortedByStock)
            {
                Console.WriteLine(product);
            }


            //4-Sort a list of digits by the length of their name, then alphabetically by the name itself:
            string[] digitsArr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var sortedDigits = digitsArr.OrderBy(digit => digit.Length).ThenBy(digit => digit);

            foreach (var digit in sortedDigits)
            {
                Console.WriteLine(digit);
            }

            //5-Sort words by length and then by a case-insensitive sort:
            var wordsSortedByLengthAndCase = wordsArr.OrderBy(word => word.Length)
                                         .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

            foreach (var word in wordsSortedByLengthAndCase)
            {
                Console.WriteLine(word);
            }

            //6-Sort products by category and then by unit price from highest to lowest:
            var productsSortedByCategoryAndPrice = from product in ListGenerator.ProductsList
                                                   orderby product.Category, product.UnitPrice descending
                                                   select product;

            foreach (var product in productsSortedByCategoryAndPrice)
            {
                Console.WriteLine(product);
            }


            //7-Sort words by length and then by a case-insensitive descending sort:
            var wordsSortedByLengthAndCaseDesc = wordsArr.OrderBy(word => word.Length)
                                             .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);

            foreach (var word in wordsSortedByLengthAndCaseDesc)
            {
                Console.WriteLine(word);
            }


            //8-Create a list of all digits whose second letter is 'i', reversed from the order in the original array:
            var digitsWithSecondLetterIReversed = (from item in digitsArr
                                                   where item.Length > 1 && item[1] == 'i'
                                                   select item).Reverse();

            foreach (var item in digitsWithSecondLetterIReversed)
            {
                Console.WriteLine(item);
            }






            #endregion
        }
    }
}
