
using UnityEngine;
using Zork;
public class GameManager : MonoBehaviour
{

    void Awake()
    {
      TextAsset defaultGameFilename = Resources.Load<TextAsset>(ZorkGameFilename);
        Game.Start(defaultGameFilename.text); //refer to 33:16 in part 1


    }


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    [SerializeField]
    private string ZorkGameFilename = "Zork";

}
