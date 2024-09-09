using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizontalMove;
    public const float runSpeed = 15f;
    public CharacterController2D characterController2D;
    public bool jump = false;
    public ShootingController shootingController;    
    
    void Start(){
        shootingController = GameObject.Find("Ammo Display").GetComponent<ShootingController>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            Debug.Log("click");
            if (shootingController.HasBullets()){
                characterController2D.Shoot();
            }
        }
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump")){
            jump = true;
        }
    }
    void FixedUpdate(){
        characterController2D.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }
}
