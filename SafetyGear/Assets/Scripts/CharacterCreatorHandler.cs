using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCreatorHandler : MonoBehaviour
{
    [Header("Garment Panels")]
    [SerializeField] ToggleHandler toggleHandler;
    [SerializeField] GameObject hoodPanel;
    [SerializeField] GameObject torsoPanel;
    [SerializeField] GameObject facePanel;
    public GameObject activePanel;
    public string activeToggle;


    void Start()
    {
        InitializePanels();
    }


    void Update()
    {
        UpdatePanel();
    }

    public void UpdatePanel()
    {
        activeToggle = toggleHandler.GetActiveToggle();

        if (activeToggle == "hood")
        {
            ActiveNewPanel(hoodPanel);

        }
        else if (activeToggle == "torso")
        {
            ActiveNewPanel(torsoPanel);
        }
        else if (activeToggle == "face")
        {
            ActiveNewPanel(facePanel);
        }
    }

    private void ActiveNewPanel(GameObject panel)
    {
        activePanel.SetActive(false);
        activePanel = panel;
        activePanel.SetActive(true);
    }

    private void InitializePanels()
    {
        hoodPanel.SetActive(false);
        torsoPanel.SetActive(false);
        facePanel.SetActive(false);
        activePanel = facePanel;
        activePanel.SetActive(true);
    }
    

}
