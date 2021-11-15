
using UnityEngine;
using TMPro;
using Zork;
using Newtonsoft.Json;

public class UnityinputService : MonoBehaviour, IInputService
    
{
    [SerializeField]
    private TMP_InputField InputField;

    public event EventHandler<string> InputReceived;



private void update()
    {
        if (Input.GetKey(KeyCode.Return))






    }


}
