using Photon.Pun;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] PhotonView view;
    
    void Update()
    {
        if (view.IsMine) Move();
    }

    void Move()
    {
        var horizontalInput = Input.GetAxisRaw("Horizontal");
        var verticalInput = Input.GetAxisRaw("Vertical");
        var moveInput = new Vector2(horizontalInput, verticalInput);
        var moveAmount = moveInput.normalized * speed * Time.deltaTime;
        
        transform.position += (Vector3)moveAmount;
    }

}