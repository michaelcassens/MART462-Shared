using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToggleSelector : MonoBehaviour
{
    // Garment Selector References
    //public OutfitChanger _outfitChanger;
    
    // Text Mesh pro Reference
    public TMP_Text garmentTitle;

    // Toggle Game Objects
    [Header("Toggles")]
    [SerializeField] Toggle isHood;
    [SerializeField] Toggle isTorso;
    [SerializeField] Toggle isFace;

    // Currently Selected Garment Variables
    [Header("Toggle State")]
    private bool activeToggle;
    public GameObject currentActiveGarment;
    public GameObject hoodToggleRef;

    public void Start()
    {
        // Assigns tagged TextMeshPro GameObject to garmentTitle variable. Later used in ActiveToggle method to change text on ride side of screen between previous and next buttons
        garmentTitle = GameObject.FindWithTag("GarmentTypeButtonTag").GetComponent<TMPro.TextMeshProUGUI>();
        // Was hoping to use this variable to prevent right side previous and next buttons from changing multiple garment types at once. It does not work.
        hoodToggleRef = GameObject.FindWithTag("HoodToggleTag");
    }

    // Checks for Active Toggle
    // Changes Text Between Previous and Next Button to Match Currently Selected Toggle
    // Setting variable hoodToggleRef to currentActiveGarment is supposed to then allow multiple garment selectors to share a single set of next/previous buttons. It does not work.
    public void ActiveToggle()
    {
        if(isHood.isOn)
        {
            //Debug.Log("Player Selected Hood");
            hoodToggleRef = currentActiveGarment;
            garmentTitle.text = "Hood";
        } 
        else if(isTorso.isOn)
        {
            //Debug.Log("Player Selected Torso");
            garmentTitle.text = "Torso";
        } 
        else if(isFace.isOn)
        {
            //Debug.Log("Player Selected Face");
            garmentTitle.text = "Face";
        }
    }

    // Tests whether Active Toggle function is working how I want
    public void OnSubmit()
    {
        //Debug.Log("Selecting Garment...");

        ActiveToggle();
    }

    public bool GetActiveToggle()
    {
        return activeToggle;
    }
}
