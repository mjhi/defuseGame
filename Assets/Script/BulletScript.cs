using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    GameObject g;
    UnitBase w;
    // Start is called before the first frame update
    void Start()
    {
        g=transform.parent.gameObject;
        w=g.GetComponent<UnitBase>();
        Debug.Log(w.bye);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
