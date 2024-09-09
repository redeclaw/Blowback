using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChecker : MonoBehaviour
{
    private void OnCollisionEnter2D (Collision2D collision){
        switch (collision.gameObject.layer){
            case 10:
            Die();
            break;

            case 11:
            Goal();
            break;
        }
    }
    public void Die(){
        Debug.Log("dead!");
        Reset();
    }
    public void Reset(){
        Debug.Log("reset");
        LevelManager.ResetLevel();
    }
    public void Goal(){
        Debug.Log("goal!");
        LevelManager.NextLevel();
    }
}
