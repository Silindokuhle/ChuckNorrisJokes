﻿using ChuckNorrisJokesLibrary;
using System;
using System.Threading.Tasks;

namespace ChuckNorrisJokes
{
    class Program
    {
        static async Task Main(string[] args)
        {
            JokeGenerator jokeGenerator = new JokeGenerator();
            //string randomJoke = await jokeGenerator.GetRandomJoke();

            //Console.WriteLine(randomJoke);

            string[] categories = await jokeGenerator.GetCategories();
            for (int index = 0; index < categories.Length; index++)

             Console.WriteLine(categories[index]);
           // Console.WriteLine("Hello World!");

        }
    }
}
