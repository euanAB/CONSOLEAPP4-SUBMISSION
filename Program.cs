using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to YourSocialApp");
        Console.WriteLine("Let's get started, login below to acsess the platform.");


        Console.WriteLine("Who's this? Enter your username:");
        string userName = Console.ReadLine();

        List<string> messagePosts = new List<string>();
        List<string> picturePosts = new List<string>();
        List<string> likedPosts = new List<string>();

        int menuChoice;
        do
        {
            Console.WriteLine("1) To post a tweet or status update.");
            Console.WriteLine("2) Upload an image to your friends.");
            Console.WriteLine("3) Show your social feed");
            Console.WriteLine("4) Like a post");
            Console.WriteLine("5) Remove a post");
            Console.WriteLine("6) Exit YSA");

            Console.WriteLine("What would you like to do, select an option: ");
            menuChoice = Convert.ToInt32(Console.ReadLine());

            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("Type your post or update below. Tell the world here:");
                    string message = Console.ReadLine();
                    string postMessage = userName + " has posted: " + message;
                    messagePosts.Add(postMessage);
                    Console.WriteLine(postMessage);
                    break;

                case 2:
                    Console.WriteLine("Paste the link of your image below:");
                    string pictureUrl = Console.ReadLine();
                    string postPicture = userName + " has uploaded a new post, see it now...: " + pictureUrl;
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
                        Console.WriteLine("oops... All quite here. No posts available.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Which post do you want to like? Enter the post:");
                    string likePost = Console.ReadLine();
                    likedPosts.Add(likePost);
                    Console.WriteLine("You have liked the post!");
                    break;

                case 5:
                    Console.WriteLine("Which post do you want to remove? Enter the post:");
                    string removePost = Console.ReadLine();
                    messagePosts.Remove(removePost);
                    picturePosts.Remove(removePost);
                    Console.WriteLine("You have successfully removed the post!");
                    break;

                case 6:
                    Console.WriteLine("Exit YSA");
                    break;

                default:
                    Console.WriteLine("Oops. Im sorry, thats an invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        } while (menuChoice != 6);

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
.
