using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("----------------- Luke's Social Network -----------------");
        Console.WriteLine("-----------------  Student ID 22206266 ------------------");
        Console.WriteLine("-------------- Buckinghamshire University --------------");
        Console.WriteLine("---------------------------------------------------------");

        Console.WriteLine("Hello, please type in your username:");
        string userName = Console.ReadLine();

        List<string> messagePosts = new List<string>();
        List<string> picturePosts = new List<string>();

        int menuChoice;
        do
        {
            Console.WriteLine("1) To post a message");
            Console.WriteLine("2) To post a picture");
            Console.WriteLine("3) Display all posts");
            Console.WriteLine("4) Exit");

            Console.WriteLine("Please enter what you would like to do: ");
            menuChoice = Convert.ToInt32(Console.ReadLine());

            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("What message would you like to post?");
                    string message = Console.ReadLine();
                    string postMessage = userName + " has posted: " + message;
                    messagePosts.Add(postMessage);
                    Console.WriteLine(postMessage);
                    break;

                case 2:
                    Console.WriteLine("Please paste (CTRL + V) the URL of the picture you would like to post:");
                    string pictureUrl = Console.ReadLine();
                    string postPicture = userName + " has posted a picture: " + pictureUrl;
                    picturePosts.Add(postPicture);
                    Console.WriteLine(postPicture);
                    break;

                case 3:
                    Console.WriteLine("All posts:");
                    foreach (string post in messagePosts)
                    {
                        Console.WriteLine(post);
                    }
                    foreach (string post in picturePosts)
                    {
                        Console.WriteLine(post);
                    }
                    if (messagePosts.Count == 0 && picturePosts.Count == 0)
                    {
                        Console.WriteLine("No posts available.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Exit Program");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        } while (menuChoice != 4);

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
