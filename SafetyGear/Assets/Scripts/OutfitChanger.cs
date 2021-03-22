using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChanger : MonoBehaviour
{
    // Creates reference to Sprite Renderer component
    [Header("Sprite To Change")]
    public SpriteRenderer bodyPart;

    // Creates new list populated with sprites
    [Header("Sprites To Cycle Through")]
    public List<Sprite> options = new List<Sprite>();

    // Creates new private variable for tracking position in array
    private int currentOption = 0;

    public GameObject hoodToggleScriptRef;
    
    public void Start()
    {
        hoodToggleScriptRef = GameObject.FindWithTag("GetHood");
    }

    public void NextOption()
    {
        /*if(hoodToggleScriptRef.GetComponent<ToggleSelector>().enabled == true)
        {*/
            currentOption++;
            // Resets to top of list after cycling through all options
            if (currentOption >= options.Count)
            {
                currentOption = 0;
            }

            // Displayed sprite corresponds to index value
            bodyPart.sprite = options[currentOption];
        //}
            
    }

    // Inverse of previous method
    public void PreviousOption()
    {
        currentOption--;
        if(currentOption <= 0)
        {
            currentOption = options.Count - 1;
        }

        bodyPart.sprite = options[currentOption];
    }

}
