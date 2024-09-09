using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    public int bullets;
    [SerializeField] private bool unlimitedBullets = false;
    // Start is called before the first frame update
    void Start()
    {
        bullets = 0;
        foreach (Transform bullet in transform){
            bullet.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public bool HasBullets(){
        if(unlimitedBullets){
            return true;
        }
        if (bullets > 0){
            bullets--;
            transform.GetChild(bullets).GetComponent<SpriteRenderer>().enabled = false;
            return true;
        }
        else{
            return false;
        }
    }
    public void AddBullets(){
        bullets++;
        Debug.Log("bullets added!");
        transform.GetChild(bullets - 1).GetComponent<SpriteRenderer>().enabled = true;
    }
}
