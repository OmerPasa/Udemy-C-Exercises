using System.Diagnostics;
using System.Globalization;
using Gpt4All;

namespace hello_world
{
    public class Program
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
                            Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
                        }
                }
            }
            */
            /////////////////////////////////////////////////////////////////////////////////
            //Write a program and ask the user to enter their name. Use an array to reverse the name and
            //then store the result in a new string. Display the reversed name on the console.
            /*
            var name = Console.ReadLine();     
            
            char[] charArr = name.ToCharArray();      //string to char
            
            Array.Reverse(charArr);
            
            name = new string(charArr);              //char array to string
            
            Console.WriteLine("Reversed :" + name);
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

            /*
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
                int[] Liste = Array.ConvertAll(charArr, c => (int)Char.GetNumericValue(c));
                List<int> List = new List<int>(Liste);
                int i = 0;
                int small = 0;
                //integer array declaration
                int[] arr = new int[5];

                //mine was different after this This more readable :)

                var Smalls = new List<int>();

                while (Smalls.Count < 3)
                {
                    //assign fist element to the 'small' 
                    //compare it with other array elements
                    small = List[0];
                    foreach (var number in List)
                    {
                        if (small > List[i])
                            small = List[i];
                    }
                    Smalls.Add(small);
                    List.Remove(small);
                }
                Smalls.Sort();
                foreach (var item in Smalls)
                {
                    Console.WriteLine("3 smallest numbers : " + item);
                }

            }
            else
            {
                Console.WriteLine("please enter 5 numbers and in 1 digits please. Also not empty please.");
            }
        }
        */
            ////////////////////////////////////////////////////////////////////////////////////////
            ///Mine works differantly soo I want to preserve it  
            /*
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
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////7
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////7
            ///7/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //STRİNGS AND  STRİNGBUİLDER PART OF THE EXERCİSES
            //
            //string to tl format
            /*
            string para = String.Format("{0:C2}", 45.50);
            Console.WriteLine(para);
            */
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Write a program and ask the user to enter a few numbers separated by a hyphen.
            //Work out if the numbers are consecutive.
            //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive";
            //otherwise, display "Not Consecutive".
            /*
            string Input;
            Console.WriteLine(" \n Your numbers are : " + ConsequetivityChecker(Input = Console.ReadLine()));
            */
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////7
            ///// Write a program and ask the user to enter a few numbers separated by a hyphen.
            ///If the user simply presses Enter, without supplying an input, exit immediately; 
            ///otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console
            /*
            string input;
            Console.WriteLine(" \n Your numbers are : " + DuplicateChecker(input = Console.ReadLine()));
            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
            ///A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; 
            ///otherwise, display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.
            /*
            Console.WriteLine("please input as 00:00 type .");
            string text;
            Console.WriteLine("Your given string is : " + HourCorrectness(text = Console.ReadLine()));
            */

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///Write a program and ask the user to enter a few words separated by a space.
            ///Use the words to create a variable name with PascalCase. 
            ///For example, if the user types: "number of students", display "NumberOfStudents". 
            ///Make sure that the program is not dependent on the input. 
            ///So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
            ///
            ///takee input, make all of them lower case,  make evey word an array element then uppercase first char.

            /*

            string firstLetterOfEachWord;
            Console.WriteLine("FirstLetterOfEach word : " + PascalCase_er(firstLetterOfEachWord = Console.ReadLine()));
            */
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///Write a program and ask the user to enter an English word.
            ///Count the number of vowels (a, e, o, u, i) in the word.
            ///So, if the user enters "inadequate", the program should display 6 on the console.
            ///
            /*
            string input;
            Console.WriteLine(CountSesliHarf(input = Console.ReadLine()));
            */

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///File RELATED CODES
            /// Just for try
            /*
            var files = Directory.GetFiles(@"D:\Belgelerim\Other documents for the your life force comander", "*.*" , SearchOption.AllDirectories);
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
            */

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///Write a program that reads a text file and displays the number of words.
            /*
            int wordCount;
            string whole_text = File.ReadAllText(@"D:\YOUTUBE VİDEOS/NOTLAR.txt");
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            wordCount = whole_text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;

            Console.WriteLine("here is your word count: " + wordCount);
            */
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// Write a program that reads a text file and displays the longest word in the file.
            /*
            string whole_text = File.ReadAllText(@"D:\YOUTUBE VİDEOS/NOTLAR.txt");
            var words = new List<string>(whole_text.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries));

            Console.WriteLine(words.Count);
            if (words.Count > 0)
            {
                int longestIndex = 1;
                string longestWord = words[0];

                for (int i = 0; i < words.Count; i++)
                {
                    string item = words[i];
                    if (item.Length > longestWord.Length)
                    {
                        longestWord = item;
                        longestIndex = i + 1;
                    }
                }
                Console.WriteLine("Longest Word: {0}\nFound at Position {1}", longestWord, longestIndex);
            }
            */
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////77
            ///Exercise 1: Design a Stopwatch,provide two methods: Start and Stop.We call the start method first, and the stop method next. 
            ///Duration should be a value in TimeSpan.  
            ///Display the duration on the console.
            ///We should also be able to use a stopwatch multiple times.So we may start and stop it and then
            ///start and stop it again. Make sure the duration value each time is calculated properly.
            ///We should not be able to start a stopwatch twice in a row (because that may overwrite the initial start time).
            ///So the class should throw an InvalidOperationException if its started twice.
            ///make stop and start a seperate method.
            /*
            bool exit = false;
            DateTime start = default, stop = default;
            string testString = "Test";
            bool running = false;

            while (!exit)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "start" && !running)
                {
                    running = true;
                    start = DateTime.Now;
                    Console.WriteLine(start);
                }
                else if (input.ToLower() == "stop")
                {
                    running = false;
                    stop = DateTime.Now;
                    Console.WriteLine(stop);
                    var duration = start - stop;
                    Console.WriteLine(duration);
                }
                else if (input.ToLower() == "exit")
                {
                    exit = true;
                }
                else if (input.ToLower() == "start" && running)
                {
                    throw new InvalidOperationException("You shouldn't start twice.");
                }
            }
                

            /// I will try same thing with methods usign get set properties  
            /// first try  was a bit in need of ref so we change ways


            var Watch = new Watch();
            bool exit = false;
            bool running = false;

            while (!exit)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "start" && !running)
                {
                    running = true;
                    Watch.SetTimerStart();

                }
                else if (input.ToLower() == "stop")
                {
                    running = false;
                    Watch.SetTimerEnd();
                }
                else if (input.ToLower() == "exit")
                {
                    exit = true;
                }
                else if (input.ToLower() == "start" && running)
                {
                    throw new InvalidOperationException("You shouldn't start twice.");
                }
            }

            */

            //////////////////////////////////////////////////////////////////////////////////////////////////////
            ///Design a class called Post. This class models a StackOverflow post. It should have properties for title, 
            ///description and the date / time it was created.We should be able to up - vote or down - vote a post.
            ///We should also be able to see the current vote value.In the main method, create a post,up - vote and down - vote 
            ///it a few times and then display the the current vote value. 
            ///In this exercise, you will learn that a StackOverflow post should provide methods for up - voting and down - voting.
            ///You should not give the ability to set the Vote property from the outside, because otherwise, you may accidentally change the votes 
            ///of a class to 0 or to a random number.And this is how we create bugs in our programs. 
            ///The class should always protect its state and hide its implementation detail.

            //Post 
            ///rate 2dislikes   0 likes
            ///to vote up write like  or dislike to dislike
            ///title 
            ///description
            ///
            ///all of those should be from methods.
            /*
            var StackOverFlowPost = new StackOverFlowPost();
            bool exit = false;
            while (!exit)
            {
                var input = Console.ReadLine();

                if (input.ToLower() == "dislike")
                {
                    StackOverFlowPost.Dislike();
                }
                else if (input.ToLower() == "like")
                {
                    StackOverFlowPost.Like();
                }
                else if (input.ToLower() == "post")
                {
                    StackOverFlowPost.Post();
                }
                else if (input.ToLower() == "exit")
                {
                    exit = true;
                }

            }
            */
            //////////////////////////////////////////////////////////////////////////////////////////////
            ///design a stack that takes numbers and stacks them to a stack and play with them .
            ///pop them clear them check whether null values entered or not
            /*
            var Stack = new Stackk();
            Stack.Stack_items(10);
            bool exit = false;
            Console.WriteLine("Please just write what you want to push . input numbers .(pop) to pop ,(clear) to clear ,(print) to print the stack, (test) to test the code,(exit) to exit the application ");
            while (!exit)
            {
                try
                {
                    var input = Console.ReadLine();
                    if (input == null || input == "0" || input == "" || input == " ")
                    {
                        throw new InvalidOperationException();
                    }
                    else if (input.ToLower() == "pop")
                    {
                        Stack.Pop();
                    }
                    else if (input.ToLower() == "clear")
                    {
                        Stack.Clear();
                    }
                    else if (input.ToLower() == "printstack" || input.ToLower() == "print")
                    {
                        Stack.printStack();
                    }
                    else if (input.ToLower() == "test")
                    {
                        Stack.Push(1);
                        Stack.Push(2);
                        Stack.Push(3);
                        Console.WriteLine(Stack.Pop());
                        Console.WriteLine(Stack.Pop());
                        Console.WriteLine(Stack.Pop());
                    }
                    else if (input.ToLower() == "exit")
                    {
                        exit = true;
                    }
                    else
                    {
                        Stack.Push(input);
                    }
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("please don't insert null values!");
                    continue;
                }
            }
            */
            //////////////////////////////////////////////////////////////////////////////////////////////
            ///desgin a dbconnection between classes and over ride the methods. Using Abstract classes.
            //
            /*
            bool exit = false;
            string ConnectionString =default;
            TimeSpan Timeout = default;
            Console.WriteLine("Please just write what you want to connect , ex. sqlconnect / azureconnect . ");
            while (!exit)
            {
                try
                {
                    var input = Console.ReadLine();
                    if (input == null || input == "0" || input == "" || input == " ")
                    {
                        throw new InvalidOperationException();
                    }
                    else if (input.ToLower() == "sqlconnect")
                    {
                        Sqlconnect sqlconnect = new Sqlconnect(ConnectionString, Timeout);
                        sqlconnect.ServerOpen(input, TimeSpan.FromSeconds(15));

                    }
                    else if (input.ToLower() == "azureconnect")
                    {
                        Azureconnect azureconnect = new Azureconnect(ConnectionString, Timeout);
                        azureconnect.ServerOpen(input, TimeSpan.FromSeconds(15));
                    }
                    else if (input.ToLower() == "exit")
                    {
                        exit = true;
                    }
                    else
                    {
                        // add a timer?
                    }
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("please don't insert null values!");
                    continue;
                }
            }
            */

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*


            Workflow workflow = new Workflow(new List<IActivity>());
            workflow.Activities.Add(new Videouploader());
            workflow.Activities.Add(new DataBase());
            workflow.Activities.Add(new Webservice());
            WorkflowEngine.Run(workflow);
            Console.ReadLine();
            */

            // load the model
            var modelFactory = new ModelFactory();

            using var model = modelFactory.LoadModel("./path/to/ggml-gpt4all-j-v1.3-groovy.bin");

            var input = "Name 3 Colors";

            // request a prediction
            var result = await model.GetStreamingPredictionAsync(
                input,
                PredictRequestOptions.Defaults);

            // asynchronously print the tokens as soon as they are produces by the model
            await foreach (var token in result.GetPredictionStreamingAsync())
            {
                Console.Write(token);
            }



        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //THE METHODS RELATED TO THOSE UPWARDS.
        public static void DislikeClicked()
        {

        }

        public static string WriteThePost(string dislike, string like, string title, string description)
        {
            return dislike;
        }
        public static string ConsequetivityChecker(string Input)
        {
            bool isConsecutive = false;
            bool isAssemding = false;
            bool isDesending = false;


            var charsToRemove = new string[] { "@", ",", ".", ";", "'", " " };

            Console.WriteLine("Please enter number separated with (,) :");


            foreach (var c in charsToRemove)// these will remove ","
            {
                Input = Input.Replace(c, string.Empty);
            }



            if (!string.IsNullOrWhiteSpace(Input))
            {

                var Lenght = Input.Length;
                for (int i = 0; i < Lenght / 2; i++)// i yi arttırarak başta 1 i sonra 12 yi baz alıyor.
                {


                    // new String containing the starting
                    // substring of input String
                    String new_str = Input.Substring(0, i + 1);

                    // converting starting substring into number
                    int num = int.Parse(new_str);


                    // while loop until the new_String is
                    // smaller than input String
                    while (new_str.Length < Lenght)
                    {

                        // next number
                        num++;

                        // concatenate the next number
                        new_str = new_str + String.Join("", num);
                    }


                    // check if new String becomes equal to
                    // input String
                    if (new_str.Equals(Input))
                    {
                        return "IS Consequetive: " + Input + " ," + new_str;
                        isAssemding = true;
                    }
                }

                Lenght = Input.Length;
                for (int i = 0; i < Lenght / 2; i++)// i yi arttırarak başta 1 i sonra 12 yi baz alıyor.
                {


                    // new String containing the starting
                    // substring of input String
                    String new_str = Input.Substring(0, i + 1);

                    // converting starting substring into number
                    int num = int.Parse(new_str);


                    // while loop until the new_String is
                    // smaller than input String
                    while (new_str.Length < Lenght)
                    {

                        // next number
                        num--;
                        // concatenate the next number
                        new_str = new_str + String.Join("", num);
                    }


                    // check if new String becomes equal to
                    // input String
                    if (new_str.Equals(Input))
                    {
                        return "IS Consequetive: " + Input;
                        isDesending = true;

                    }
                    else
                        return "NOT Consequetive: " + Input + " ," + new_str;
                    isConsecutive = false;

                }
                if (isAssemding || isDesending)
                {
                    return "LastResult : TRUE";
                }
                else
                {
                    return "LastResult : False";
                }

            }
            return "It is emtyp sir";
        }
        // These are exercise for interface activity.
        public interface IActivity
        {
            void Execute();
        }

        public class Videouploader : IActivity
        {
            public void Execute()
            {
                Console.WriteLine("please 'nsert a v'deo to the app ");
                Console.WriteLine("uploading video...");
            }
        }

        public class Webservice : IActivity
        {
            public void Execute()
            {
                Console.WriteLine("Video Encoding Started...");
                Console.WriteLine("Videouploading sent to your mail.");
            }
        }

        public class DataBase : IActivity
        {
            public void Execute()
            {
                Console.WriteLine("Process'ng status (uploading)");
            }
        }
        public class Workflow
        {
            public List<IActivity> Activities { get; }

            public Workflow(List<IActivity> activities)
            {
                Activities = activities;
            }
        }


        public class WorkflowEngine
        {
            public static void Run(Workflow workflow)
            {
                foreach (var activity in workflow.Activities)
                {
                    if (activity == null)
                        throw new ArgumentException("Activities cannot be null.");

                    activity.Execute();
                }
            }
        }
        public static string DuplicateChecker(string input)
        {
            var charsToRemove = new string[] { "@", ",", ".", ";", "'", " " };

            Console.WriteLine("Please insert numbers. we gonna show duplicate numbers , if you press (enter) algorithm gonna quit application.");

            if (string.IsNullOrWhiteSpace(input))
            {
                return "understood Quitting initiated...";
            }
            else
            {
                foreach (var c in charsToRemove)// these will remove ","
                {
                    input = input.Replace(c, string.Empty);
                }

                if (input.Distinct().Count() == input.Length)
                {
                    return "CLEAR";
                }
                else
                    return "Duplicate exists!";
            }
        }

        public static string HourCorrectness(string text)
        {
            CultureInfo invariant = System.Globalization.CultureInfo.InvariantCulture;
            DateTime dt;
            if (DateTime.TryParseExact(text, "HH:mm", invariant, DateTimeStyles.None, out dt))
            {
                return "Valid";
            }
            else
            {
                // handle the fact you cannot parse the datetime
                return "Invalid";
            }
        }

        public static string PascalCase_er(string firstLetterOfEachWord)
        {
            var LowCase = firstLetterOfEachWord.ToLower();
            firstLetterOfEachWord =
                    string.Join(" ", LowCase.Split(' ').ToList()
                            .ConvertAll(word =>
                                    word.Substring(0, 1).ToUpper() + word.Substring(1)
                            )
                    ).Replace(" ", "");
            return firstLetterOfEachWord;
        }

        public static string CountSesliHarf(string input)
        {
            string[] sesliler = { "a", "e", "o", "u", "i" };
            var charSesliler = sesliler.SelectMany(x => x.ToCharArray());
            int Count = 0;
            foreach (var ses in charSesliler)
            {
                Count += input.Count(f => (f == ses));
            }
            input = Convert.ToString(Count);
            return input;

        }


        /// <summary>
        /// NEW CLASSES
        /// </summary>

        public abstract class Dbconnection
        {
            public abstract void ServerOpen(string ServerKey, TimeSpan timeout);
            public abstract void ServerClose();

            string ConnectionString;
            TimeSpan Timeout;

            public Dbconnection(string connectionString, TimeSpan timeout)
            {
                ConnectionString = connectionString;
                Timeout = timeout;

            }


            public class Sqlconnect : Dbconnection
            {

                public Sqlconnect(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
                {

                }

                public override void ServerOpen(string ServerKey, TimeSpan timeout)
                {
                    Console.WriteLine("enterence key is " + ServerKey);
                    Console.WriteLine("SQL Connection Starting...");
                    Console.WriteLine("Server connection successfull.. starting timer");
                    Stopwatch sw = Stopwatch.StartNew();

                    while (sw.Elapsed < timeout)
                    {
                        timeout = timeout.Subtract(TimeSpan.FromSeconds(1));
                        Console.WriteLine("Server Running");
                    }
                    Console.WriteLine("timeout");
                    Sqlconnect sqlconnect = new Sqlconnect(ConnectionString, timeout);
                    sqlconnect.ServerClose();
                }

                public override void ServerClose()
                {
                    Console.WriteLine("Server Connection closing...");
                }

            }

            public class Azureconnect : Dbconnection
            {
                public Azureconnect(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
                {
                }

                public override void ServerOpen(string ServerKey, TimeSpan timeout)
                {
                    Console.WriteLine("enterence key is " + ServerKey);
                    Console.WriteLine("SQL Connection Starting...");
                    Console.WriteLine("Server connection successfull.. starting timer");
                    Stopwatch sw = Stopwatch.StartNew();

                    while (sw.Elapsed < timeout)
                    {
                        timeout = timeout.Subtract(TimeSpan.FromSeconds(1));
                        Console.WriteLine("Server Running");
                    }
                    Console.WriteLine("timeout");
                    Azureconnect azureconnect = new Azureconnect(ConnectionString, timeout);
                    azureconnect.ServerClose();
                }

                public override void ServerClose()
                {
                    Console.WriteLine("Server Connection closing...");
                }
            }








        }






        public class Watch
        {
            private DateTime _timerStart;
            private DateTime _timerEnd;

            public DateTime SetTimerStart()
            {
                _timerStart = DateTime.Now;
                Console.WriteLine(_timerStart);
                return _timerStart;
            }
            public TimeSpan SetTimerEnd()
            {
                _timerEnd = DateTime.Now;
                var duration = _timerEnd - _timerStart;
                Console.WriteLine(_timerEnd);
                Console.WriteLine("Total duration : " + duration);
                return duration;
            }
        }
        public class StackOverFlowPost
        {
            private int _likes { get; set; }

            public int Dislike()
            {
                _likes -= 1;
                return _likes;
            }
            public int Like()
            {
                _likes += 1;
                return _likes;
            }
            public int Post()
            {
                Console.WriteLine("Rates  Total Like&Dislike Ratio  " + _likes);
                Console.WriteLine("\n  Title : wefaofıwjfeaoıfejweı \n Description :awoıefajwoefıjf");
                return _likes;
            }
        }


        public class Stackk
        {
            private object[] ele;
            private int top;
            private int max;

            public void Stack_items(int size)
            {
                ele = new object[size]; // Maximum size of Stack
                top = -1;
                max = size;
            }
            /// <summary>
            /// The Push() method stores the given object on top of the stack. 
            /// We use the “object” type here so 
            // we can store any objects inside the stack .Remember the “object” class is the base of all classes 
            //in the.NET Framework.So any types can be automatically upcast to the object. Make sure to
            //take into account the scenario that null is passed to this object. We should not store null 
            //references in the stack. So if null is passed to this method, you should throw an
            //InvalidOperationException. 
            /// </summary>
            public void Push(object item)
            {
                if (top == max - 1)
                {
                    Console.WriteLine("Stack Overflow");
                    return;
                }
                else
                {
                    ele[++top] = item;
                }
            }


            /// <summary>
            /// The Pop() method removes the object on top of the stack and returns it. 
            /// Make sure to take into account the scenario that we call the Pop() method on an empty stack. 
            /// In this case, this method should throw an InvalidOperationException. 
            /// </summary>
            /// <returns></returns>
            public object Pop()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is Empty");
                    return -1;
                }
                else
                {
                    Console.WriteLine("{0} popped from stack ", ele[top]);
                    return ele[top--];
                }
            }

            /// <summary>
            /// The Clear() method removes all objects from the stack.
            /// </summary>
            public void Clear()
            {
                Array.Clear(ele);
            }


            public void printStack()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is Empty");
                    return;
                }
                else// may be unnecesrayy 
                {
                    for (int i = 0; i <= top; i++)
                    {
                        Console.WriteLine("{0} pushed into stack", ele[i]);
                    }
                }
            }
        }
    }
}