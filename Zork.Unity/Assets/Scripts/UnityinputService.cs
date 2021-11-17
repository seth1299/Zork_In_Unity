
using UnityEngine;
using TMPro;
using System;
using Zork.Common;

public class UnityInputService : MonoBehaviour, IInputService
    
{
    [SerializeField]
    private TMP_InputField InputField;

    public event EventHandler<string> InputReceived;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {

        }
    }
}
