
using UnityEngine;
using Zork;
using Newtonsoft.Json;

public class GameManager : MonoBehaviour
    
{

    [SerializeField]
    private UnityinputService InputService

    [SerializeField]
    private UnityOutputService OutputService;





    void Awake()
    {
      TextAsset defaultGameFilename = Resources.Load<TextAsset>(ZorkGameFilename);
        Game.Start(defaultGameFilename.text); //refer to 33:16 in part 1


    }


    void Start()
    {
        TextAsset gameTextAsset = Resources.Load<gameTextAsset>("Zork"); //No file extension due to Unity just referring it to Zork. 
        Game game = JsonConvert.DeserializeObject<Game>(gameTextAsset.text); 
    
        game.Start(InputService, OutputService)
    }

    
    void Update()
    {
        
    }

    [SerializeField]
    private string ZorkGameFilename = "Zork";

}
