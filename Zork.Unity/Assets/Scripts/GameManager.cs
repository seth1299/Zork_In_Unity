
using UnityEngine;
using Zork;
using Newtonsoft.Json;

public class GameManager : MonoBehaviour
    
{

    [SerializeField]
    private UnityinputService InputService

    [SerializeField]
    private UnityOutputService OutputService;

    [SerializeField]
    private TextMeshProGUI CurrentLocationText;



    void Awake()
    {
      TextAsset defaultGameFilename = Resources.Load<TextAsset>(ZorkGameFilename);
        Game.Start(defaultGameFilename.text); //refer to 33:16 in part 1


    }


    void Start()
    {
        TextAsset gameTextAsset = Resources.Load<gameTextAsset>("Zork"); //No file extension due to Unity just referring it to Zork. 
        Game _fgame = JsonConvert.DeserializeObject<Game>(gameTextAsset.text);

                                                                                                                                                                            //Refer to 11/15/21 panopto @ 254 for different Refactor

        CurrentLocationText.text = _game.Player.Location.ToString();
        _game.Start(InputService, OutputService)
    
            
            
            
            
            
            
            }

    
    private void Update()
    {
        CurrentLocationText.text = game.Player.Location.ToString();
    }

    [SerializeField]
    private string ZorkGameFilename = "Zork";

    private Game _game;
    private Room _previousLocation;
}
