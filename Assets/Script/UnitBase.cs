using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitBase : MonoBehaviour
{
    public bool bye;
    public GameObject Bullet;
    GameObject bulleta;
    // Start is called before the first frame update
    void Start()
    {
        bye=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("하이");
        bye=true;
        InRange();
    }
    void OnTriggerExit2D(Collider2D other)
    {
        bye=false;
    }


    void InRange(){
        if(bye){
            Debug.Log("하이2");
            bulleta = Instantiate(Bullet,transform.position,Bullet.transform.rotation);
            bulleta.transform.parent = gameObject.transform;
            Invoke("InRange",1f);
        }
    }
}
