using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AttractionConfig", menuName = "ScriptableObjects/AttractionConfig", order = 0)]
public class AttractionConfig : ScriptableObject
{
    public string id;
    public string title;
    public string author;
    [TextArea]
    public string description;
    public string location;

    public Sprite image;

    public Vector2 thumbnailSize;
    public Vector3 thumbnailPosition;

    public Vector2 headerImageSize;
    public Vector3 headerImagePosition;
}
