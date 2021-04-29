using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class OutfitChanger : MonoBehaviour
{
    // Creates reference to Sprite Renderer component
    [Header("Sprite To Change")]
    public SpriteRenderer bodyPart;

    // Simple Image Display of Applied Gear Seperate from the Player
    public Image displayImage;

    // Creates new list populated with sprites
    [Header("Sprites To Cycle Through")]
    public List<Sprite> options = new List<Sprite>();

    [Header("Display Changers")]
    [SerializeField] TMP_Text objectTitle;
    [SerializeField] TMP_Text objectDescription;
    [SerializeField] TMP_Text objectRating;

    // Creates new private variable for tracking position in array
    private int currentOption = 0;

    public int garmentArraySize = 5;


    // Creates new instances of GarmentType class with two attributes
    // Number of attributes is currently hard coded which probably isn't ideal. Sorry!
    public List<GarmentType> garments = new List<GarmentType>();

    public void Start()
    {
        displayImage.sprite = options[currentOption];
        objectTitle.text = garments[currentOption].garmentTitle;
        objectDescription.text = garments[currentOption].garmentDescription;
        objectRating.text = garments[currentOption].rating.ToString();
        CheckForNullImage();

    }

    public void NextOption()
    {
        currentOption++;
        // Resets to top of list after cycling through all options
        if (currentOption >= options.Count)
        {
            currentOption = 0;
        }

        // Displayed sprite corresponds to index value
        bodyPart.sprite = options[currentOption];
        displayImage.sprite = options[currentOption];
        objectTitle.text = garments[currentOption].garmentTitle;
        objectDescription.text = garments[currentOption].garmentDescription;
        objectRating.text = garments[currentOption].rating.ToString();

        CheckForNullImage();

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
        displayImage.sprite = options[currentOption];
        objectTitle.text = garments[currentOption].garmentTitle;
        objectDescription.text = garments[currentOption].garmentDescription;
        objectRating.text = garments[currentOption].rating.ToString();

        CheckForNullImage();
    }

    public void CheckForNullImage()
    {
        if (currentOption == 5 && options[5] == null)
        {
            var tempColor = displayImage.color;
            tempColor.a = 0f;
            displayImage.color = tempColor;
        }
        else
        {
            var tempColor = displayImage.color;
            tempColor.a = 1f;
            displayImage.color = tempColor;
        }
    }

    public List<GarmentType> GetGarments()
    {
        return garments;
    }

    public int GetActiveOption()
    {
        return currentOption;
    }

}
