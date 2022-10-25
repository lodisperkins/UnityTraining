using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AttractionEntryInitializer : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI locationText;

    public Image[] stars;
    public Image pieceImage;


    public Color likeColor;
    public Color dislikeColor;

    public void Initialize(AttractionConfig config)
    {
        titleText.text = config.title;
        locationText.text = config.location;
        pieceImage.sprite = config.image;

        InitializeStars(PlayerPrefs.GetInt(config.id));
    }

    private void InitializeStars(int starNumber)
    {
        for (int i = 0; i < stars.Length; i++)
        {
            if (i < starNumber)
                stars[i].color = likeColor;
            else
                stars[i].color = dislikeColor;
        }
    }
}
