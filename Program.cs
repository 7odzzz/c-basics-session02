namespace C__basics_assigment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region firstPoint
            //Book b1 = new Book();
            //object obj = b1; // obj points to the same data of b1 

            //Console.WriteLine(obj);
            #endregion


            #region SecondPoint

            //Book b2 = new Book();
            //Console.WriteLine(b1.ToString()); // same address
            //Console.WriteLine(b1.Equals(b1)); // True bec it's the same object!!
            //Console.WriteLine(b1.GetHashCode());
            //Console.WriteLine(b1.GetType()); // namespace.book

            #endregion


            #region ThirdPoint

            //int pages = "464"; // compile time error cannot convert String to int
            //int pages = 464; // valid

            #endregion


            #region FourthPoint
            //try
            //{
            //    int x = 10;
            //    int y = 0;
            //    Console.WriteLine(x / y); // ERROR
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("Cannot divide by zero.");
            //}
            //finally
            //{
            //    Console.WriteLine("DONE (finallyy block)");
            //}

            #endregion


            #region FifthPoint
            //int pages = 300; // 4 bytes
            //double y1 = pages; // implicit casting 8 bytes
            #endregion

            
            #region SixPoint
            //double price = 49.99; // 8 bytes
            //int x1 = (int)price; // explicit casting
            #endregion


            #region SeventhPoint
            string pagesText = "464";
            int pageInt = Convert.ToInt32(pagesText); //464

            #endregion


            #region EightsPoint
            //string yearText = "2023";
            //int yearsInt = int.Parse(yearText); //2023 with no exception



            //string badText = "abc";
            //bool resultOfTryParse = int.TryParse(badText, out int badInt);
            //Console.WriteLine(resultOfTryParse);
            //Console.WriteLine(badInt);    

            #endregion


            #region NinthPoint
            //int pages = 464;
            //string str = pages.ToString(); // "464"
            //Console.WriteLine(str.GetType()); // string 
            #endregion

            
            #region LastPoint
            //int copies = 100;
            //object obj = copies; // boixng

            //int copies2 = (int)obj; //unboxing with explicit casting

            //Console.WriteLine(obj); //100 
            //Console.WriteLine(copies); //100
            //Console.WriteLine(copies2); //100

            #endregion

        }
    }
}
