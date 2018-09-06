using System;

namespace twitterPublisher
{
    class Program
    {
        static string ConsumerKey = "oifbgQGhEskpCst9zNjpeYOSX";
        static string ConsumerKeySecret = "vXTBelcV8vNm4TFHXXB4Nd3sB39mBfsYiI1GLVj41s8XHTfbiP";
        static string AccessToken = "1396065818-r7IRN3cnpbdhHs2eblp1twRFKIWaxnufzc4YBHk";
        static string AccessTokenSecret = "QEoTJCxbx0F3YChQuGgKNDJfDLmp8jBqXGM2YuLy2zp08";

        static void Main(string[] args)
        {
            var twitter = new TwitterApi(ConsumerKey, ConsumerKeySecret, AccessToken, AccessTokenSecret);
            twitter.Tweet("This is once again, another tweet").Wait();
            Console.WriteLine("Fin!");
        }
        static void Main1(string[] args)
        {
            //MainAsync(args).Wait();
        }
    }
}
