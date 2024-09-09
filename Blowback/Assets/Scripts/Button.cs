using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Door door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D (Collision2D collision){
        if (collision.gameObject.layer == 7){
            door.StartCoroutine(door.Shrink());
            Destroy(this.gameObject);
        }
    }
}
