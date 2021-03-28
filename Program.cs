using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input amount of boxes in bucket number 1 : ");
            int boxofbucket1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input amount of boxes in bucket number 2 : ");
            int boxofbucket2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input amount of boxes in bucket number 3 : ");
            int boxofbucket3 = int.Parse(Console.ReadLine());
            int sumofboxes = boxofbucket1 + boxofbucket2 + boxofbucket3;
            Console.WriteLine("The sum of boxes in all bucket is {0}", sumofboxes);
            int count = 1;
            int numofbucket;
            int boxout;
            string player;

            while (sumofboxes > 0)
            {
                if (count % 2 != 0)
                {
                    player = "player A";
                }
                else
                {
                    player = "player B";
                }
                Console.WriteLine("ROUND {0}: {1}", count, player);
                count++;

                bool validofbucket = false;
                while (validofbucket == false)
                {
                    Console.WriteLine("Choose the bucket : ");
                    numofbucket = int.Parse(Console.ReadLine());
                    if (numofbucket == 1 || numofbucket == 2 || numofbucket == 3)
                    {
                        bool validofboxout = false;
                        while (validofboxout == false)
                        {
                            Console.WriteLine("How many that you want to leave boxes : ");
                            boxout = int.Parse(Console.ReadLine());
                            if (boxout == 1 || boxout == 2)
                            {
                                validofboxout = true;
                                switch (numofbucket)
                                {
                                    case 1:
                                        if (boxofbucket1 > 0)
                                        {
                                            if (boxofbucket1 >= boxout)
                                            {
                                                boxofbucket1 = boxofbucket1 - boxout;
                                                sumofboxes = sumofboxes - boxout;                                               
                                                validofbucket = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Player can't leave boxes because boxes that you want to leave is more than boxes in this bucket. Please try again.");
                                                validofbucket = false;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please change your choice. all of boxes in this bucket are out now.");
                                            validofbucket = false;
                                        }
                                        break;
                                    case 2:
                                        if (boxofbucket2 > 0)
                                        {
                                            if (boxofbucket2 >= boxout)
                                            {
                                                boxofbucket2 = boxofbucket2 - boxout;
                                                sumofboxes = sumofboxes - boxout;
                                                validofbucket = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Player can't leave boxes because boxes that you want to leave is more than boxes in this bucket. Please try again.");
                                                validofbucket = false;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please change your choice. all of boxes in this bucket are out now.");
                                            validofbucket = false;
                                        }
                                        break;
                                    case 3:
                                        if (boxofbucket3 > 0)
                                        {
                                            if (boxofbucket3 >= boxout)
                                            {
                                                boxofbucket3 = boxofbucket3 - boxout;
                                                sumofboxes = sumofboxes - boxout;
                                                validofbucket = true;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Player can't leave boxes because boxes that you want to leave is more than boxes in this bucket. Please try again.");
                                                validofbucket = false;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Please change your choice. all of boxes in this bucket are out now.");
                                            validofbucket = false;
                                        }
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else 
                            {
                                Console.WriteLine("Please try again. you can leave boxes only 1 or 2.");
                                validofboxout = false;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please try again. the bucket only have 1, 2, and 3.");
                        validofbucket = false;
                    }
                }
                Console.WriteLine("Boxes in bucket number 1 have {0}", boxofbucket1);
                Console.WriteLine("Boxes in bucket number 2 have {0}", boxofbucket2);
                Console.WriteLine("Boxes in bucket number 3 have {0}", boxofbucket3);
                Console.WriteLine("The sum of boxes in all buckets is {0}", sumofboxes);
            }
            if ((count - 1) % 2 != 0)
            {
                Console.WriteLine("The winner is Player B");
            }
            else
            {
                Console.WriteLine("The winner is Player A");
            }
        }
    }
}
