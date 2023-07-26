using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject Target;
    
    
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, Time.deltaTime * speed);
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == Target)
        {
            Destroy(gameObject);
        }
    }
}
