﻿namespace _12_6_24;

internal class Student
{
    private static int _id;
    public int Id { get; }
    public string FullName { get; set; }
    public int Point { get; set; }

    public Student(string fullName, int point)
    {
        Id = ++_id;
        FullName = fullName;
        Point = point;
    }

    public void StudentInfo()
    {
        Console.WriteLine($"{Id}-{FullName}-{Point}");
    }
}
