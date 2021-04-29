using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RatingHandler : MonoBehaviour
{
    [SerializeField] TMP_Text overallRating;
    [SerializeField] OutfitChanger hoodOptions;
    [SerializeField] OutfitChanger faceOptions;
    [SerializeField] OutfitChanger torsoOptions;
    [SerializeField] Button contButton;
    List<GarmentType> garments;
    private int ratingTotal;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ratingTotal = hoodOptions.GetGarments()[hoodOptions.GetActiveOption()].rating + faceOptions.GetGarments()[faceOptions.GetActiveOption()].rating + torsoOptions.GetGarments()[torsoOptions.GetActiveOption()].rating;
        overallRating.text = ratingTotal.ToString();
        if (ratingTotal > 11) { contButton.interactable = true; }
        else { contButton.interactable = false; }
    }

}
