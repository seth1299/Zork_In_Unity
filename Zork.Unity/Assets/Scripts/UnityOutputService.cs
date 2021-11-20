
using UnityEngine;
using Zork;
using System;
using Newtonsoft.Json;
using TMPro;
public class UnityOutputService : MonoBehaviour, IOutputService

{
    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public void Write(object value)
    {

    }

    public void Write(string value)
    {
        throw new System.NotImplementedException();
    }

    public void WriteLine(object value)
    {
        OutputText.text = value.ToString();
    }

    public void WriteLine(string value)
    {
        WriteLine(value.ToString());
    }


    [SerializeField]
    private TextMeshProUGUI OutputText;

}