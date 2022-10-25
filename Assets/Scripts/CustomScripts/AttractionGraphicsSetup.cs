using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AttractionGraphicsSetup : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI authorText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI locationText;

    public Image pieceImage;

    public AttractionConfig config;

    // Start is called before the first frame update
    void Start()
    {
        titleText.text = config.title;
        authorText.text = config.author;
        descriptionText.text = config.description;
        locationText.text = config.location;
        pieceImage.sprite = config.image;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
