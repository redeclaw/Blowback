using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPickup : MonoBehaviour
{
    public ShootingController shootingController;
    // Start is called before the first frame update
    void Start()
    {
        shootingController = GameObject.Find("Ammo Display").GetComponent<ShootingController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.layer == 6){
            Destroy(this.gameObject);
            shootingController.AddBullets();
        }
    }
}
