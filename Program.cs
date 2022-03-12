﻿using hello_world;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            /*
            //ondan küçük mü 1 den büyük mü?
              Console.WriteLine("Please enter a number 1-10:");
              var Value = Console.ReadLine();
              Int64.Parse(Value);
              Console.WriteLine(Value);
              if (int.Parse(Value) >= 1 && int.Parse(Value) <= 10)
              {
                  Console.WriteLine("Valid");
              }
              else
              {
                  Console.WriteLine("Invalid");
              }*/
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Write a program to count how many numbers between 1 and 100 are "divisible by 3" with no remainder.
            //Display the count on the console

            /*
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)Console.WriteLine(i);
            }
            */
            //////////////////////////////////////////////////////////////////////////////////////////////
            //Write a program and continuously ask the user to enter a number or "ok" to exit.
            //Calculate the sum of all the previously entered numbers and display it on the console.
            // check ok or not.
            //
            /*
            bool isAsking = true;
            int Total = 0;
            var ok = "ok";
            while(isAsking)
            {
                Console.WriteLine("Please insert numbers. to sum up write (ok)");
                var input = Console.ReadLine();

                if (input == "Ok" || input == "OK"  || input == "ok")
                {
                    isAsking = false;
                    Console.WriteLine("Your total Expenses: " + Total);
                    break;
                }
                Total += Int32.Parse(input);
                Console.WriteLine("This is total:" + Total);
                Console.WriteLine("This is input:" + input);
                */
            //////////////////////////////////////////////////////////////////////////////////////
            ///
            //Write a program and ask the user to enter a number.
            //Compute the factorial of the number and print it on the console.
            //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and
            //display it as 5! = 120
            /*
            Console.Write("Enter a number: ");
            var factorial = Convert.ToInt32(Console.ReadLine());
            var fctrl = factorial--;
            var sum = fctrl;
            for (int i = factorial; i >= 1; i--)
            {
                fctrl *= i;
                Console.WriteLine("debug:"+i);
                if (i == 1)
                {
                    Console.WriteLine("factorial sum : " + sum +"! = " + fctrl);
                }
            }*/
            /////////////////////////////////////////////////////////////////////////////////////
            //Write a program that picks a random number between 1 and 10.
            //Give the user 4 chances to guess the number.
            //If the user guesses the number, display “You won"; otherwise, display “You lost".
            //(To make sure the program is behaving correctly,
            //you can display the secret number on the console first.)
            /*
            var rand = new Random();
            var solution = rand.Next(0, 10);
            for (int i = 0; i < 4; i++)
            {
                var bet = Convert.ToInt32(Console.ReadLine());
                if (bet == solution)
                {
                    Console.WriteLine("You  Won !! " + solution);
                    break;
                }
                else Console.WriteLine("You lost, please try again. ");
            }
            */
            ///////////////////////////////////////////////////////////////////////////////////////
            //Write a program and ask the user to enter a series of numbers separated by comma.
            //Find the maximum of the numbers and display it on the console.
            //For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
            /*
            var charsToRemove = new string[] { "@", ",", ".", ";", "'" };
            Console.WriteLine("Please enter 4 numbers separeted with (,)");
            var list = Console.ReadLine();
            foreach (var c in charsToRemove)// these will remove ","
            {
                list = list.Replace(c, string.Empty);
            }

            var maxNumber = list.Max();//string to bigeset number

            Console.WriteLine("Max number is: " + maxNumber);
            */
            ///////////////////////////////////////////////////////////////////////////////////////
            // A person already posted so he will upload names that liked his post 
            //If no one likes your post, it doesn't display anything.
            //If only one person likes your post, it displays: [Friend's Name] likes your post.
            //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
            //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
            /*
            var names = new List<string>();
            string name ;
            bool Posted = false;
            int others;
            while (!Posted)
            {
            Console.WriteLine("Please enter whom liked ?");
            name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
	           {
                    names.Add(name);
                }
                else
                {
                    Posted = true;
                    
                        if (names.Count == 1)
                        {
                            Console.WriteLine(names[0] + "likes your post.");
                        }
                        if (names.Count == 2)
                        {
                            Console.WriteLine(names[0] + "and" + names[1] + "liked your post");
                        }
                        if (names.Count >= 3)
                        {
                            Console.WriteLine(names[0] + ", " + names[1] + " and ");
                            others = names.Count;
                            others -= 2;
                            Console.WriteLine(others + " others liked your post");
                        }
                }
            }
            */
            /////////////////////////////////////////////////////////////////////////////////
            //Write a program and ask the user to enter their name. Use an array to reverse the name and
            //then store the result in a new string. Display the reversed name on the console.
            /*
            var array = new Array[1];
            string name;
            name = Console.ReadLine();// gget info
            char[] charArr = name.ToCharArray();//string to char
            Array.Reverse(charArr);
            name = new string(charArr);//char array to string
            Console.WriteLine(name);
            */
            /////////////////////////////////////////////////////////////////////////////////////
            //Write a program and ask the user to enter 5 numbers.
            //If a number has been previously entered, display an error message and ask the user to re-try.
            //Once the user successfully enters 5 unique numbers,
            //sort them and display the result on the console.
            /*
            bool norepeat = false;
            int number;
            Console.WriteLine("please enter 5 digit number.");
            number = Convert.ToInt32(Console.ReadLine());

            char[] list = number.ToString().ToCharArray();


            var dict = new Dictionary<int, int>();

            foreach (var value in list)
            {
                // When the key is not found, "count" will be initialized to 0
                dict.TryGetValue(value, out int count);
                dict[value] = count + 1;
                if (count >= 1)
                {
                    Console.WriteLine("Please try again you made a duplicate.");
                }
                else
                {
                    norepeat = true;
                }
            }
            if (norepeat)
            {
                Array.Sort(list);
                Console.WriteLine("here is conclusion : ");
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            */
            ////////////////////////////////////////////////////////////////////////////
            //Write a program and ask the user to continuously enter a number or type "Quit" to exit.
            //The list of numbers may include duplicates. Display the unique numbers that the user has entered.
            /*
            bool isAsking = true;
            while (isAsking)
            {
                Console.WriteLine("Please insert numbers. which gonna show unique numbers if you write (Quit) gonna quit application.");
                var input = Console.ReadLine();
                if (input == "Quit")
                {
                    isAsking = false;
                    break;
                }
                else
                {
                    bool norepeat = false;
                    int number;

                    number = Convert.ToInt32(input);//girdi alınıp int  dönüştü

                    char[] list = number.ToString().ToCharArray(); // int to char array 

                    var dict = new Dictionary<int, int>();

                    foreach (var value in list) // burda char arrayde duplicate lerin bulunup silinmesi ve gösterilmesi gerek.
                    {
                        // When the key is not found, "count" will be initialized to 0
                        dict.TryGetValue(value, out int count);
                        dict[value] = count + 1;
                        if (count == 0)
                        {
                            norepeat = true;
                        }
                        else
                        {
                            norepeat = false;
                            Console.WriteLine("deleting duplicates");
                            int[] Aint = list.Select(i => Int32.Parse(i.ToString())).ToArray();
                            int[] distinct = Aint.Distinct().ToArray();
                            Console.WriteLine("Here is your corrected unique numbers:");
                            foreach (var item in distinct)
                            {
                                Console.WriteLine(item);
                            }
                        }
                    }
                    if (norepeat)
                    {
                        Array.Sort(list);
                        Console.WriteLine("here is your unique numbers :"); 
                        foreach (var item in input)
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
            }
            */
            ///////////////////////////////////////////////////////////////////////////////////
            //Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10).
            //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
            //otherwise, display the 3 smallest numbers in the list.
            


            var charsToRemove = new string[] { "@", ",", ".", ";", "'" };
            Console.WriteLine("Please enter 5 numbers separeted with (,) in range of 1-9");
            var list = Console.ReadLine();

            foreach (var c in charsToRemove)// these will remove ","
            {
                list = list.Replace(c, string.Empty);
            }
            if (5 == list.Length)
            {


                char[] charArr = list.ToCharArray();

                //
                // Burda list in string ten char array a cevrilmesi ve ondan sonra sayıların tek tek arraya atılması gerek.
                int[] Aint = Array.ConvertAll(charArr, c => (int)Char.GetNumericValue(c));
                int i = 0;
                int small = 0;
                //integer array declaration
                int[] arr = new int[5];

                Console.WriteLine("Enter array elements : ");



                //assign fist element to the 'small' 
                //compare it with other array elements
                small = Aint[0];
                int firstSmall;
                int secondSmall;
                int thirdSmall;

                for (i = 1; i < 5; i++)
                {
                    //compare if small is greater than of any element of the array
                    //assign that element in it.
                    if (small > Aint[i])
                        small = Aint[i];
                }
                firstSmall = small;
                int indexToRemove = Array.IndexOf(Aint, firstSmall);
                Aint = Aint.Where((source, index) => index != indexToRemove).ToArray();
                small = Aint[0];

                for (i = 1; i < 4; i++)
                {
                    //compare if small is greater than of any element of the array
                    //assign that element in it.
                    if (small > Aint[i])
                        small = Aint[i];
                }
                secondSmall = small;
                indexToRemove = Array.IndexOf(Aint, secondSmall);
                Aint = Aint.Where((source, index) => index != indexToRemove).ToArray();
                small = Aint[0];

                for (i = 1; i < 3; i++)
                {
                    //compare if small is greater than of any element of the array
                    //assign that element in it.
                    if (small > Aint[i])
                        small = Aint[i];
                }
                thirdSmall = small;
                indexToRemove = Array.IndexOf(Aint, thirdSmall);
                Aint = Aint.Where((source, index) => index != indexToRemove).ToArray();
                small = Aint[0];
                foreach (var item in Aint)
                {
                    Console.WriteLine(" last list elements : " + item);
                }
                //finally print the smallest elemeent of the integer array
                Console.WriteLine("Smallest elements in array are : " + firstSmall + " " + secondSmall + " " + thirdSmall);
            }
            else
            {
                Console.WriteLine("please enter 5 numbers and in 1 digits please. Also not empty please.");
            }
        }
    }
}
 