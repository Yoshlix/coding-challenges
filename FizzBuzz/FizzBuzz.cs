﻿using System.Collections;

namespace FizzBuzz;

public static class FizzBuzzChallenge
{
    [Fact]
    public static void FizzTest()
    {
        Assert.Equal(["1", "2", "Fizz"], FizzBuzz(3));
    }

    [Fact]
    public static void FizzBuzzSuccess()
    {
        Assert.Equal(["1", "2", "Fizz", "4", "Buzz"], FizzBuzz(5));
    }

    [Fact]
    public static void FizzBuzzFail()
    {
        Assert.NotEqual(
            ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "Fizz", "14", "FizzBuzz"],
            FizzBuzz(15));
    }

    private static ArrayList FizzBuzz(int input)
    {
        var i = 0;
        var inputArray = new ArrayList();
        var outputArray = new ArrayList();

        while (i != input)
        {
            i++;
            inputArray.Add(i.ToString());
        }

        foreach (string number in inputArray)
            switch (int.Parse(number) % 3)
            {
                case 0 when int.Parse(number) % 5 == 0:
                    outputArray.Add("FizzBuzz");
                    break;
                case 0:
                    outputArray.Add("Fizz");
                    break;
                default:
                {
                    outputArray.Add(int.Parse(number) % 5 == 0 ? "Buzz" : number);

                    break;
                }
            }

        return outputArray;
    }
}