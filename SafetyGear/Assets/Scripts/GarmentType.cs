using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GarmentType
{
    public string garmentTitle;
    public string garmentDescription;
    public int rating;
    
    public GarmentType(string title, string description, int rating)
    {
        this.garmentTitle = title;
        this.garmentDescription = description;
        this.rating = rating;
    }
}
