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

    // Creates new variable meant to reference the HoodToggle game object
    public GameObject hoodToggleRef;

    // Creates new instances of GarmentType class with two attributes
    // Number of attributes is currently hard coded which probably isn't ideal. Sorry!
    public GarmentType[] garments = new GarmentType[2];

    public void Start()
    {
        hoodToggleRef = GameObject.FindWithTag("HoodToggleTag");
        
        //garments[0] = new GarmentType("Hood", "This hood covers the head.");

    }

    public void Update()
    {
        //Debug.Log(toggleScriptRef.GetComponent<ToggleSelector>().isHood.isOn);
        //Debug.Log(toggleScriptRef.GetComponent<ToggleSelector>().isFace.isOn);
        //Debug.Log(toggleScriptRef.GetComponent<ToggleSelector>().isTorso.isOn);
    }

    public void NextOption()
    {
        // If statement does not currently work as intended
        // Ideally it would only allow the hood to change appearance if hood togle is on
        if(hoodToggleRef == true)
        {
        currentOption++;
        // Resets to top of list after cycling through all options
        if (currentOption >= options.Count)
        {
            currentOption = 0;
        }

        // Displayed sprite corresponds to index value
        bodyPart.sprite = options[currentOption];
        }

    }

    // Inverse of previous method
    public void PreviousOption()
    {
        currentOption--;
        if (currentOption <= 0)
        {
            currentOption = options.Count - 1;
        }

        bodyPart.sprite = options[currentOption];
    }

}
