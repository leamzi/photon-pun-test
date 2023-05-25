using Photon.Pun;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    const string MainMenuScene = "MainMenu";
    public override void OnConnectedToMaster()
    {
        Debug.Log($"Connected to Master");
        SceneManager.LoadScene(MainMenuScene);
    }

    void Start() => PhotonNetwork.ConnectUsingSettings();
}