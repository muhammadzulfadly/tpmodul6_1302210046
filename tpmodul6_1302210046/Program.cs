// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title) {
        Contract.Requires(title != null && title.Length <= 100);
        Contract.Requires(playCount <= 10000000);

        this.id = new Random().Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count) {
        try {
            checked {
                this.playCount += count;
            }
        }
        catch (OverflowException check) {
            Console.WriteLine(check.Message);
        }
    }

    public void PrintVideoDetails() {
        Console.WriteLine("ID: " + id + "\nTitle: " + title + "\nplayCount: " + playCount);
    }
}

class Program {
    static void Main(string[] args) {

        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Muhammad Zulfadly");
        video.IncreasePlayCount(500);
        video.PrintVideoDetails();
        Console.WriteLine("");

        for(int i = 1; i < 10000000; i++) {
            video.IncreasePlayCount(1);
        }
        video.PrintVideoDetails();
    }
}