using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyButton : MonoBehaviour
{
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    public void OnClickBack(int test)
    {
        Debug.Log(name + " button worked");
    }

    public void OnClickBack(Object test)
    {
        Debug.Log(name + " button worked");
    }
}
