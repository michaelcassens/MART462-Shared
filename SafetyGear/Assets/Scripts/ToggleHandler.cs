using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToggleHandler : MonoBehaviour
{

    [Header("Toggles")]
    [SerializeField] Toggle isHood;
    [SerializeField] Toggle isTorso;
    [SerializeField] Toggle isFace;

    [Header("Toggle Current State")]
    public string activeToggle;

    [Header("Update Fields")]
    [SerializeField] TMP_Text garmentText;


    void Start()
    {
        activeToggle = "face";
    }

    
    void Update()
    {
        DetermineActiveToggle();
    }


    public void DetermineActiveToggle()
    {
        if (isHood.isOn)
        {
            activeToggle = "hood";
            garmentText.text = "Hood";
        }
        else if (isTorso.isOn)
        {
            activeToggle = "torso";
            garmentText.text = "Torso";
        }
        else if (isFace.isOn)
        {
            activeToggle = "face";
            garmentText.text = "Face";
        }
    }

    public string GetActiveToggle()
    {
        return activeToggle;
    }
}
