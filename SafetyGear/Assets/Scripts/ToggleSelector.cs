using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleSelector : MonoBehaviour
{
    // Garment Selector References
    public OutfitChanger _outfitChanger;

    // Toggle Game Objects
    public Toggle isHood;
    public Toggle isTorso;
    public Toggle isFace;

    /*public void Start()
    {
        GameObject _outfitChanger = GameObject.FindWithTag("GetHood");

        _outfitChanger.GetComponent<OutfitChanger>().enabled = false;

        if (_outfitChanger == null)
          {
              Debug.Log("Nada");
          }  else if(_outfitChanger != null)
          {
              Debug.Log(_outfitChanger.ToString());
          }



        GameObject.FindWithTag("HoodSelector").GetComponent<OutfitChanger>().enabled = false;
    }*/

    // Checks for Active Toggle
    public void ActiveToggle()
    {
        if(isHood.isOn)
        {
            Debug.Log("Player Selected Hood");
        } else if(isTorso.isOn)
        {
            Debug.Log("Player Selected Torso");
        } else if(isFace.isOn)
        {
            Debug.Log("Player Selected Face");
        }
    }

    // Tests whether Active Toggle function is Working How I Want
    public void OnSubmit()
    {
        Debug.Log("Selecting Garment...");

        ActiveToggle();
    }
}
