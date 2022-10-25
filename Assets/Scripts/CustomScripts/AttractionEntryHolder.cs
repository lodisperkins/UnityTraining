using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MuseumApp;

public class AttractionEntryHolder : MonoBehaviour
{
    public Transform scrollContentWindow;

    public List<AttractionConfig> configs;
    public GameObject attractionEntryHolderPrefab;


    // Start is called before the first frame update
    void Start()
    {
        foreach (AttractionConfig config in configs)
        {
            GameObject attractionEntry = Instantiate(attractionEntryHolderPrefab, scrollContentWindow);
            attractionEntry.GetComponent<AttractionEntryInitializer>().Initialize(config);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
