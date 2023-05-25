using Photon.Pun;
using UnityEngine;
using Random = UnityEngine.Random;

public class Gameplay : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;
    [SerializeField] float spawnMinX, spawnMinY, spawnMaxX, spawnMaxY;

    void Start()
    {
        var randomPosition = GetRandomPosition();
        PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
    }

    Vector2 GetRandomPosition() => 
        new(Random.Range(spawnMinX, spawnMaxX), Random.Range(spawnMinY, spawnMaxY));
}