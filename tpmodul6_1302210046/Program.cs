// See https://aka.ms/new-console-template for more information
using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title) {
        this.id = new Random().Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count) {
        this.playCount += count;
    }

    public void PrintVideoDetails() {
        Console.WriteLine("id:" + id + "title:" + title + "playCount:" + playCount);
    }
}

class Program {
    static void Main(string[] args) {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Muhammad Zulfadly");
        video.PrintVideoDetails();
    }
}