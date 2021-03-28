using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input amount of box in bucket number 1 : ");
            int boxofbucket1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input amount of box in bucket number 2 : ");
            int boxofbucket2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input amount of box in bucket number 3 : ");
            int boxofbucket3 = int.Parse(Console.ReadLine());
            int sumofbox = boxofbucket1 + boxofbucket2 + boxofbucket3;
            Console.WriteLine("The sum of boxes in all buckets is {0}.", sumofbox);
            int count = 1;
            int boxout = 0;
            int numofbucket = 0;

            while (sumofbox > 0)
            {
                Console.WriteLine("ROUND {0}", count);
                count++;

                bool validofbucket = false;
                while (validofbucket == false)
                {
                    Console.WriteLine("Input number of the bucket : ");
                    numofbucket = int.Parse(Console.ReadLine());
                    if (numofbucket == 1 || numofbucket == 2 || numofbucket == 3)
                    { 
                        validofbucket = true;
                        bool validofboxout = false;
                        while (validofboxout == false)
                        {
                            Console.WriteLine("Input amount of box : ");
                            boxout = int.Parse(Console.ReadLine());
                            if (boxout == 1 || boxout == 2)
                            { 
                                validofboxout = true;
                                switch (numofbucket)
                                {
                                    case '1':
                                        if (boxofbucket1 > 0)
                                        {
                                            if (boxofbucket1 >= boxout)
                                            {
                                                boxofbucket1 = boxofbucket1 - boxout;
                                                sumofbox = sumofbox - boxout;
                                            }
                                            else
                                            {
                                                validofboxout = false;
                                                Console.WriteLine("Boxes that you want to leave are more than the box in this bucket. Please try again.");
                                            }
                                        }
                                        else
                                        {
                                            validofbucket = false;
                                            Console.WriteLine("Plese change you choice. all boxes in bucket 1 are out now.");
                                        }
                                        break;
                                    case '2':
                                        if (boxofbucket2 > 0)
                                        {
                                            if (boxofbucket2 >= boxout)
                                            {
                                                boxofbucket2 = boxofbucket2 - boxout;
                                                sumofbox = sumofbox - boxout;
                                            }
                                            else
                                            {
                                                validofboxout = false;
                                                Console.WriteLine("Boxes that you want to leave are more than the box in this bucket. Please try again.");
                                            }
                                        }
                                        else
                                        {
                                            validofbucket = false;
                                            Console.WriteLine("Plese change you choice. all boxes in bucket 2 are out now.");
                                        }
                                        break;
                                    case '3':
                                        if (boxofbucket3 > 0)
                                        {
                                            if (boxofbucket3 >= boxout)
                                            {
                                                boxofbucket3 = boxofbucket3 - boxout;
                                                sumofbox = sumofbox - boxout;
                                            }
                                            else
                                            {
                                                validofboxout = false;
                                                Console.WriteLine("Boxes that you want to leave are more than the box in this bucket. Please try again.");
                                            }
                                        }
                                        else
                                        {
                                            validofbucket = false;
                                            Console.WriteLine("Plese change you choice. all boxes in bucket 3 are out now.");
                                        }
                                        break;
                                    default:
                                        validofbucket = false;
                                        Console.WriteLine("Please input number of bucket again. it's can be '1' or '2' or '3' only.");
                                        break;
                                }
                            }
                            else
                            { 
                                validofboxout = false;
                                Console.WriteLine("Plese input amount of box again. it can be '1' or '2' only.");
                            }
                        }
                        Console.WriteLine("The number of the bucket is {0}", numofbucket);
                        Console.WriteLine("The amount of boxout is {0}", boxout);
                        /////////////////////////////////
                        if (numofbucket == 1)
                        {
                            if (boxofbucket1 > 0)
                            {
                                boxofbucket1 = boxofbucket1 - boxout;
                                sumofbox = sumofbox - boxout;
                            }
                            else
                            {
                                validofbucket = false;
                                Console.WriteLine("Plese change you choice. the box in bucket 1 is out now.");
                            }
                        }
                        else if (numofbucket == 2)
                        {
                            if (boxofbucket2 > 0)
                            {
                                boxofbucket2 = boxofbucket2 - boxout;
                                sumofbox = sumofbox - boxout;
                            }
                            else
                            {
                                validofbucket = false;
                                Console.WriteLine("Plese change you choice. the box in bucket 2 is out now.");
                            }
                        }
                        else if (numofbucket == 3)
                        {
                            if (boxofbucket3 > 0)
                            {
                                boxofbucket3 = boxofbucket3 - boxout;
                                sumofbox = sumofbox - boxout;
                            }
                            else
                            {
                                validofbucket = false;
                                Console.WriteLine("Plese change you choice. the box in bucket 3 is out now.");
                            }
                        }
                    }
                    
                }                               
                Console.WriteLine("box of  bucket 1 is {0}", boxofbucket1);
                Console.WriteLine("box of  bucket 2 is {0}", boxofbucket2);
                Console.WriteLine("box of  bucket 3 is {0}", boxofbucket3);
                Console.WriteLine("sum of box is {0}", sumofbox);     
            }  
            if (count % 2 != 0)
            { Console.WriteLine("The winner is Player B"); }
            else
            { Console.WriteLine("The winner is Player A"); }          
        }
    }
}
