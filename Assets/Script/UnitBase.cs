using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitBase : MonoBehaviour
{
    public bool bye;
    public GameObject Bullet;
    GameObject bulleta;
    public List<GameObject> Target = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        bye=false;
        InRange();

    }

    // Update is called once per frame
    void Update()
    {
        if(Target.Count==0)
        {
            bye=false;
        }
    }
    
    // void OnTriggerEnter2D(Collider2D other)
    // {
    //     if(other.gameObject.tag=="Enemy"&&!bye){
    //         // Debug.Log(other.gameObject.name);
    //         Debug.Log("ww");
    //         Target = other.gameObject;
    //         bye=true;
    //         InRange();
    //     }
        
    // }
    void OnTriggerExit2D(Collider2D other)
    {
        // Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag=="Enemy"){
            Target.Remove(other.gameObject);
            
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.gameObject.tag=="Enemy"){
            Target.Add(other.gameObject);
            bye=true;
        }
        
    }


    void InRange(){
        if(bye){
            Debug.Log("생성!");
            bulleta = Instantiate(Bullet,transform.position,Bullet.transform.rotation);
            bulleta.SetActive(false);
            bulleta.GetComponent<BulletScript>().Target = Target[0];
            bulleta.SetActive(true);
            // bulleta.transform.parent = gameObject.transform;
            
            
        }
        Invoke("InRange",1.0f);
    }
}
