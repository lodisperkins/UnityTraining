using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.IO;

public class LoginSubmitButton : MonoBehaviour
{
    public TextMeshProUGUI userNameValue;
    public UserData userData = new UserData();

    private void Start()
    {
        if (!File.Exists(Application.persistentDataPath + "/userName.txt"))
            return;

        StreamReader reader = new StreamReader(Application.persistentDataPath + "/userName.txt");
        string json = reader.ReadToEnd();

        userData.username = JsonUtility.FromJson<string>(json);

        userNameValue.text = userData.username;

        reader.Close();
    }

    public void OnSubmitClicked()
    {
        userData.username = userNameValue.text;
        string json = JsonUtility.ToJson(userData);
        StreamWriter writer = new StreamWriter(Application.persistentDataPath + "/userName.txt");
        writer.WriteLine(json);
        writer.Close();
    }
}

[Serializable]
public class UserData
{
    public string username;
}
