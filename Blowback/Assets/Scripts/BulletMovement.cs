using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletMovement : MonoBehaviour
{
	[SerializeField] private float speed = .5f;
    public float rotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate(){
        transform.position += new Vector3(math.cos(rotation) * speed, math.sin(rotation) * speed, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision){
        Debug.Log("colliding!");
        Destroy(this.gameObject);
    }
}
