
using UnityEngine;
using Zork;
using Newtonsoft.Json;
using TMPro;

public class GameManager : MonoBehaviour
    
{

    [SerializeField]
    private UnityInputService InputService;

    [SerializeField]
    private UnityOutputService OutputService;

    [SerializeField]
    private TextMeshProUGUI CurrentLocationText;

    void Start()
    {
        TextAsset gameTextAsset = Resources.Load<TextAsset>(ZorkGameFilename); //No file extension due to Unity just referring it to Zork. 
        _game = JsonConvert.DeserializeObject<Game>(gameTextAsset.text);
        _game.Player.LocationChanged += (sender, newLocation) => CurrentLocationText.text = newLocation.ToString();

        _game.Start(InputService, OutputService);
    }

    
    private void Update()
    {
        if ( _game.Player.Location != _previousLocation )
        {
            CurrentLocationText.text = _game.Player.Location.ToString();
            _previousLocation = _game.Player.Location;
        }
    }

    [SerializeField]
    private string ZorkGameFilename = "Zork";

    [SerializeField]
    private UnityOutputService Output;

    private Game _game;
    private Room _previousLocation;
}
