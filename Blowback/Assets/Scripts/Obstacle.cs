using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
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
            Destroy(this.gameObject);
        }
    }
    public IEnumerator Shrink (){
        Vector3 scaleChange = new(0, transform.localScale.y / -100, 0);
        Vector3 positionChange = scaleChange / -2;
            for (int i = 0; i < 100; i++){
                transform.localScale += scaleChange;
                transform.localPosition += positionChange;
                yield return new WaitForSeconds(.01f);
                //Debug.Log(transform.localScale.y);
            }
        Destroy(this.gameObject);
    }
}
