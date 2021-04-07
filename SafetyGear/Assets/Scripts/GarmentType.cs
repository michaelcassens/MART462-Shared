using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GarmentType
{
    //public string garmentType;
    public string garmentTitle;
    public string garmentDescription;
    //public Sprite spritePreview;
    
    public GarmentType(string title, string description)
    {
        //this.garmentType = type;
        this.garmentTitle = title;
        this.garmentDescription = description;
        //this.spritePreview = spriteImg;
    }
}
