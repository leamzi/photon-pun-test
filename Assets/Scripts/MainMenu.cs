using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviourPunCallbacks
{
    [SerializeField] Button createRoomButton, joinRoomButton;
    [SerializeField] TMP_InputField createRoomInput;
    [SerializeField] TMP_InputField joinRoomInput;
    
    const string GameScene = "GameScene";

    void Start()
    {
        createRoomButton.onClick.AddListener(CreateRoom);
        joinRoomButton.onClick.AddListener(JoinRoom);
    }

    void CreateRoom()
    {
        var roomOptions = new RoomOptions
        {
            MaxPlayers = 2
        };
           
        PhotonNetwork.CreateRoom(createRoomInput.text, roomOptions);
    }

    void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinRoomInput.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel(GameScene);
    }
}