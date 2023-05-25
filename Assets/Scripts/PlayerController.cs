using Photon.Pun;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PhotonView view;
    [SerializeField] Animator animator;
    [SerializeField] float speed;
    
    static readonly int IsRunning = Animator.StringToHash("isRunning");

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
        animator.SetBool(IsRunning, moveInput != Vector2.zero);
    }

}