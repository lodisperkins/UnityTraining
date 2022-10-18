using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPopulator : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _UIElements;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _UIElements.Length; i++)
        {
            Instantiate(_UIElements[i], transform);
        }
    }
}
