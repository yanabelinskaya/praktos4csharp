using System;
using System.Collections.Generic;

public class Activity
{
    public string Titles { get; set; }
    public string Descriptions { get; set; }
    public string Locations { get; set; }

    public Activity(string title, string description, string location)
    {
        Titles = title;
        Descriptions = description;
        Locations = location;
    }
}

